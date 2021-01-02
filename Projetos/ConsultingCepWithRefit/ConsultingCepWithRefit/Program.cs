using System;
using System.Text;
using System.Threading.Tasks;

namespace ConsultingCepWithRefit
{
    public static class Program
    {
        /// <summary>
        /// URL base da API a ser utilizada para consultar o CEP.
        /// </summary>
        private const string hostUrl = "https://viacep.com.br";

        /// <summary>
        /// Execute este programa pelo Prompt de Comando do Windows, passando como parâmetro, o CEP que deseja consultar.
        /// 
        /// Para obter informações de como realizar este procedimento, consulte a documentação da Microsoft:
        /// https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/main-and-command-args/command-line-arguments
        /// </summary>
        /// <param name="args">CEP a ser consultado.</param>
        /// <returns></returns>
        public static async Task Main(string[] args)
        {
            try
            {
                // Verifica se o houve algum valor informado na chamada do executável.
                if (args.Length == 0)
                {
                    throw new CepException("CEP não informado na inicialização do programa!");
                }

                // Armazena o valor informado em uma variável.
                string cep = args[0];

                // Verifica se o valor informado é numérico.
                if (!double.TryParse(cep, out _))
                {
                    throw new CepException("O CEP informado contém caracteres inválidos! Por favor, digite apenas números.");
                }

                // Realiza a consulta do CEP.
                var cepClient = Refit.RestService.For<ICepApiService>(hostUrl);
                var response = await cepClient.GetAddressAsync(cep);

                // Monta a mensagem de retorno com os dados do CEP
                var sb = new StringBuilder();

                sb.AppendLine("----------------------------------------------");
                sb.AppendLine("A consulta retornou as seguintes informações: ");
                sb.AppendLine();
                sb.AppendLine("CEP..........: " + response.Cep);
                sb.AppendLine("Logradouro...: " + response.Logradouro);
                sb.AppendLine("Complemento..: " + response.Complemento);
                sb.AppendLine("Bairro.......: " + response.Bairro);
                sb.AppendLine("Localidade...: " + response.Localidade);
                sb.AppendLine("Estado.......: " + response.Uf);
                sb.AppendLine("Unidade......: " + response.Unidade);
                sb.AppendLine("Código IBGE..: " + response.Ibge);
                sb.AppendLine("Gia..........: " + response.Gia);
                sb.AppendLine("----------------------------------------------");

                // Escreve os dados na tela.
                Console.WriteLine();
                Console.WriteLine(sb.ToString());
            }
            catch (CepException ex)
            {
                // Tratando possíveis erros esperados.
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                // Tratando erros inesperados.
                Console.WriteLine("Ops!! Ocorreu um erro inesperado no sistema.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Mensagem de finalização.
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para sair...");
                Console.ReadKey();
            }
        }
    }
}
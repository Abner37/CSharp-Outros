using Refit;
using System.Threading.Tasks;

namespace ConsultingCepWithRefit
{
    public interface ICepApiService
    {
        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetAddressAsync(string cep);
    }
}
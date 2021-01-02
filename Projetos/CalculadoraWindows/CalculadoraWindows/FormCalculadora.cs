using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraWindows
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        double valor1, valor2;
        string operacao;

        bool substituir;

        //Código copy and paste que possibilita mover o form pela tela :)
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            btnIgual.Select();
        }
        private void lblCalculadora_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panelBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pctMenuBack_MouseLeave(object sender, EventArgs e)
        {
            if (pctMenuBack.BackColor == Color.FromArgb(30, 30, 30))
            {
                pctMenuBack.BackColor = Color.FromArgb(64, 64, 64);
                pctMenu.BackColor = Color.FromArgb(64, 64, 64);
                pctMenu.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\img\menu48Hover.png");
            }
            else
            {
                pctMenuBack.BackColor = Color.FromArgb(30, 30, 30);
                pctMenu.BackColor = Color.FromArgb(30, 30, 30);
                pctMenu.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\img\menu48Normal.png");
            }
        }
        private void pctRelogioBack_MouseLeave(object sender, EventArgs e)
        {
            if (pctRelogioBack.BackColor == Color.FromArgb(30, 30, 30))
            {
                pctRelogioBack.BackColor = Color.FromArgb(64, 64, 64);
                pctRelogio.BackColor = Color.FromArgb(64, 64, 64);
                pctRelogio.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\img\relogioHover.png");
            }
            else
            {
                pctRelogioBack.BackColor = Color.FromArgb(30, 30, 30);
                pctRelogio.BackColor = Color.FromArgb(30, 30, 30);
                pctRelogio.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\img\relogioNormal.png");
            }
        }
        private void FormCalculadora_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    btnCE_Click(null, null);
                    break;
                case Keys.Escape:
                    btnC_Click(null, null);
                    break;
                case Keys.Back:
                    btnBackspace_Click(null, null);
                    break;


                case Keys.NumPad0:
                    btn0_Click(null, null);
                    break;

                case Keys.NumPad1:
                    btn1_Click(null, null);
                    break;

                case Keys.NumPad2:
                    btn2_Click(null, null);
                    break;

                case Keys.NumPad3:
                    btn3_Click(null, null);
                    break;

                case Keys.NumPad4:
                    btn4_Click(null, null);
                    break;

                case Keys.NumPad5:
                    btn5_Click(null, null);
                    break;

                case Keys.NumPad6:
                    btn6_Click(null, null);
                    break;

                case Keys.NumPad7:
                    btn7_Click(null, null);
                    break;

                case Keys.NumPad8:
                    btn8_Click(null, null);
                    break;

                case Keys.NumPad9:
                    btn9_Click(null, null);
                    break;

                case Keys.Oemcomma:
                    btnVirgula_Click(null, null);
                    break;


                case Keys.Divide:
                    btnDividir_Click(null, null);
                    break;
                case Keys.Multiply:
                    btnVezes_Click(null, null);
                    break;
                case Keys.Subtract:
                    btnMenos_Click(null, null);
                    break;
                case Keys.Add:
                    btnMais_Click(null, null);
                    break;
                case Keys.Return:
                    btnIgual_Click(null, null);
                    break;

                default:
                    break;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (GetDisplayLenght() > 15)
                return;

            InsereDigito("0");
            AutoSizeDisplay(true);
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (GetDisplayLenght() > 15)
                return;

            InsereDigito("1");
            AutoSizeDisplay(true);
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (GetDisplayLenght() > 15)
                return;

            InsereDigito("2");
            AutoSizeDisplay(true);
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (GetDisplayLenght() > 15)
                return;

            InsereDigito("3");
            AutoSizeDisplay(true);
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (GetDisplayLenght() > 15)
                return;

            InsereDigito("4");
            AutoSizeDisplay(true);
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (GetDisplayLenght() > 15)
                return;

            InsereDigito("5");
            AutoSizeDisplay(true);
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (GetDisplayLenght() > 15)
                return;

            InsereDigito("6");
            AutoSizeDisplay(true);
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (GetDisplayLenght() > 15)
                return;

            InsereDigito("7");
            AutoSizeDisplay(true);
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (GetDisplayLenght() > 15)
                return;

            InsereDigito("8");
            AutoSizeDisplay(true);
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (GetDisplayLenght() > 15)
                return;

            InsereDigito("9");
            AutoSizeDisplay(true);
        }
        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Contains(","))
                return;

            if (GetDisplayLenght() > 15)
                return;

            lblDisplay.Text += ",";
            Application.DoEvents();

            AutoSizeDisplay(true);
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            if (lblMiniDisplay.Text.Contains("="))
            {
                btnC_Click(null, null);
            }
            else
            {
                lblDisplay.Text = "0";
                AutoSizeDisplay(false, true);
            }
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            AutoSizeDisplay(false, true);
            lblMiniDisplay.Text = "";

            valor1 = 0;
            valor2 = 0;
            operacao = null;
            substituir = false;
        }
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (lblMiniDisplay.Text.Contains("="))
            {
                btnC_Click(null, null);
            }
            else
            {
                lblDisplay.Text = GetDisplayLenght() == 1 ? "0" : lblDisplay.Text.Substring(0, lblDisplay.Text.Length - 1);
                Application.DoEvents();
                AutoSizeDisplay(false);
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblMiniDisplay.Text) && !lblMiniDisplay.Text.Contains("="))
            {
                InsereNoMiniDisplay($"{lblDisplay.Text} / ");
                valor2 = Convert.ToDouble(lblDisplay.Text);
                double resultado = CalcularResultado();
                lblDisplay.Text = resultado.ToString();
                AutoSizeDisplay(true);
                valor1 = resultado;

                operacao = "/";
                substituir = true;

                return;
            }

            valor1 = Convert.ToDouble(lblDisplay.Text);
            InsereNoMiniDisplay($"{lblDisplay.Text} / ");
            operacao = "/";

            substituir = true;
        }
        private void btnVezes_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblMiniDisplay.Text) && !lblMiniDisplay.Text.Contains("="))
            {
                InsereNoMiniDisplay($"{lblDisplay.Text} * ");
                valor2 = Convert.ToDouble(lblDisplay.Text);
                double resultado = CalcularResultado();
                lblDisplay.Text = resultado.ToString();
                AutoSizeDisplay(true);
                valor1 = resultado;

                operacao = "*";
                substituir = true;

                return;
            }

            valor1 = Convert.ToDouble(lblDisplay.Text);
            InsereNoMiniDisplay($"{lblDisplay.Text} * ");
            operacao = "*";

            substituir = true;
        }
        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblMiniDisplay.Text) && !lblMiniDisplay.Text.Contains("="))
            {
                InsereNoMiniDisplay($"{lblDisplay.Text} - ");
                valor2 = Convert.ToDouble(lblDisplay.Text);
                double resultado = CalcularResultado();
                lblDisplay.Text = resultado.ToString();
                AutoSizeDisplay(true);
                valor1 = resultado;

                operacao = "-";
                substituir = true;

                return;
            }

            valor1 = Convert.ToDouble(lblDisplay.Text);
            InsereNoMiniDisplay($"{lblDisplay.Text} - ");
            operacao = "-";

            substituir = true;
        }
        private void btnMais_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblMiniDisplay.Text) && !lblMiniDisplay.Text.Contains("="))
            {
                InsereNoMiniDisplay($"{lblDisplay.Text} + ");
                valor2 = Convert.ToDouble(lblDisplay.Text);
                double resultado = CalcularResultado();
                lblDisplay.Text = resultado.ToString();
                AutoSizeDisplay(true);
                valor1 = resultado;

                operacao = "+";
                substituir = true;

                return;
            }

            valor1 = Convert.ToDouble(lblDisplay.Text);
            InsereNoMiniDisplay($"{lblDisplay.Text} + ");
            operacao = "+";

            substituir = true;
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            double resultado;

            if (lblMiniDisplay.Text.Contains("="))
            {
                valor2 = Convert.ToDouble(lblDisplay.Text);
                InsereNoMiniDisplay($"{valor1} {operacao} {valor2} = ");

                resultado = CalcularResultado();
                lblDisplay.Text = resultado.ToString();
                AutoSizeDisplay(true);
            }
            else
            {
                valor2 = Convert.ToDouble(lblDisplay.Text);

                lblMiniDisplay.Text += $"{lblDisplay.Text} = ";

                resultado = CalcularResultado();

                lblDisplay.Text = resultado.ToString();
                AutoSizeDisplay(true);
            }

            substituir = true;
        }

        private int GetDisplayLenght()
        {
            return lblDisplay.Text.Replace(",", "").Length;
        }
        private void InsereDigito(string numero)
        {
            if (substituir)
            {
                lblDisplay.Text = numero;

                if (lblMiniDisplay.Text.Contains("="))
                    lblMiniDisplay.Text = string.Empty;

                Application.DoEvents();

                substituir = false;
                return;
            }

            if (lblDisplay.Text == "0")
                lblDisplay.Text = numero;
            else
                lblDisplay.Text += numero;

            Application.DoEvents();
        }
        private void AutoSizeDisplay(bool diminuirFonte, bool fontDefault = false)
        {
            if (diminuirFonte)
            {
                if (GetDisplayLenght() > 10)
                {
                    if (GetDisplayLenght() < 17)
                    {
                        Font font = new Font(lblDisplay.Font.FontFamily, (lblDisplay.Font.Size - 2), FontStyle.Bold);
                        lblDisplay.Font = font;
                    }
                }
            }
            else
            {
                if (fontDefault)
                {
                    Font font = new Font(lblDisplay.Font.FontFamily, 36, FontStyle.Bold);
                    lblDisplay.Font = font;

                    return;
                }

                if (GetDisplayLenght() > 9)
                {
                    Font font = new Font(lblDisplay.Font.FontFamily, (lblDisplay.Font.Size + 2), FontStyle.Bold);
                    lblDisplay.Font = font;
                }
            }
        }

        private double CalcularResultado()
        {
            switch (operacao)
            {
                case "/":
                    return Calculos.Dividir(valor1, valor2);

                case "*":
                    return Calculos.Multiplicar(valor1, valor2);

                case "-":
                    return Calculos.Subtrair(valor1, valor2);

                case "+":
                    return Calculos.Somar(valor1, valor2);

                default:
                    return 0;
            }
        }
        private void InsereNoMiniDisplay(string text)
        {
            if (lblMiniDisplay.Text.Contains("="))
            {
                lblMiniDisplay.Text = string.Empty;
            }

            lblMiniDisplay.Text += text;
        }
    }
}

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor;

            if (double.TryParse(textBox1.Text, out valor))
            {
                string origen = comboBox1.Text;
                string destino = comboBox2.Text;

                double enMetros = 0;

                if (origen == "Metros")
                    enMetros = valor;
                else if (origen == "Centímetros")
                    enMetros = valor / 100;
                else if (origen == "Pulgadas")
                    enMetros = valor * 0.0254;

                double resultado = 0;

                if (destino == "Metros")
                    resultado = enMetros;
                else if (destino == "Centímetros")
                    resultado = enMetros * 100;
                else if (destino == "Pulgadas")
                    resultado = enMetros / 0.0254;

                label1.Text = "Resultado: " + resultado.ToString("0.00");
            }
            else
            {
                MessageBox.Show("Número inválido");
            }
        }
    }
    }


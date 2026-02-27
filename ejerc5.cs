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
           
            // Convertimos el número ingresado a entero
            if (int.TryParse(maskedTextBox1.Text, out int numero))
            {
                if (numero < 2)
                {
                    MessageBox.Show("El número no es primo.");
                    return;
                }

                bool esPrimo = true;
                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                if (esPrimo)
                    MessageBox.Show("El número es primo.");
                else
                    MessageBox.Show("El número no es primo.");
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.");
            }
        }
    }
    }


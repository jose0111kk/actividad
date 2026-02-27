namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        
            private void button1_Click(object sender, EventArgs e)
        {
            int numero;

            if (int.TryParse(maskedTextBox1.Text, out numero))
            {
                int suma = 0;

                for (int i = 1; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        suma += i;
                    }
                }

                if (suma == numero && numero != 0)
                {
                    MessageBox.Show("Es un número perfecto");
                }
                else
                {
                    MessageBox.Show("No es un número perfecto");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido");
            }
        }

    }
    }


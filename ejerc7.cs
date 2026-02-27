namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int inicio, fin;

            if (int.TryParse(textBox1.Text, out inicio) && int.TryParse(textBox2.Text, out fin))
            {
                listBox1.Items.Clear();

                for (int num = inicio; num <= fin; num++)
                {
                    bool esPrimo = true;

                    if (num <= 1)
                        esPrimo = false;

                    for (int i = 2; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            esPrimo = false;
                            break;
                        }
                    }

                    if (esPrimo)
                    {
                        listBox1.Items.Add(num);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese números válidos");
            }
        }
    }
}

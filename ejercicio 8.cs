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
            string texto = textBox1.Text.Trim();

            if (texto == "")
            {
                label1.Text = "Ingrese una oración";
            }
            else
            {
                string[] palabras = texto.Split(' ');
                int contador = 0;

                foreach (string palabra in palabras)
                {
                    if (palabra != "")
                    {
                        contador++;
                    }
                }

                label1.Text = "Cantidad de palabras: " + contador;
            }
        }
    }
}

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
            
            // Tomamos la palabra del TextBox
            string palabra = textBox1.Text.Trim().ToLower();

            // Quitamos espacios y caracteres especiales
            string limpia = "";
            foreach (char c in palabra)
            {
                if (char.IsLetterOrDigit(c))
                    limpia += c;
            }

            // Invertimos la palabra
            char[] array = limpia.ToCharArray();
            Array.Reverse(array);
            string invertida = new string(array);

            // Verificamos si es palíndroma
            if (limpia == invertida)
                MessageBox.Show("¡La palabra es palíndroma!");
            else
                MessageBox.Show("La palabra no es palíndroma.");
        }
    }
    }


namespace ejercicio2
{
    public partial class Form1 : Form
    {
        int tiempoTotal = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInicial_Click(object sender, EventArgs e)
        { }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int minutos, segundos;

            if (int.TryParse(txtMinutos.Text, out minutos) &&
                int.TryParse(txtSegundos.Text, out segundos))
            {
                tiempoTotal = (minutos * 60) + segundos;

                if (tiempoTotal > 0)
                {
                    timer1.Start();
                }
                else
                {
                    MessageBox.Show("Ingresa un tiempo válido");
                }
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        { }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (tiempoTotal > 0)
            {
                tiempoTotal--;

                int minutos = tiempoTotal / 60;
                int segundos = tiempoTotal % 60;

                IbITiempo.Text = minutos.ToString("00") + ":" + segundos.ToString("00");
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("¡Tiempo terminado!");
            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        { }
            private void BtnDetener_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
    }



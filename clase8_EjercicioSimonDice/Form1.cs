namespace clase8_EjercicioSimonDice
{
    public partial class Form1 : Form
    {
        private int indiceActual;
        private int nivelActual;
        private int[] combinacionColores;
        private int[] combinacionColoresJugador;
        private Random rnd;
        private int timerSegundos;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {

        }

        private void IniciarJuego()
        {
 
        }

        private void timerSimon_Tick(object sender, EventArgs e)
        {
            timerSegundos++;
            labelTimer.Text = timerSegundos.ToString();
        }

        private void buttonVerde_Click(object sender, EventArgs e)
        {

        }

        private void buttonRojo_Click(object sender, EventArgs e)
        {

        }

        private void buttonAmarillo_Click(object sender, EventArgs e)
        {

        }

        private void buttonAzul_Click(object sender, EventArgs e)
        {

        }
    }
}
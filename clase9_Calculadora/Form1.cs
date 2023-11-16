namespace clase9_Calculadora
{
    public partial class Form1 : Form
    {
        List<String> expresion;
        public Form1()
        {
            this.expresion = new List<String>();
            InitializeComponent();
        }
        private void buttonCero_Click(object sender, EventArgs e)
        {
            labelOperacion.Text += "0";
        }

        private void buttonUno_Click(object sender, EventArgs e)
        {
            labelOperacion.Text += "1";
        }

        private void buttonDos_Click(object sender, EventArgs e)
        {
            labelOperacion.Text += "2";
        }

        private void buttonTres_Click(object sender, EventArgs e)
        {
            labelOperacion.Text += "3";
        }

        private void buttonCuatro_Click(object sender, EventArgs e)
        {
            labelOperacion.Text += "4";
        }

        private void buttonCinco_Click(object sender, EventArgs e)
        {
            labelOperacion.Text += "5";
        }

        private void buttonSeis_Click(object sender, EventArgs e)
        {
            labelOperacion.Text += "6";
        }

        private void buttonSiete_Click(object sender, EventArgs e)
        {
            labelOperacion.Text += "7";
        }

        private void buttonOcho_Click(object sender, EventArgs e)
        {
            labelOperacion.Text += "8";
        }

        private void buttonNueve_Click(object sender, EventArgs e)
        {
            labelOperacion.Text += "9";
        }

        private void buttonComa_Click(object sender, EventArgs e)
        {
            labelOperacion.Text += ",";
        }

        private void buttonObelo_Click(object sender, EventArgs e)
        {
            labelOperacion.Text += "÷";
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            labelOperacion.Text += "x";
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            labelOperacion.Text += "+";
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            labelOperacion.Text += "-";
        }

        private void buttonBorrarTodo_Click(object sender, EventArgs e)
        {
            labelOperacion.Text = "";
        }

        private void buttonBorrarUno_Click(object sender, EventArgs e)
        {
            if (labelOperacion.Text.Length != 0)
            {
                String operacion = labelOperacion.Text;
                operacion = operacion.Substring(0, operacion.Length - 1);

                labelOperacion.Text = operacion;
            }
        }

        private void buttonFechas_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = dateTimePicker1.Value.Date;
            DateTime fecha2 = dateTimePicker2.Value.Date;
            TimeSpan diferencia = fecha1 - fecha2;
            int valor = (int)diferencia.TotalDays;

            if (diferencia.TotalDays < 0)
            {
                valor = (int)(diferencia.TotalDays * -1);
            }

            if (valor == 1) labelOperacion.Text = $"{valor.ToString()} día";
            else labelOperacion.Text = $"{valor.ToString()} días";
        }
    }
}
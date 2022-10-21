namespace WinFormsApp_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            Calcular calcular = new Calcular();            
            Resultado.Text = Convert.ToString(calcular.Soma(Convert.ToDouble(num1.Text), Convert.ToDouble(num2.Text)));
        }

        private void buttonSubtracao_Click(object sender, EventArgs e)
        {
            Calcular calcular = new Calcular();
            Resultado.Text = Convert.ToString(calcular.Sub(Convert.ToDouble(num1.Text), Convert.ToDouble(num2.Text)));
        }

        private void buttonMultiplicacao_Click(object sender, EventArgs e)
        {
            Calcular calcular = new Calcular();
            Resultado.Text = Convert.ToString(calcular.Multi(Convert.ToDouble(num1.Text), Convert.ToDouble(num2.Text)));
        }

        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            Calcular calcular = new Calcular();
            Resultado.Text = Convert.ToString(calcular.Div(Convert.ToDouble(num1.Text), Convert.ToDouble(num2.Text)));
        }

        private void buttonSaida_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
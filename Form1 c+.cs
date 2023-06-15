namespace calculo_quadrado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txt_numero.Text);
            lbl_resultado.Text = "O quadrado de " + numero + " é " + (numero * numero).ToString();

        }
    }
}
namespace MaiorValor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor1 = (int)numericUpDown1.Value;
            int valor2 = (int)numericUpDown2.Value;
            int valor3 = (int)numericUpDown3.Value;
            string resp;

            if (valor1 > valor2 && valor1 > valor3)
            {
                resp = "O maior número é " + Convert.ToString(valor1);
                label1.Text = resp;
            }
            else
            {
                if (valor2 > valor1 && valor2 > valor3)
                {
                    resp = "O maior número é " + Convert.ToString(valor2);
                    label1.Text = resp;

                }
                else
                {
                    resp = "O maior número é " + Convert.ToString(valor3);
                    label1.Text = resp;
                }

            }
        }
    }
}
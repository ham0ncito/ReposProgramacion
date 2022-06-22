namespace imc
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txtimc.Clear();
            txtkilos.Clear();
            txtlibras.Clear();
            txtmetros.Clear();
            txtpies.Clear();
            lblpeso.Visible = false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            lblpeso.Visible = true;
            lblpeso.Text = 
        }
    }
}
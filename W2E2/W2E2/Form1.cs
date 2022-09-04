namespace W2E2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            label2.Text = tb.Text + " doubled is " + Convert.ToInt32(tb.Text) * 2;
        }
    }
}
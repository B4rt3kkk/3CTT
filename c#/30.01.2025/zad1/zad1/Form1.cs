namespace zad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 wolfzkapeluszem = new Form2();
            wolfzkapeluszem.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 bambik = new Form3();
            bambik.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

namespace kalkulejtor
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int txt1 = Convert.ToInt32(textBox1.Text);
            int txt2 = Convert.ToInt32(textBox2.Text);
            int dodawanie = txt1 + txt2;
            label2.Text = dodawanie.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int txt1 = Convert.ToInt32(textBox1.Text);
            int txt2 = Convert.ToInt32(textBox2.Text);
            int odejmowanie = txt1 - txt2;
            label2.Text = odejmowanie.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

                int txt1 = Convert.ToInt32(textBox1.Text);
                int txt2 = Convert.ToInt32(textBox2.Text);
                int mnozenie = txt1 * txt2;
                label2.Text = mnozenie.ToString();
        
        }
    }
}

namespace zadanko1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 loguj = new Form2();

            DialogResult response = loguj.ShowDialog();

            if (response == DialogResult.OK)
            {

               //string user = loguj.textBox1.Text;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 ustawKod = new Form4();
            DialogResult response = ustawKod.ShowDialog();
        }
    }
}

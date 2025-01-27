namespace zadanie2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            zmk += 1;
            string zmiana = zmk.ToString();
            Label.Text = zmiana;
        }
    }
}

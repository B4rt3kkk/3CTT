namespace przyklad_pierwszy
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
            MessageBox.Show("OKNO POWIADOMIEN", "Author: Walersan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

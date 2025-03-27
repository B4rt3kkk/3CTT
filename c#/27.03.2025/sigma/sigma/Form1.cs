using Opc.UaFx;
using Opc.UaFx.Client;

namespace sigma
{
    public partial class Form1 : Form
    {
        private OpcClient opcClient;
        private OpcClientState opcClientState;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string opcUrl = textBox1.Text;

            opcClient = new OpcClient(opcUrl);
            opcClientState = new OpcClientState();

            opcClientState = opcClient.State;

            if (opcClientState == OpcClientState.Created)
            {
                opcClient.Connect();
            }


            opcClientState = opcClient.State;

            if (opcClientState == OpcClientState.Connected)
            {
                pictureBox1.BackColor = Color.Green;
            }
            else
            {
                pictureBox1.BackColor = Color.Red;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (opcClient != null)
            {
                pictureBox1.BackColor = Color.Red;
            }

            opcClient.Disconnect();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var tagName = textBox2.Text;

            var tempereature = opcClient.ReadNode(tagName);
            textBox3.Text = tempereature.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var tagName = textBox2.Text;

            OpcSubscription opcSubscription = opcClient.SubscribeNodes();

            var item = new OpcMonitoredItem(tagName, OpcAttribute.Value);
            item.DataChangeReceived += Item_DataChagneReceived;
            item.SamplingInterval = 200;

            opcSubscription.AddMonitoredItem(item);
            opcSubscription.ApplyChanges();
        }
            private void Item_DataChagneReceived(object sender, OpcDataChangeReceivedEventArgs e) {
                OpcMonitoredItem mItem = (OpcMonitoredItem)sender;
            textBox3.Text =e.Item.Value.ToString();
            }
        }
    }



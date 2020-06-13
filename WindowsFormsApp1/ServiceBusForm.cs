using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceBusExamplewithQueue
{
    public partial class ServiceBusForm : Form
    {
        public ServiceBusForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }      

        private void createQ_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.AppSettings["Microsoft.ServiceBus.ConnectionString"];
            var qname = qNametxt.Text;
            var nameSpacemanager = NamespaceManager.Create();
            //var nameSpacemanager = NamespaceManager.CreateFromConnectionString(connectionString);
            if (!nameSpacemanager.QueueExists(qname))
                nameSpacemanager.CreateQueue(qname);

            MessageBox.Show("Queue: " + qname + "Created");
        }

        private void readQ_Click(object sender, EventArgs e)
        {
            // Get the connection string from app settings
            string connectionString = ConfigurationManager.AppSettings["Microsoft.ServiceBus.ConnectionString"];

            // Instantiate a QueueClient which will be used to create and manipulate the queue
            //QueueClient queueClient = new QueueClient();// QueueClient(connectionString, "myqueue");

            var message = string.Empty;
            var receivingclient = QueueClient.Create(qNametxt.Text);
            //var receivingclient = QueueClient.CreateFromConnectionString(connectionString, qNametxt.Text);
            BrokeredMessage msg = receivingclient.Receive();

            //Stream stream = msg.GetBody<Stream>();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void sendQ_Click(object sender, EventArgs e)
        {
            var sendingClient = QueueClient.Create(qNametxt.Text);
            object msgBody = sendQueuetxt.Text;
            sendingClient.Send(new BrokeredMessage(msgBody));
            MessageBox.Show("Message Sent To: " + qNametxt.Text + " Queue");

        }
    }
}

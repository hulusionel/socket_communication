using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.IO;


namespace SoketHaberlesme
{
    public partial class Form1 : Form    
    {
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string receive;
        public String text_to_send;

            public Form1()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName()); //own ıp
            foreach (IPAddress adress in localIP)
            {
                if (adress.AddressFamily == AddressFamily.InterNetwork)
                    txtOwnIP.Text = adress.ToString();
            }
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(txtOwnPort.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync(); //start receive data in background
            backgroundWorker2.WorkerSupportsCancellation = true; //ability to cancel this thread 
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) //receive data
        {
            while (client.Connected)
            {
                try
                {
                    receive = STR.ReadLine();
                    this.textBox2.Invoke(new MethodInvoker(delegate () { textBox2.AppendText("you : " + receive + "\n"); }));
                    receive = "";
                }
                catch(Exception x)
                {
                    MessageBox.Show(x.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e) //send data
        {
            if (client.Connected)
            {
                STW.WriteLine(text_to_send);
                this.textBox2.Invoke(new MethodInvoker(delegate () { textBox2.AppendText("Me : " + text_to_send + "\n"); }));
            }
            else
                MessageBox.Show("Send Failed");

            backgroundWorker2.CancelAsync();

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint IP_End = new IPEndPoint(IPAddress.Parse(txtClientIP.Text),int.Parse(txtClientPort.Text));
            try
            {
                client.Connect(IP_End);
                if (client.Connected)
                {
                    textBox2.AppendText("connected to server:" + "\n");
                    STW = new StreamWriter(client.GetStream());
                    STR = new StreamReader(client.GetStream());
                    STW.AutoFlush = true;
                    backgroundWorker1.RunWorkerAsync(); //start receive data in background
                    backgroundWorker2.WorkerSupportsCancellation = true; //ability to cancel this thread
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                text_to_send = textBox1.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            textBox1.Text = "";
        }
    }
}

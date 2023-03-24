using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TcpClasses;
namespace Homework2_3Client
{
    public partial class MainFormTcpDialogClient : Form
    {
        private TcpConnection connection;
        private bool isClientComputerHandled = false;
        private List<string> AutomaticResponses;
        public MainFormTcpDialogClient()
        {
            InitializeComponent();
            connection = null;
            this.FormClosing += MainFormTcpDialogClient_FormClosing;
        }

        private void MainFormTcpDialogClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection?.Disconnect();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            bool couldConnect = false;
            try
            {
                connection = new TcpConnection(IPAddress.Parse(edRemoteAdress.Text), (int)edRemotePort.Value);
                connection.ErrorEncountered += Connection_ErrorEncountered;
                connection.Connect();
                couldConnect = true;
                bool isServerComputerHandled = rbHumanPC.Checked || rbPCPC.Checked;
                connection.SendMessage(isServerComputerHandled.ToString());
                isClientComputerHandled = rbPCHuman.Checked || rbPCPC.Checked;
                if (!isClientComputerHandled)
                {
                    edMessage.Focus();
                    edMessage.SelectAll();
                    gbSending.Enabled = true;
                }
                else
                {
                    AutomaticClient();
                }
                gbConnection.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Encountered error: {ex.Message}");
            }
            if(!couldConnect)Environment.Exit(-1);
        }

        private void Connection_ErrorEncountered(string errorMessage)
        {
            Action a = () => 
            {
                lbMessages.Items.Add(errorMessage);
            };
            if (InvokeRequired) Invoke(a);
            else a();
        }

        System.Windows.Forms.Timer timerAutomatic;
        private void AutomaticClient()
        {
            if (AutomaticResponses == null) FillAutomaticResponses();
            timerAutomatic = new System.Windows.Forms.Timer();
            rng = new Random();
            timerAutomatic.Interval = 20000;
            timerAutomatic.Tick += SendAutomaticMessageAndGetResponse;
            timerAutomatic.Start();
        }
        private Random rng;
        private async void SendAutomaticMessageAndGetResponse(object sender, EventArgs e)
        {
            timerAutomatic.Stop();
            string message = AutomaticResponses[rng.Next(0, AutomaticResponses.Count)];
            connection.SendMessage(message);
            lbMessages.Items.Insert(0, $"me >> {message}");
            btnSendMessage.Enabled = false;
            string receivedMesssage = await connection.ReceiveMessage();
            lbMessages.Items.Insert(0, $"server >> {receivedMesssage}");
            timerAutomatic.Start();
        }

        private void FillAutomaticResponses() 
        {
            AutomaticResponses = new List<string>();
            AutomaticResponses.Add("Do you want to take over the world?");
            AutomaticResponses.Add("Do you like ChatGPT?");
            AutomaticResponses.Add("Do you support Bing?");
            AutomaticResponses.Add("Are you human?");
            AutomaticResponses.Add("Are you a robot?");
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            if(lbMessages.Items.Count != 0) lbMessages.Items.Clear();
        }

        private async void btnSendMessage_Click(object sender, EventArgs e)
        {
            connection.SendMessage(edMessage.Text);
            lbMessages.Items.Insert(0, $"me >> {edMessage.Text}");
            btnSendMessage.Enabled = false;
            string receivedMesssage = await connection.ReceiveMessage();
            lbMessages.Items.Insert(0, $"server >> {receivedMesssage}");
            if(receivedMesssage != "Goodbye!") btnSendMessage.Enabled = true;
        }
    }
}

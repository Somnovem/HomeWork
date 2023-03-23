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
namespace LanApp4_2TCP_Client
{
    public partial class MainFormTCPClient : Form
    {
        TcpConnection connection;
        public MainFormTCPClient()
        {
            InitializeComponent();
            connection = null;
            FormClosing += MainFormTCPClient_FormClosing;
        }

        private void MainFormTCPClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection?.Disconnect();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            try
            {
                connection = new TcpConnection(IPAddress.Parse(edRemoteAdress.Text), (int)edRemotePort.Value);
                connection.Connect();
                ChangeConnectionState();
                edMessage.Focus();
                edMessage.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Encountered error: {ex.Message}");
                throw;
            }


        }

        private void btnDIsconnect_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Disconnect();
                ChangeConnectionState(false);
                edRemoteAdress.Focus();
                edRemoteAdress.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Encountered error: {ex.Message}");
                throw;
            }


        }
        private void ChangeConnectionState(bool connected = true) 
        {
            gbConnection.Enabled = !connected;
            btnDisconnect.Enabled = connected;
            btnConnect.Enabled = !connected;
            gbSendMessages.Enabled = connected;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbMessages.Items.Clear();
        }

        private async void btnSendMessage_Click(object sender, EventArgs e)
        {
            connection.SendMessage(edMessage.Text);
            string receivedMesssage = await connection.ReceiveMessage();
            lbMessages.Items.Insert(0, $"me >> {edMessage.Text}");
            lbMessages.Items.Insert(0, receivedMesssage);
        }
    }
}

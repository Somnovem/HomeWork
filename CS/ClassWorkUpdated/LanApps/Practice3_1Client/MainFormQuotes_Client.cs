using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls;
namespace Practice3_1Client
{
    public partial class MainFormQuotes_Client : Form
    {
        TcpConnection connection;
        ListBoxMultiline lbMessages;
        public MainFormQuotes_Client()
        {
            InitializeComponent();
            connection = null;
            this.FormClosing += MainFormQuotes_Client_FormClosing;
            this.Icon = new Icon(@"..\..\icon.ico");
            lbMessages = new ListBoxMultiline();
            lbMessages.Size = new Size(509 ,324);
            lbMessages.Location = new Point(12, 239);
            this.Controls.Add(lbMessages);
        }

        private void MainFormQuotes_Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection?.Disconnect();
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new TcpConnection(IPAddress.Parse(edRemoteAddress.Text), (int)edRemotePort.Value);
                connection.Connect();
                await connection.SendMessage($"{edLogin.Text} {edPassword.Text}"); // <- Checking authorization
                string initResponse = await connection.ReceiveMessage(); // <- Getting Initial response from the server
                lbMessages.Items.Insert(0, initResponse);
                if (initResponse.StartsWith("Access") || initResponse.StartsWith("Server")) //<-Server was overflown or credentials were invalid
                {
                    return;
                }
                gbConnection.Enabled = false;
                btnGetQuote.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Encountered error: {ex.Message}");
                throw;
            }
        }

        private async void btnGetQuote_Click(object sender, EventArgs e)
        {
            btnGetQuote.Enabled = false;
            try
            {
                string request = "Next";
                lbMessages.Items.Insert(0, $"me >> {request}");
                await connection.SendMessage(request);
                string receivedMesssage = await connection.ReceiveMessage();
                lbMessages.Items.Insert(0, receivedMesssage);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Encountered error: {ex.Message}");
            }
            finally
            {
                btnGetQuote.Enabled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (lbMessages.Items.Count != 0) lbMessages.Items.Clear();
        }
    }
}

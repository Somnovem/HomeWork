using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls;
namespace Homework3_1Client
{
    public partial class MainFormTcpDialogClient : Form
    {
        private TcpConnection connection;
        private ListBoxMultiline lbMessages;
        public MainFormTcpDialogClient()
        {
            lbMessages = new ListBoxMultiline();
            lbMessages.Size = new Size(509, 270);
            lbMessages.Location = new Point(12, 320);
            this.Controls.Add(lbMessages);
            InitializeComponent();
            connection = null;
            this.FormClosing += MainFormTcpDialogClient_FormClosing;
            this.Icon = new Icon(@"..\..\icon.ico");
        }

        private void MainFormTcpDialogClient_FormClosing(object sender, FormClosingEventArgs e)
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
                string currencies = await connection.ReceiveMessage(); // <- Getting Initial response from the server
                if (currencies.StartsWith("Access") || currencies.StartsWith("Server")) //<-Server was overflown or credentials were invalid
                {
                    lbMessages.Items.Insert(0, currencies);
                    return;
                }
                string[] currencyCodes = currencies.Split(" ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
                cbCurrencyFrom.Items.AddRange(currencyCodes);
                cbCurrencyTo.Items.AddRange(currencyCodes);
                cbCurrencyFrom.SelectedIndex = 0;
                cbCurrencyTo.SelectedIndex = 1;
                gbConnection.Enabled = false;
                gbRequest.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Encountered error: {ex.Message}");
                throw;
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            string currencyFrom = (string)cbCurrencyFrom.SelectedItem;
            string currencyTo = (string)cbCurrencyTo.SelectedItem;
            try
            {
                if (currencyFrom.Equals(currencyTo))
                {
                    MessageBox.Show("No point in exchanging the currency into itself");
                    return;
                }
                string request = $"{currencyFrom} {currencyTo}";
                lbMessages.Items.Insert(0, $"me >> {request}");
                await  connection.SendMessage(request);
                string receivedMesssage = await connection.ReceiveMessage();
                lbMessages.Items.Insert(0, receivedMesssage);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Encountered error: {ex.Message}");
            }
            finally
            {
                btnSend.Enabled = true;
            }        
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (lbMessages.Items.Count != 0) lbMessages.Items.Clear();
        }
    }
}

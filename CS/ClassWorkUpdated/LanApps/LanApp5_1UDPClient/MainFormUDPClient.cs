using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
namespace LanApp5_1UDPClient
{
    public partial class MainFormUDPClient : Form
    {
        private UdpClient client;
        private UdpClient receiver;
        public MainFormUDPClient()
        {
            client = null;
            InitializeComponent();
            this.FormClosing += MainFormUDPClient_FormClosing;
        }

        private void MainFormUDPClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                btnDisconnect_Click(null, null);
            }
            catch {} //называеться заглушка, ловим любое исколючение, но ничего с ними не делаем
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (lbMessages.Items.Count != 0) lbMessages.Items.Clear();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (client != null) return;
            client = new UdpClient();
            receiver = new UdpClient((int)edLocalPort.Value);
            btnDisconnect.Enabled = true;
            gbSendMessages.Enabled = true;
            btnConnect.Enabled = false;
            Task.Run(ReceiveMessages);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (client == null) return;
            try
            {
                client.Close();
                receiver.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Encountered error: {ex.Message}");
            }
            finally
            {
                client = null;
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                gbSendMessages.Enabled = false;
            }

        }

        private byte[] bytesSend = null;
        private async void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (client == null) return;
            btnSendMessage.Enabled = false;
            try
            {

                bytesSend = Encoding.UTF8.GetBytes(edMessage.Text);
                await client.SendAsync(bytesSend, bytesSend.Length,
                    new IPEndPoint(IPAddress.Parse(edRemoteAdress.Text), (int)edRemotePort.Value));
                lbMessages.Items.Insert(0, $"me >> {edMessage.Text}");
            }
            catch { }
            finally
            {
                btnSendMessage.Enabled = true;
            }
        }

        private void ReceiveMessages()
        {
            
            IPEndPoint remotePoint = null;
            StringBuilder builder = new StringBuilder();
            try
            {
                //цикл подключения сообщений
                while (true)
                {

                    //if (token.IsCancellationRequested) break; -- принудительно выходим, поэтому токен даже не нужен

                    do
                    {
                        byte[] data = receiver.Receive(ref remotePoint);
                        builder.Append(Encoding.UTF8.GetString(data));

                    } while (receiver.Available > 0);
                    Action a = () => lbMessages.Items.Insert(0, $"{remotePoint.Address} >> {builder}");
                    if (InvokeRequired) Invoke(a);
                    else a();
                    builder.Clear();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                
            }
            finally 
            {
                receiver = null;
            }
            
        }
    }
}

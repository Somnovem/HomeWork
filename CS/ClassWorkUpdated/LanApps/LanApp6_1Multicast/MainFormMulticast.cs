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
namespace LanApp6_1Multicast
{
    public partial class MainFormMulticast : Form
    {
        private UdpClient receiverUdp;
        private UdpClient senderUdp;
        public MainFormMulticast()
        {
            receiverUdp = senderUdp = null;
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(lbMessages.Items.Count != 0) lbMessages.Items.Clear();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (senderUdp != null) return;
            Task.Run(() => ReceiveMessage((int)edRemotePort.Value,edRemoteAdress.Text));
            IPEndPoint senderIp = new IPEndPoint(IPAddress.Any,(int)edRemotePort.Value);
            senderUdp = new UdpClient(senderIp);
            SetLockState();
        }

        private void SetLockState() 
        {
            gbConnection.Enabled = !gbConnection.Enabled;
            gbSendMessages.Enabled = !gbConnection.Enabled;
            btnConnect.Enabled = !btnConnect.Enabled;
            btnDisconnect.Enabled = !btnDisconnect.Enabled;
        }

        private  void ReceiveMessage(int port, string address)
        {
            try
            {
                receiverUdp = new UdpClient(port);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            receiverUdp.JoinMulticastGroup(IPAddress.Parse(address),20); // 20 - количество хопов которое может сделать
            StringBuilder builder = new StringBuilder();
            IPEndPoint remoteEndPoint = null;
            try
            {
                byte[] data = null;
                while (true)
                {
                    do
                    {
                        data = receiverUdp.Receive(ref remoteEndPoint);
                        builder.Append(Encoding.UTF8.GetString(data));
                    } while (receiverUdp.Available > 0);
                    Action a = () => 
                    {
                        lbMessages.Items.Insert(0,$"{remoteEndPoint} >> {builder}");                    
                    };
                    Invoke(a);
                    builder.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edNickname.Text)) return;
            try
            {
                btnSendMessage.Enabled = false;
                byte[] data = Encoding.UTF8.GetBytes($"{edNickname.Text}: {edMessage.Text}");
                senderUdp.Send(data, data.Length);
            }
            catch
            {
            }
            finally 
            {
                btnSendMessage.Enabled = true;
            }

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                senderUdp.Close();
                receiverUdp.Close();
            }
            catch
            {
            }
            finally 
            {
                senderUdp = null;
                receiverUdp = null;
                SetLockState();
            }
            
        }


        //private async void ReceiveMessage(int port,string address) 
        //{
        //    receiverUdp = new UdpClient(port);
        //    receiverUdp.JoinMulticastGroup(IPAddress.Parse(address));
        //    try
        //    {
        //        UdpReceiveResult data;
        //        StringBuilder builder = new StringBuilder();
        //        byte[] arr;
        //        while (true)
        //        {
        //            data = await receiverUdp.ReceiveAsync();
        //            arr = data.Buffer;
        //            builder.Append(Encoding.UTF8.GetString(arr));
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(this, ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

    }
}

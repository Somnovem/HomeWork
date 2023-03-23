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
namespace LanApp3_1
{
    public partial class MainFormUDP : Form
    {
        //сокет для приема сообщений
        private Socket listeningSocket = null;
        //порт для отправки
        private int localPort;
        //порт для чтения
        private int remotePort;
        //адрес для отправки
        private IPEndPoint remoteEndPoint;
        private Task listeningTask;
        public MainFormUDP()
        {
            InitializeComponent();
        }

        private void btnStartReceive_Click(object sender, EventArgs e)
        {
            if (listeningSocket != null) return;
            try
            {
                localPort = (int)edLocalPort.Value;
                remotePort = (int)edRemotePort.Value;
                remoteEndPoint = new IPEndPoint(IPAddress.Parse(edRemoteAdress.Text),remotePort);

                listeningSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                listeningTask = Task.Run(this.SetListening);
                gbConnection.Enabled = false;
                gbSendMessages.Enabled = true;
            }
            catch 
            {
            
            }
        }
        private void SetListening() 
        {
            //получение сообщений

            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, localPort);
            listeningSocket.Bind(localEndPoint);
            StringBuilder builder= new StringBuilder();
            int len = 0;
            byte[] buffer = new byte[64];
            while (true)
            {
                EndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, remotePort); //ReceiveFrom не создает собственный, а заполняет по ссылке
                do
                {
                    len = listeningSocket.ReceiveFrom(buffer, ref remoteEndPoint);
                    builder.Append(Encoding.UTF8.GetString(buffer,0,len));
                } while (listeningSocket.Available > 0);

                IPEndPoint remoteIP = (IPEndPoint)remoteEndPoint;
                Action a = () =>
                {
                    lbMessages.Items.Insert(0, $"({DateTime.Now}){remoteIP.Address}:{remoteIP.Port} >> {builder}");
                };
                if (InvokeRequired)
                    Invoke(a);
                else
                    a();
                builder.Clear();
            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            //отправка сообщений

            if (listeningSocket == null || string.IsNullOrEmpty(edMessage.Text)) return;

            byte[] data = Encoding.UTF8.GetBytes(edMessage.Text);
            listeningSocket.SendTo(data, remoteEndPoint);
            lbMessages.Items.Insert(0, $"({DateTime.Now})me >> {edMessage.Text}");
            edMessage.Focus();
            edMessage.SelectAll();
        }
    }
}

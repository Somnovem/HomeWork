using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework2_1Client
{
    public partial class MainFormTCPClient : Form
    {
        public MainFormTCPClient()
        {
            InitializeComponent();
            this.ConnectionEstablished += ServerConnectionEstablished;
            this.ErrorEncountered += ProcessEncounteredError;
            this.MessageRaised += ServerResponse;
        }

        private void ServerResponse(string message)
        {
            lbMessages.Items.Insert(0,message);
        }

        private void ProcessEncounteredError(string errorMessage)
        {
            MessageBox.Show(errorMessage);
        }

        private void ServerConnectionEstablished()
        {
            lbMessages.Items.Insert(0, "Connection to the server establsihed!");
        }

        public event Action ConnectionEstablished;
        public event Action<string> MessageRaised;
        public event Action<string> ErrorEncountered;
        private Socket socket;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Parse(edRemoteAdress.Text), (int)edRemotePort.Value);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            bool couldConnect = false;
            try
            {
                socket.Connect(remoteEndPoint);
                ConnectionEstablished?.Invoke();
                couldConnect = true;
            }
            catch (Exception ex)
            {
                ErrorEncountered?.Invoke($"Encountered error: {ex.Message}");
            }
            if (!couldConnect) Environment.Exit(-1);
            gbConnection.Enabled = false;
            btnConnect.Enabled = false;
            gbSending.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (lbMessages.Items.Count != 0) lbMessages.Items.Clear();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            string message = edMessage.Text;
            byte[] data = Encoding.Unicode.GetBytes(message);
            socket.Send(data);
            MessageRaised?.Invoke($"({DateTime.Now.ToLongTimeString()})me >> {message}");
            MessageRaised?.Invoke("Waiting for a response...");

            // Moved the time-consuming operation to a separate thread
            string response = await Task.Run(() =>
            {
                StringBuilder stringBuilder = new StringBuilder();
                int len = 0;
                data = new byte[256];
                do
                {
                    len = socket.Receive(data);
                    stringBuilder.Append(Encoding.UTF8.GetString(data, 0, len));
                } while (socket.Available > 0);
                return stringBuilder.ToString();
            });

            MessageRaised?.Invoke($"({DateTime.Now.ToLongTimeString()})server >> {response}");
            btnSend.Enabled = true;
        }
    }
}

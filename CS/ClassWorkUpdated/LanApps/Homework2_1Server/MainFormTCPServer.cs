using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework2_1Server
{
    public partial class MainFormTCPServer : Form
    {
        public MainFormTCPServer()
        {
            InitializeComponent();

        }
        private MyServerAsync serverAsync;
        private void ServerAsync_ErrorEncountered(string errorMessage)
        {
            MessageBox.Show(errorMessage);
        }

        private void ServerAsync_MessageRaised(string message)
        {
            Action a = () =>
            {
                lbMessages.Items.Insert(0,message);
            };
            InvokeAction(a);
        }


        private void InvokeAction(Action action) 
        {
            if (InvokeRequired) Invoke(action);
            else action();
        }

        private void ServerAsync_ServerStarted()
        {
            MessageBox.Show("Server successfully started!");
        }
        

        private void btnStart_Click(object sender, EventArgs e)
        {
            serverAsync = new MyServerAsync(IPAddress.Any, 1000);
            serverAsync.ServerStarted += ServerAsync_ServerStarted;
            serverAsync.MessageRaised += ServerAsync_MessageRaised;
            serverAsync.ErrorEncountered += ServerAsync_ErrorEncountered;
            serverAsync.ResponseRequired += ServerAsync_ResponseRequired;
            serverAsync.StartServer();
            btnStart.Enabled = false;
            gbSending.Enabled = true;
        }

        private bool sendRequested = false;

        private void ServerAsync_ResponseRequired()
        {
            InvokeAction(() => { btnSend.Enabled = true; });
            while (true)
            {
                if (sendRequested)
                {
                    serverAsync.conn.Response = edMessage.Text;
                    sendRequested = false;
                    serverAsync.conn.ResponseAwaiter.Set();
                    break;
                }
            }
            InvokeAction(() => { btnSend.Enabled = false; });
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(lbMessages.Items.Count != 0)lbMessages.Items.Clear();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            sendRequested = true;
        }
    }
    internal class MyServerAsync
    {
        private int port;
        private IPAddress ip;
        public event Action ServerStarted;
        public event Action<string> MessageRaised;
        public event Action<string> ErrorEncountered;
        public event Action ResponseRequired;
        public ClientConnection conn;
        public MyServerAsync(IPAddress iPAddress, int port)
        {
            this.ip = iPAddress;
            this.port = port;
        }
        public Task StartServerAsync() => Task.Run(StartServer);
        public void StartServer()
        {
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint localEndPoint = new IPEndPoint(ip, port);
            try
            {
                server.Bind(localEndPoint);
                server.Listen(10);
                ServerStarted?.Invoke();
                server.BeginAccept(AcceptCallback, server);
            }
            catch (Exception ex)
            {
                ErrorEncountered?.Invoke("Encountered error: " + ex.Message);
            }

        }
        public void AcceptCallback(IAsyncResult result)
        {
            Socket server = result.AsyncState as Socket;
            if (server == null)
            {
                ErrorEncountered?.Invoke("Accepted not a socket");
                return;
            }
            Socket client = server.EndAccept(result);
            MessageRaised?.Invoke($"({DateTime.Now.ToLongTimeString()}) Accepted: {client.RemoteEndPoint}");
            conn = new ClientConnection(client);
            conn.StringMessage += ClientConnection_StringMessage;
            conn.ResponseRequired += Conn_ResponseRequired;
            conn.StartMessagingAsync();
            server.BeginAccept(AcceptCallback, server);
        }

        private void Conn_ResponseRequired()
        {
            ResponseRequired?.Invoke();
        }

        private void ClientConnection_StringMessage(string message)
        {
            MessageRaised?.Invoke(message);
        }
    }
}

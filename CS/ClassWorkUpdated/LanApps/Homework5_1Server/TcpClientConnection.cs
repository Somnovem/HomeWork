using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework5_1Server
{
    internal class TcpClientConnection
    {

        private TcpClient client;
        public IPEndPoint EndPoint { get; private set; }
        public string mode;
        private NetworkStream ns;
        public delegate void MessageDelegate(TcpClientConnection clientConnection, string message);
        public delegate void ServerResponseDelegate(string message);
        public delegate void ConnectionStateChangedDelegate(TcpClientConnection clientConnection, bool isConnected);

        public event MessageDelegate MessageText;
        public event ConnectionStateChangedDelegate ConnectionStateChanged;
        public event ServerResponseDelegate ServerResponse;


        public TcpClientConnection(TcpClient client)
        {
            if (client == null)
                throw new ArgumentNullException("client has to be initialized");
            this.client = client;
            EndPoint = client.Client.RemoteEndPoint as IPEndPoint;
            ConnectionStateChanged?.Invoke(this, true);
        }
        public async void StartMessaging()
        {
            ns = client.GetStream();
            string msg = await ReceiveString();
            ConnectionStateChanged?.Invoke(this, msg == "Player");
        }

        public Task StartMessagingAsync() => Task.Run(StartMessaging);

        public void Close()
        {
            client.Close();
        }

        public async Task SendString(string message)
        {
            try
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                await ns.WriteAsync(data, 0, data.Length);
            }
            catch (Exception)
            {
                 //Signal that server was closed
            }


        }

        public async Task<string> ReceiveString()
        {
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            byte[] data = new byte[256];
            try
            {
                bytes = await ns.ReadAsync(data, 0, data.Length);
                do
                {

                    builder.Append(Encoding.UTF8.GetString(data, 0, bytes));
                } while (ns.DataAvailable);

            }
            catch (Exception)
            {
                //Signal that server was closed
            }
            return builder.ToString();
        }
    }
}

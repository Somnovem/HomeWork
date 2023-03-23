using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace LanApp4_1TCPListener
{
    internal class TcpClientConnection
    {
        private static int clientConnectionCount = 0;
        private int clientId;
        public int ClientId { get => clientId; }
        private TcpClient client;
        public IPEndPoint Adress { get; private set; }



        public delegate void MessageDelegate(TcpClientConnection clientConnection, string message);
        public delegate void ConnectionStateChangedDelegate(TcpClientConnection clientConnection, bool isConnected);

        public event MessageDelegate MessageText;
        public event ConnectionStateChangedDelegate ConnectionStateChanged;


        public TcpClientConnection(TcpClient client)
        {
            if(client == null)
                throw new ArgumentNullException("client has to be initialized");
            this.client = client;
            clientId = ++clientConnectionCount;
            Adress = client.Client.RemoteEndPoint as IPEndPoint;
            ConnectionStateChanged?.Invoke(this, true);
        }
        public async void StartMessaging()
        {
            NetworkStream ns = client.GetStream();
            await SendString(ns, "Hello,User!");
            while (true)
            {
                string query = await ReceiveString(ns);
                MessageText?.Invoke(this, query);
                if (query.ToLower().Equals("exit"))
                {
                    await SendString(ns, "Goodbye!");
                    break;
                }

                await SendString(ns, "Your message was delivered");
            }
            client.Close();
            ConnectionStateChanged?.Invoke(this, false);
        }
        public Task StartMessagingAsync() => Task.Run(StartMessaging);

        private async Task SendString(NetworkStream stream, string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            await stream.WriteAsync(data, 0, data.Length);
        }

        private async Task<string> ReceiveString(NetworkStream stream)
        {
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            byte[] data = new byte[256];
            do
            {
                bytes = await stream.ReadAsync(data, 0, data.Length);
                builder.Append(Encoding.UTF8.GetString(data, 0, bytes));
            } while (stream.DataAvailable);
            return builder.ToString();
        }
    }
}

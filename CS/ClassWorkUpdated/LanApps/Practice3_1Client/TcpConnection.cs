using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice3_1Client
{
    internal class TcpConnection
    {
        private readonly TcpClient client;
        private IPAddress address;
        private int port;

        public delegate void ErrorEncounteredDelegate(string errorMessage);
        public event ErrorEncounteredDelegate ErrorEncountered;

        public TcpConnection(IPAddress address, int port)
        {
            client = new TcpClient();
            this.address = address;
            this.port = port;
        }

        public void Connect()
        {
            try
            {
                client.Connect(address, port);
            }
            catch (Exception ex)
            {
                ErrorEncountered?.Invoke($"Encountered error: {ex.Message}");
            }
        }

        public async void Disconnect()
        {
            try
            {
                await SendMessage("exit");
                Thread.Sleep(1000);
                client.Close();
            }
            catch (Exception ex)
            {
                ErrorEncountered?.Invoke($"Encountered error: {ex.Message}");
            }
        }

        public async Task<int> SendMessage(string message)
        {
            await SendString(client.GetStream(), message);
            return 0;
        }
        public async Task<string> ReceiveMessage()
        {
            return await ReceiveString(client.GetStream());
        }
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

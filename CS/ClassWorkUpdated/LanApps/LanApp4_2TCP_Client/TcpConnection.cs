using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace LanApp4_2TCP_Client
{
    internal class TcpConnection
    {
        private readonly TcpClient client;
        private IPAddress address;
        private int port;
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
                Console.WriteLine($"Encountered error: {ex.Message}");
            }
        }

        public void Disconnect()
        {
            try
            {
                SendMessage("exit");
                Thread.Sleep(1000);
                client.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Encountered error: {ex.Message}");
            }
        }

        public async void SendMessage(string message) 
        {
            await SendString(client.GetStream(), message);
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

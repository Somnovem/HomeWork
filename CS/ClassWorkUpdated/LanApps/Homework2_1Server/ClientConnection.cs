using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homework2_1Server
{
    internal class ClientConnection
    {
        private Socket client;
        public string Response;
        public ClientConnection(Socket client)
        {
            this.client = client;
        }
        public delegate void StringMessageDelegate(string message);
        public event StringMessageDelegate StringMessage;
        public ManualResetEvent ResponseAwaiter = new ManualResetEvent(false);
        public event Action ResponseRequired;
        public Task StartMessagingAsync() => Task.Run(StartMessaging);

        public void StartMessaging()
        {
            StringBuilder stringBuilder = new StringBuilder();
            int len = 0;
            byte[] buffer = null;
            try
            {
                while (true)
                {
                    buffer = new byte[256];
                    do
                    {
                        len = client.Receive(buffer);
                        stringBuilder.Append(Encoding.Unicode.GetString(buffer, 0, len));
                    } while (client.Available > 0);
                    string incomingMessage = stringBuilder.ToString();
                    StringMessage?.Invoke($"({DateTime.Now.ToLongTimeString()})From {client.RemoteEndPoint.ToString()} >> {incomingMessage}");
                    if ("exit".Equals(incomingMessage))
                    {
                        byte[] exitingData = Encoding.UTF8.GetBytes("Closing your connection!");
                        client.Send(exitingData);
                        client.Shutdown(SocketShutdown.Both);
                        client.Close();
                        break;
                    }
                    ResponseRequired?.Invoke();
                    ResponseAwaiter.WaitOne();
                    ResponseAwaiter.Reset();
                    StringMessage?.Invoke($"server >> {Response}");
                    byte[] answerData = Encoding.UTF8.GetBytes(Response);
                    client.Send(answerData);
                    stringBuilder.Clear();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Encountered error: " + ex.Message);
            }
        }
    }
}

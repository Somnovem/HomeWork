using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Practice1_1Server
{
    internal class Practice1_1Server
    {
        static void Main(string[] args)
        {
            #region Sync Main
            //MyServer server = new MyServer(IPAddress.Any, 1000);
            //Thread thread = new Thread(server.StartServer);
            //thread.IsBackground = true;
            //thread.Start();
            //thread.Join();
            #endregion
            #region Async Main
            MyServerAsync serverAsync = new MyServerAsync(IPAddress.Any, 1000);
            serverAsync.StartServer();
            while (true)
            {
                Thread.Sleep(5000); //wrong way to keep the thread alive
            }
            #endregion
        }
    }
    internal class MyServer
    {
        private int port;
        private IPAddress ip;
        private Socket server;
        public MyServer(IPAddress iPAddress, int port)
        {
            this.ip = iPAddress;
            this.port = port;
        }
        public Task StartServerAsync()
        {
            return Task.Run(StartServer);
        }
        public void StartServer()
        {
            if (server != null)
            {
                return;
            }

            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint localEndPoint = new IPEndPoint(ip, port);
            try
            {
                server.Bind(localEndPoint);
                server.Listen(10);
                Console.WriteLine("Server started and is ready for connections!");
                Socket client = server.Accept();
                StringBuilder stringBuilder = new StringBuilder();
                while (true)
                {
                    int len = 0;
                    byte[] buffer = new byte[256];
                    do
                    {
                        len = client.Receive(buffer);
                        stringBuilder.Append(Encoding.Unicode.GetString(buffer, 0, len));
                    } while (client.Available > 0);
                    string incomingMessage = stringBuilder.ToString();
                    Console.WriteLine($"({DateTime.Now.ToLongTimeString()})From {client.RemoteEndPoint.ToString()} >> {incomingMessage}");
                    if ("exit".Equals(incomingMessage))
                    {
                        byte[] exitingData = Encoding.UTF8.GetBytes("Closing your connection!");
                        client.Send(exitingData);
                        client.Shutdown(SocketShutdown.Both);
                        client.Close();
                        break;
                    }
                    Console.Write("Response message: ");
                    string answerText = Console.ReadLine();
                    byte[] answerData = Encoding.UTF8.GetBytes(answerText);
                    client.Send(answerData);
                    stringBuilder.Clear();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Encountered error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Server closed! Press ENTER to exit...");
                Console.ReadLine();
            }

        }
    }
    internal class MyServerAsync
    {
        private int port;
        private IPAddress ip;
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
                Console.WriteLine("Server started and is ready for connections!");
                server.BeginAccept(AcceptCallback, server);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Encountered error: " + ex.Message);
            }

        }
        public void AcceptCallback(IAsyncResult result)
        {
            Socket server = result.AsyncState as Socket;
            if (server == null)
            {
                Console.WriteLine("Accepted not a socket");
                return;
            }
            Socket client = server.EndAccept(result);
            Console.WriteLine($"({DateTime.Now.ToLongTimeString()}) Accepted: {client.RemoteEndPoint}");
            ClientConnection clientConnection = new ClientConnection(client);
            clientConnection.StartMessagingAsync();

            server.BeginAccept(AcceptCallback, server);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Net.Sockets;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using ConsoleCommand;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Homework1_1
{
    internal class ProgramServer
    {
        static void Main(string[] args)
        {
            Console.Title = "Information Server";
            MyServer server = new MyServer(IPAddress.Parse("127.0.0.1"), 1000);
            Thread thread = new Thread(server.StartServer);
            thread.IsBackground = true;
            thread.Start();
            Console.WriteLine("Press enter to stop the server");
            Console.ReadLine();
            thread.Abort();
        }
    }
    internal class MyServer
    {
        private int port;
        private IPAddress ip;
        public MyServer(IPAddress iPAddress, int port)
        {
            this.ip = iPAddress;
            this.port = port;
        }
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
            Console.WriteLine($"({DateTime.Now.ToLongTimeString()}) Accepted: {client.LocalEndPoint}");
            ClientConnection clientConnection = new ClientConnection(client);
            clientConnection.StartMessagingAsync();

            server.BeginAccept(AcceptCallback, server);
        }
    }
}







using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LanApp3_2AsyncTCPServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Test TCP server Async";
            MyServer server = new MyServer(IPAddress.Any, 1000); 
            server.StartServer();

            Console.WriteLine("Press enter to stop the server");
            Console.ReadLine();
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

            //создание сокета
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint localEndPoint = new IPEndPoint(ip, port);

            try
            {
                server.Bind(localEndPoint);

                server.Listen(10); 
                Console.WriteLine("Server started and is ready for connections!");
                //начать прием подключений
                server.BeginAccept(AcceptCallback,server); 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Encountered error: " + ex.Message);
            }

        }
        public void AcceptCallback(IAsyncResult result)
        {
            //завершаем прием подключения
            Socket server = result.AsyncState as Socket;
            if (server == null)
            {
                Console.WriteLine("Accepted not a socket");
                return;
            }
            Socket client = server.EndAccept(result);
            ClientConnection clientConnection = new ClientConnection(client);
            clientConnection.StartMessagingAsync();

            server.BeginAccept(AcceptCallback, server);//запустить следющюю обработку
        }
    }
}

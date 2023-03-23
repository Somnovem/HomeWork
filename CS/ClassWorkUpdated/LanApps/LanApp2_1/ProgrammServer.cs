using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics;
using System.Threading;

namespace LanApp2_1
{
    internal class ProgrammServer
    {
        static void Main(string[] args)
        {
            MyServer server = new MyServer(IPAddress.Any, 1000);
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

            string answerText = "Your message has been delivered";
            byte[] answerData = Encoding.UTF8.GetBytes(answerText);
            bool exitRequested = false;
            try
            {
                server.Bind(localEndPoint);

                server.Listen(10);
                Console.WriteLine("Server started and is ready for connections!");
                Socket client = server.Accept();
                Console.WriteLine($"Accepted: {client.RemoteEndPoint.ToString()}");
                StringBuilder stringBuilder = new StringBuilder();
                while (true)
                {
                    int len = 0;
                    byte[] buffer = new byte[256];
                    do
                    {
                       len = client.Receive(buffer);
                        stringBuilder.Append(Encoding.Unicode.GetString(buffer,0,len));//из байт массива делает строку, конкретно нашего пакета
                    } while (client.Available > 0); //если сообщение было мультипакетным, и естьь еще данные для чтения, читаем дальше
                    Console.WriteLine($"Incoming at ({DateTime.Now.ToLongTimeString()})>> {stringBuilder.ToString()}");
                    Console.ReadLine();

                    //отправка ответа клиенту
                    client.Send(answerData);
                    if (exitRequested)
                    {
                        client.Shutdown(SocketShutdown.Both);
                        client.Close();
                    }


                    stringBuilder.Clear();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Encountered error: " + ex.Message);
                throw;
            }
            
        }
    }
}

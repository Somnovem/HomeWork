using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace Practice1_1Client
{
    internal class Practice1_1Client
    {
        static void Main(string[] args)
        {
            Console.Write("Enter ip: ");
            IPAddress ip;
            if (IPAddress.TryParse(Console.ReadLine(), out ip))
            {
                Console.Write("Enter port: ");
                int port;
                if (int.TryParse(Console.ReadLine(), out port))
                {
                    IPEndPoint remoteEndPoint = new IPEndPoint(ip, port);
                    Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    try
                    {
                        socket.Connect(remoteEndPoint);
                        Console.WriteLine("Succefully established connection!");
                        while (true)
                        {
                            Console.Write("Enter message('exit' to close connection): ");
                            string message = Console.ReadLine();
                            byte[] data = Encoding.Unicode.GetBytes(message);
                            socket.Send(data);
                            Console.WriteLine("Waiting for response...");
                            StringBuilder stringBuilder = new StringBuilder();
                            int len = 0;
                            data = new byte[256]; 
                            do
                            {
                                len = socket.Receive(data);
                                stringBuilder.Append(Encoding.UTF8.GetString(data, 0, len));
                            } while (socket.Available > 0);
                            Console.WriteLine($"({DateTime.Now.ToLongTimeString()})From {socket.RemoteEndPoint.ToString()}>> {stringBuilder.ToString()}");
                            if ("exit".Equals(message)) break;
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Encountered error: {ex.Message}");
                    }
                }
            }
            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}

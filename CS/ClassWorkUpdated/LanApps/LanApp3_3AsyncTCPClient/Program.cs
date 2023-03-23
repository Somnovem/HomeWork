using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LanApp3_3AsyncTCPClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "TCP Client";
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
                        socket.Connect(remoteEndPoint); //подключение к хосту
                        while (true)
                        {
                            Console.Write("Enter message: ");
                            string message = Console.ReadLine();
                            byte[] data = Encoding.Unicode.GetBytes(message);
                            socket.Send(data);
                            StringBuilder stringBuilder = new StringBuilder();
                            int len = 0;//кол-во прочитанных байт
                            data = new byte[256]; //буфферный массив
                            do
                            {
                                len = socket.Receive(data);
                                stringBuilder.Append(Encoding.Unicode.GetString(data, 0, len));
                            } while (socket.Available > 0); 
                            Console.WriteLine($"Incoming at ({DateTime.Now.ToLongTimeString()})>> {stringBuilder}");
                            if ("exit".Equals(message))
                            {
                                break;
                            }
                        }
                        socket.Shutdown(SocketShutdown.Both);
                        socket.Close();

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

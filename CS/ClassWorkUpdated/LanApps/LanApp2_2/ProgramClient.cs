using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LanApp2_2
{
    internal class ProgramClient
    {
        static void Main(string[] args)
        {
            Console.Title = "TCP Client";
            Console.Write("Enter ip: ");
            IPAddress ip;
            if (IPAddress.TryParse(Console.ReadLine(),out ip))
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
                            stringBuilder.Append(Encoding.Unicode.GetString(data, 0, len));//из байт массива делает строку, конкретно нашего пакета
                        } while (socket.Available > 0); //если сообщение было мультипакетным, и естьь еще данные для чтения, читаем дальше
                        Console.WriteLine($"Incoming at ({DateTime.Now.ToLongTimeString()})>> {stringBuilder.ToString()}");
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

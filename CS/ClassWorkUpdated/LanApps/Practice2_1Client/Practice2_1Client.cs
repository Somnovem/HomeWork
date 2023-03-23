using ConsoleCommand;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Practice2_1Client
{
    internal class Practice2_1Client
    {
        static void Main(string[] args)
        {
            Console.Title = "Getting information from the server";
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
                        Console.WriteLine("Successfully connected to the server!");
                        byte[] data = null;
                        while (true)
                        {
                            Console.Write("Enter message(Type 'exit' to exit): ");
                            string message = Console.ReadLine();
                            if (string.IsNullOrEmpty(message)) continue;
                            string[] parameters = message.Split(' ').ToArray();
                            CommandType currentType = CommandType.date;
                            object content = null;
                            try
                            {
                                currentType = (CommandType)Enum.Parse(typeof(CommandType), parameters[0]);
                            }
                            catch (ArgumentException)
                            {
                                Console.WriteLine($"{message} is not a recognisable command");
                                continue;
                            }

                            switch (currentType)
                            {
                                case CommandType.date:
                                    break;
                                case CommandType.time:
                                    break;
                                case CommandType.datetime:
                                    break;
                                case CommandType.exec:
                                    content = parameters[1];
                                    break;
                                case CommandType.sort:
                                    List<int> arr = new List<int>();
                                    foreach (var item in parameters.Skip(1))
                                    {
                                        arr.Add(int.Parse(item));
                                    }
                                    content = arr;
                                    break;
                                case CommandType.numcurthreads:
                                    break;
                                case CommandType.cpuusage:
                                    break;
                                case CommandType.numcores:
                                    break;
                                case CommandType.help:
                                    break;
                                case CommandType.exit:
                                    break;
                                default:
                                    break;
                            }

                            var formatter = new BinaryFormatter();
                            var memoryStream = new MemoryStream();
                            formatter.Serialize(memoryStream, new Command(currentType, content));
                            var bytes = memoryStream.ToArray();

                            socket.Send(bytes);

                            StringBuilder stringBuilder = new StringBuilder();
                            int len = 0;
                            data = new byte[256];
                            do
                            {
                                len = socket.Receive(data);
                                stringBuilder.Append(Encoding.UTF8.GetString(data, 0, len));
                            } while (socket.Available > 0);
                            Console.WriteLine($"Incoming at ({DateTime.Now.ToLongTimeString()})>> {stringBuilder.ToString()}");
                            if (currentType == CommandType.exit) break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Encountered error: {ex.Message}");
                    }
                    finally
                    {
                        socket.Shutdown(SocketShutdown.Both);
                        socket.Close();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Port format!");
                }
            }
            else
            {
                Console.WriteLine("Invalid IP format!");
            }
            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}

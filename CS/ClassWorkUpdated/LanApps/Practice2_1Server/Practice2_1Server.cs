using ConsoleCommand;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice2_1Server
{
    internal class Practice2_1Server
    {
        
        static void Main(string[] args)
        {
            Console.Title = "Information Server";
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
        private Socket server  =null;
        private static Dictionary<CommandType, string> commandDescription;
        public MyServer(IPAddress iPAddress, int port)
        {
            this.ip = iPAddress;
            this.port = port;
            if (commandDescription == null) FillDescription();
        }
        private static void FillDescription()
        {
            commandDescription = new Dictionary<CommandType, string>();
            commandDescription.Add(CommandType.date, "Retrieves current date on the server");
            commandDescription.Add(CommandType.time, "Retrieves current time on the server");
            commandDescription.Add(CommandType.datetime, "Retrieves current date and time on the server");
            commandDescription.Add(CommandType.exec, "Executes file on provided path on the server");
            commandDescription.Add(CommandType.numcores, "Retrieves number of logical cores on the server");
            commandDescription.Add(CommandType.numcurthreads, "Retrieves number of running threads on the server");
            commandDescription.Add(CommandType.cpuusage, "Retrieves percent of CPU's resources used on the server");
            commandDescription.Add(CommandType.exit, "Closes this connection to the server");
        }
        public void StartServer()
        {
            if (server != null)
            {
                return;
            }
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint localEndPoint = new IPEndPoint(ip, port);
            byte[] answerData = null;
            byte[] buffer = null;
            List<byte> byteCommand = new List<byte>();
            string commandDocumentation = "";
            try
            {
                server.Bind(localEndPoint);
                server.Listen(10);
                Console.WriteLine("Server started and is ready for connections!");
                while (true)
                {
                    Socket client = server.Accept();
                    Console.WriteLine($"Accepted: {client.RemoteEndPoint.ToString()}");
                    bool exitRequested = false;
                    while (true)
                    {
                        buffer = new byte[256];
                        if (byteCommand.Count != 0) byteCommand.Clear();
                        do
                        {
                            client.Receive(buffer);
                            byteCommand.AddRange(buffer);
                        } while (client.Available > 0);
                        var formatter = new BinaryFormatter();
                        var memoryStream = new MemoryStream(byteCommand.ToArray());
                        var receivedCommand = formatter.Deserialize(memoryStream) as Command;
                        switch (receivedCommand.Type)
                        {
                            case CommandType.date:
                                answerData = Encoding.UTF8.GetBytes($"{DateTime.Now.ToShortDateString()}");
                                break;
                            case CommandType.time:
                                answerData = Encoding.UTF8.GetBytes($"{DateTime.Now.ToLongTimeString()}");
                                break;
                            case CommandType.datetime:
                                answerData = Encoding.UTF8.GetBytes($"{DateTime.Now}");
                                break;
                            case CommandType.exec:
                                string path = (string)receivedCommand.Content;
                                var p = new Process();
                                p.StartInfo = new ProcessStartInfo(path)
                                {
                                    UseShellExecute = true
                                };
                                bool processWasStarted = false;
                                try
                                {
                                    p.Start();
                                    processWasStarted = true;
                                }
                                catch (Exception)
                                {
                                    //opening the file failed
                                }
                                answerData = Encoding.UTF8.GetBytes($"Process was started:{processWasStarted}");
                                break;
                            case CommandType.sort:
                                List<int> nums = (List<int>)receivedCommand.Content;
                                nums.Sort();
                                string res = "";
                                foreach (int i in nums)
                                {
                                    res += $"{i} ";
                                }
                                answerData = Encoding.UTF8.GetBytes(res);
                                break;
                            case CommandType.numcurthreads:
                                answerData = Encoding.UTF8.GetBytes($"Number of running threads: {Process.GetCurrentProcess().Threads.Count}");
                                break;
                            case CommandType.cpuusage:
                                PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
                                float cpuUsage = cpuCounter.NextValue();
                                System.Threading.Thread.Sleep(1000);
                                cpuUsage = cpuCounter.NextValue();
                                answerData = Encoding.UTF8.GetBytes($"CPU usage: {cpuUsage} %");
                                break;
                            case CommandType.numcores:
                                answerData = Encoding.UTF8.GetBytes($"Number of logical cores: {Environment.ProcessorCount}");
                                break;
                            case CommandType.help:
                                if (string.IsNullOrEmpty(commandDocumentation))
                                {
                                    commandDocumentation = "\n\n";
                                    foreach (var item in commandDescription.Keys)
                                    {
                                        commandDocumentation += $"{item.ToString()} -> {commandDescription[item]}\n";
                                    }
                                }
                                answerData = Encoding.UTF8.GetBytes(commandDocumentation);
                                break;
                            case CommandType.exit:
                                answerData = Encoding.UTF8.GetBytes("Closed your connection!Bye!");
                                exitRequested = true;
                                break;
                            default:
                                break;
                        }

                        client.Send(answerData);

                        if (exitRequested)
                        {
                            Console.WriteLine($"Closed: {client.RemoteEndPoint.ToString()}");
                            client.Shutdown(SocketShutdown.Both);
                            client.Close();
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Encountered error: " + ex.Message);
            }
        }
    }
}

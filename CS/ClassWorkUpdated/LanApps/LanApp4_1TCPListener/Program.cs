using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace LanApp4_1TCPListener
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Test TCPListener";
            TCPServer server = new TCPServer(IPAddress.Any, 5000);
            server.StringMessage += Server_StringMessage;
            Task listeningTask = server.StartListenAsync();
            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }

        private static void Server_StringMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}

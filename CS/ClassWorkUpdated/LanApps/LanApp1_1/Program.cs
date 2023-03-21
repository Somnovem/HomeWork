using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace LanApp1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowAdressesByHostName("www.microsoft.com");
            Console.Write("\nEnter domain name: ");
            ShowAdressesByHostName(Console.ReadLine());
            Console.ReadLine();
        }
        private static void ShowAdressesByHostName(string hostName)
        {
            IPHostEntry host = Dns.GetHostEntry(hostName);
            foreach (IPAddress iPAddress in host.AddressList)
            {
                Console.WriteLine($"IP -> {iPAddress}");
            }
        }
    }
}

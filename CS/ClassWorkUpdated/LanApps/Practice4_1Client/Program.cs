using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Chatters;
namespace Practice4_1Client
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Choose types of messages you want to receive(separated by space if multiple):");
            Console.WriteLine("0-Advertisements");
            Console.WriteLine("1-Offers");
            Console.WriteLine("2-Announcements");
            Console.WriteLine("3-Files");
            Console.WriteLine("4-Images");
            Console.WriteLine("5-Standart");
            Console.Write("Choose: ");
            string[] types = Console.ReadLine().Split(' ');
            for (int i = 0; i < types.Length; i++)
            {
                int temp;
                if (types[i].Length == 1 && Int32.TryParse(types[i], out temp))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Invalid type!Press Enter to exit...");
                    Console.ReadLine();
                    return;
                }
            }
            BroadcastChatter chatter = new BroadcastChatter();
            chatter.MessageReceived += Chatter_MessageReceived;
            chatter.GotKicked += Chatter_GotKicked;
            Task.Run(() => chatter.Start("224.100.0.1", 8000, types));
            Console.WriteLine("Accepting messages(Press Enter to exit)...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }

        private static void Chatter_GotKicked()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Was kicked by the server");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void Chatter_MessageReceived(string message)
        {
            Console.WriteLine(message);
        }
    }
}

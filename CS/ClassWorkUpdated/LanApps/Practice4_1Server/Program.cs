using System;
using System.Net;
using Chatters;
namespace Practice4_1Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BroadcastChatter chatter = new BroadcastChatter();
            chatter.ErrorEncountered += Chatter_ErrorEncountered;
            chatter.Connect("224.100.0.1",8000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Rules:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter messages in format:'{Type}:{Data}'");
            Console.WriteLine("Types:\nAdvertisements\nOffers\nAnnouncements\nFiles\nImages\nStandarts\nEmergency\nKick(for message enter IP of the user to kick)\nExit");
            Console.WriteLine("///////////////////////////////////////////////////");
            Console.ForegroundColor = ConsoleColor.White;
            string[] settings;
            while (true)
            {
                Console.Write("Enter your message('exit' to exit):");
                string message = Console.ReadLine();
                if(string.IsNullOrEmpty(message))continue;
                settings = message.Split(':');
                if (settings[0].ToLower().Equals("exit")) Environment.Exit(0);
                else
                {
                    if (settings.Length != 2)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                    if (settings[0].Equals("Kick"))
                    {
                        IPAddress toKick;
                        if (!IPAddress.TryParse(settings[1], out toKick)) 
                        {
                            Console.WriteLine("Invalid IP format");
                            continue;
                        }
                        chatter.Send(settings[0], settings[1]);
                    }
                    else chatter.Send(settings[0], settings[1]);
                }
            }
        }

        private static void Chatter_ErrorEncountered(string message)
        {
            Console.WriteLine(message);
        }
    }
}

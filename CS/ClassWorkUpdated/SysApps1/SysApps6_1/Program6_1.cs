using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SysApps6_1
{
    internal class Program6_1
    {
        private static int finishedReaderCount;
        static void Main(string[] args)
        {
            Console.Title = "Test Semaphore";
            finishedReaderCount = 5;
            for (int i = 0; i < 5; i++)
            {
                Reader reader = new Reader(i+1);
                reader.ReaderMessage += Reader_ReaderChangeState;
                reader.ReadCompleted += Reader_ReadCompleted;
            }
        }

        private static void Reader_ReadCompleted(Reader sender)
        {
            Console.WriteLine($"{sender.ThreadName} - completed his reading");
            Interlocked.Decrement(ref finishedReaderCount);
            if (finishedReaderCount == 0)
            {
                var temp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\tAll readers completed their reading\n");
                Console.ForegroundColor = temp;
                Console.WriteLine("Press ENTER...");
                Console.ReadLine();
            }
        }

        private static void Reader_ReaderChangeState(Reader sender, string message)
        {
            Console.WriteLine($"{sender.ThreadName} - {message}");
        }
    }
}

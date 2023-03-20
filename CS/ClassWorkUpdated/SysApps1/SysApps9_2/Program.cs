using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SysApps9_2
{
    internal class Program
    {
        async static Task Main(string[] args)
        {
            await Console.Out.WriteLineAsync("Start Main");
            await PrintAsync("Forefathers, one and all!");
            await Console.Out.WriteLineAsync("End Main");
            Console.ReadLine();
        }
        private static void Print(string s) 
        {
            Thread.Sleep(2000);
            Console.WriteLine(s);
        }
        private static async Task PrintAsync(string s) 
        {
           Console.WriteLine("Start async print");
           await Task.Run(() => { Print(s); });
           Console.WriteLine("End async print");
        }
    }
}

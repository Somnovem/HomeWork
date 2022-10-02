using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{

    enum Direction {Up, Down, Left, Right }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "I love Minecraft";
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Clear();

            //foreach (var item in args)
            //{
            //    Console.WriteLine(item);   
            //}

            //String str = "abracadabra";
            //Console.WriteLine(str.GetTypeCode());
            //Console.WriteLine(str.PadLeft(15));
            //str += "dddd";

            //String test = "I love chocolate, and cookies! Mama mia!";
            //string[] s = test.Split(" ,.!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            //foreach (var item in s)
            //{
            //    Console.WriteLine(item);
            //}
            string[] names = Enum.GetNames(typeof(Direction));
            foreach (string name in names) Console.WriteLine(name);
            foreach (int val in Enum.GetValues(typeof(Direction))) Console.WriteLine(val);
            Console.ReadKey();
        }
    }
}

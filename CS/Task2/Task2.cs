using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Task2
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Number: ");
                int number = Int32.Parse(Console.ReadLine());
                Console.Write("Percent: ");
                int percent = Int32.Parse(Console.ReadLine());
                decimal result = (decimal)number * (decimal)percent / (decimal)100;
                Console.WriteLine(result);
                Console.ReadKey();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Clear();
                Console.Write("Degree: ");
                int degree = int.Parse(Console.ReadLine());
                Console.Write("Choose mode:\n 1 - From Farenheit to Celsius\n 2 - From Celsius to Farenheit\n");
                int mode = int.Parse(Console.ReadLine());
                if (mode == 1)
                {
                    Console.WriteLine("Result: " + (double)(degree - 32) * (double)0.55556);
                }
                else if (mode == 2)
                {
                    Console.WriteLine("Result: " + ((double)(degree *0.2 * 9) + 32));
                }
                Console.ReadKey();
            }
        }
    }
}

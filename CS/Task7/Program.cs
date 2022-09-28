using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("First number: ");
                int first = int.Parse(Console.ReadLine());
                Console.Write("Second number: ");
                int second = int.Parse(Console.ReadLine());
                if (second < first)
                {
                    int temp = first;
                    first = second;
                    second = temp;
                }
                Console.Write("Numbers in diapason: ");
                for (int i = first; i <= second; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.ReadKey();
            }
        }
    }
}

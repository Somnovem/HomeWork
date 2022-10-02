using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Tas4
    {
        public void Work(string[] args)
        {
            Console.Write("Number: ");
            string str = Console.ReadLine();
            Console.Write("First index: ");
            int first = int.Parse(Console.ReadLine());
            if (first < 1 || first > str.Length)
            {
               first = 1;
            }
            Console.Write("SSecond index: ");
            int second = int.Parse(Console.ReadLine());
            if (second < 1 || second > str.Length || second < first)
            {
                if (second < first)
                {
                    int temp = first;
                    first = second;
                    second = temp;
                }
                else
                {
                    second = str.Length - 1;
                }
               
            }
            int temp1 = str[first - 1] * (int)Math.Pow(10, str.Length - first);
            int temp2 = str[second - 1] * (int)Math.Pow(10, str.Length - second);
            int result = int.Parse(str) - temp1 - temp2;
            temp1 = str[first - 1] * (int)Math.Pow(10, str.Length - second);
            temp2 = str[second - 1] * (int)Math.Pow(10, str.Length - first);
            result += temp1 + temp2;
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

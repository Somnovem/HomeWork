using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Tas3
    {
        public void Work(string[] args)
        {
            int result = 0;
            int decimal_place = 1000;
            for (int i = 1; i < 5; i++)
            {
                Console.Write(i+": ");
                result += int.Parse(Console.ReadLine()) * decimal_place;
                decimal_place /= 10;
            }
            Console.Clear();
            Console.WriteLine(result);
        }
    }
}

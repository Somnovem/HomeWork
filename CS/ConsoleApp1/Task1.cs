using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task1
{
   
    class Tas1 
    {
       public void Work()
        {
            while (true) 
            {
                Console.Clear();
                Console.Write("Type in a number between 1 and 100: ");
                int number = int.Parse(Console.ReadLine());
                if (number < 1 || number > 100)
                {
                Console.WriteLine("Wrong number");
                    Console.ReadKey();
                    continue;
                }
                bool found = false;
                if (number % 3 == 0)
                {
                    Console.Write(" Fizz ");
                    found = true;
                }
                if (number % 5 == 0)
                {
                    Console.Write(" Buzz ");
                    found = true;
                }
                if (!found)
                {
                    Console.WriteLine(number);
                }
                Console.ReadKey();
            }
        }
    }
}

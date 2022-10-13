using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK8;
namespace ConsoleApp1
{
    internal class Controller
    {
        static void Main()
        {
            PriorityQueue<int,string> priorityQueue = new PriorityQueue<int,string>();
            priorityQueue.Add(1, "Deez");
            priorityQueue.Add(2, "NUTS");
            Console.WriteLine(priorityQueue.ElementAt(1));
            Console.WriteLine(priorityQueue.ElementAt(2));
        }
    }
}

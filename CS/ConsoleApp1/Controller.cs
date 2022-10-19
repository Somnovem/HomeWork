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
            Func<double, double, double, double> action = Delegates.TriangleArea;
            Console.WriteLine(action(3, 4, 5));
        }
    }
}

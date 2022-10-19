using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Delegates
    {
        
        static public void CurrentTime()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }
        static public void CurrentDate()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }
        static public void CurrentDayOfWeek()
        {
            Console.WriteLine(DateTime.Now.DayOfWeek);
        }
        static public double TriangleArea(double first, double second, double third) 
        {
            double halfPerimeter = (first + second + third) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - first) * (halfPerimeter - second) * (halfPerimeter - third));
        }
        static public double RectangleArea(double first, double second)
        {
            return first * second;
        }
    }
}

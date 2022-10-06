using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "I LOVE MINECRAFT";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WindowHeight = 35;
            Console.WindowWidth = 120;
            Console.Clear();

            Controller controller = new Controller();
            controller.Menu();
            Console.WriteLine();
            //Employee economist = new Economist(12,"Natasha","Romanoff",new DateTime(2000,6,5),24500,500000);
            //Employee specialist = new Specialist(12, "John", "Wick", new DateTime(1990, 8, 25), 400000, 9);
            //Employee cleanMaster = new CleaningManager(12, "Hitman", "47", new DateTime(2002, 3, 8), 350000, 5000);
            //Employee[] employees = { economist, specialist, cleanMaster };
            //foreach (Employee item in employees)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}

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
            Console.Title = "Console";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WindowHeight = 35;
            Console.WindowWidth = 120;
            Console.Clear();

            /////////////// 11.10.2022 /////////////////////////
            ///

            //IWorker employee = new CleaningManager(45,"Wasya","Smth",new DateTime(2000,6,30),15000,400);
            //employee.RunWorker();


            //ABC abc = new ABC();
            //abc.Print();
            //IA ia = new ABC();
            //ia.Print();
            //(abc as IB).Print();

            //Group group = new Group();
            //Console.WriteLine("Student list: ");
            //foreach (Student item in group)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine("---------------------------------");
            //}
            //group.Sort(new StudentCardComparer());
            //Console.WriteLine("/////////////////////////////////////////////////// ////////////////////////////////////////");
            //foreach (Student item in group)
            //{
            //    Console.WriteLine(item);
            //}

            StudentCard st1 = new StudentCard();
            StudentCard st2 = new StudentCard();
            st2 = (StudentCard)(st1.Clone());
        }
    }
}

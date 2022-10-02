using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Tas5
    {
       static string DateToSeason(DateTime dt)
        {
            switch (dt.Month)
            {
                case 1:
                case 2:
                case 12:return "Winter";
                    break;
                case 3:
                case 4:
                case 5:return "Spring";
                    break;
                case 6:
                case 7:
                case 8:return "Summer";
                    break;
                default:
                    return "Autumn";
                    break;
            }
        }
        public void Work(string[] args)
        {
            Console.Write("Date: ");
            DateTime dt =DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Day of week: " + dt.DayOfWeek);
            Console.WriteLine(DateToSeason(dt));
            Console.ReadKey();
        }
    }
}

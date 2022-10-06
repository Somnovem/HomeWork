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
            CreditCard.CreditCard card = new CreditCard.CreditCard("123456789123456", "Igor Lachenkov", new DateTime(2022, 5, 25), 745, (decimal)15000.0);
            card += 1500;
            Console.WriteLine(card);
            card++;
            Console.WriteLine(card);
            card--;
            Console.WriteLine(card["USD"]);
        }
    }
}

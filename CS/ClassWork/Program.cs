using System;
using System.Collections;
namespace ClassWork
{
    internal class Program
    {
        static void AddMark(Hashtable hs, string Name, int grade)
        {
            string[] names = Name.Split(' ');

            foreach (var item in hs.Keys)
            {
                Student temp = item as Student;
                if(temp.FirstName == names[0] && temp.LastName == names[1])
                {
                    (hs[item] as ArrayList).Add(grade);
                }
            }
        }

        static void PrintRaiting(Hashtable hs)
        {
            foreach (var item in hs.Keys)
            {
                Student temp1 = item as Student;
                Console.Write(temp1.FirstName + " " + temp1.LastName + " --- ");
                ArrayList grades = (hs[item] as ArrayList);
                foreach (var temp2 in grades)
                {
                    Console.Write($"{temp2}, ");
                }
                Console.WriteLine();
            } 
        }

        static void Main(string[] args)
        {
            Console.Title = "Console";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WindowHeight = 35;
            Console.WindowWidth = 120;
            Console.Clear();
            Hashtable rating = new Hashtable()
            {
                {
              new Student()
               {
                    FirstName = "Olga",
                    LastName = "Petrova",
                    Birthday = new DateTime(1996,5,14),
                    StudentCard = new StudentCard()
                    {
                        Series = "AC",
                        Number =123456
                    }
              },new ArrayList{10,11,10}
                },
                {
                    new Student()
                {
                    FirstName = "Geralt",
                    LastName = "ofRivia",
                    Birthday = new DateTime(1578,6,16),
                    StudentCard = new StudentCard()
                    {
                        Series = "AB",Number =123444
                    }
                 }, new ArrayList{8,10,9}
                }
            };
            PrintRaiting(rating);
            AddMark(rating, "Olga Petrova", 10);
            PrintRaiting(rating);
            AddMark(rating, "Geralt ofRivia", 6);
            PrintRaiting(rating);
        }
    }
}

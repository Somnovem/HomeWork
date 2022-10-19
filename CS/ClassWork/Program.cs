using System;
using System.Collections;
using System.Collections.Generic;
namespace ClassWork
{
    internal class Program
    {
        static T Max3<T>(T first,T second, T third) where T : IComparable
        {
            T firstBigger;
            if (first.CompareTo(second) <= 0)
            {
                firstBigger = second;
            }
            else
            {
                firstBigger= first;
            }
            if (third.CompareTo(firstBigger) <=0)
            {
                return firstBigger;
            }
            else
            {
                return third;
            }
        }

        static T Min<T>(T[] arr) where T : IComparable<T>
        {
            T min = arr[0];
            foreach (T item in arr)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }
            return min;
        }

        static void AddMark(Hashtable hs, string Name, int grade)
        {
            foreach (var item in hs.Keys)
            {
                Student temp = item as Student;
                if(temp.FirstName + temp.LastName == Name)
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

        public delegate int Ariphmetic(int t1,int t2);
        public delegate bool Method<T>(T t1, T t2);
        public delegate T GenericDelegate<T>(T t1, T t2);

        static bool SeriesAC(Student st)
        {
            return st.StudentCard.Series == "AC";
        }
        static int StudentComparison(Student st1, Student st2)
        {
            return st1.Birthday.CompareTo(st2.Birthday);
        }
        static void Sort(int[] arr, Method<int> m) 
        {
        
        }

        class Calc
        {
            public int Sum(int x,int y) => x + y;
            public int Diff(int x, int y) => x - y;
            static public int Mult(int x, int y) => x * y;
            public int Div(int x, int y) => x / y;
        }
        static void Main(string[] args)
        {
            Console.Title = "Console";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WindowHeight = 35;
            Console.WindowWidth = 120;
            Console.Clear();


            //Calc calc = new Calc();
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //char op = Convert.ToChar(Console.ReadLine());
            //Ariphmetic ariphmetic = null;
            //switch (op)
            //{
            //    case '+':
            //    ariphmetic =calc.Sum;
            //    break;
            //    case '-':
            //    ariphmetic = calc.Diff;
            //    break;
            //    case '*':
            //    ariphmetic = Calc.Mult;
            //    break;
            //    case '/':
            //    ariphmetic = calc.Div;
            //    break;
            //    default:
            //        break;
            //}
            //Console.WriteLine($"{a} {op} {b} = {ariphmetic(a,b)}");
            //Ariphmetic ariphmetic1 = calc.Sum;
            //ariphmetic += ariphmetic1;
            //ariphmetic += Calc.Mult;
            //foreach (Ariphmetic item in ariphmetic.GetInvocationList())
            //{
            //    Console.WriteLine(item(a, b));
            //}
            //GenericDelegate<int> div = calc.Div;



            //Group group = new Group();
            //foreach (Student item in group.Top3())
            //{
            //    Console.WriteLine(item);
            //}

            List<Student> students = new List<Student>()
{
            new Student()
            {
                FirstName = "Olga",
                LastName = "Petrova",
                Birthday = new DateTime(1996,5,14),
                StudentCard = new StudentCard()
                {
                    Series = "AC",Number =123456
                }
             },
            new Student()
            {
                FirstName = "Natasha",
                LastName = "Romanoff",
                Birthday = new DateTime(1998,7,2),
                StudentCard = new StudentCard()
                {
                    Series = "AB",Number =123466
                }
             },
            new Student()
            {
                FirstName = "Petro",
                LastName = "Oleksiiv",
                Birthday = new DateTime(2000,4,25),
                StudentCard = new StudentCard()
                {
                    Series = "AC",Number =123478
                }
             },
            new Student()
            {
                FirstName = "Geralt",
                LastName = "of Rivia",
                Birthday = new DateTime(1578,6,16),
                StudentCard = new StudentCard()
                {
                    Series = "AB",Number =123444
                }
             }
        };
            students.ForEach(FullNameStudent);
            Action<Hashtable> action = PrintRaiting;
            Func<int, int, int> func = Calc.Mult;
            Console.WriteLine(func(3,2));
            //var temp = students.Select(FullNameStudentString);
            //foreach (var item in temp)
            //{
            //    Console.WriteLine(item);
            //}
            List<Student> st2 = students.FindAll(SeriesAC);
            foreach (var item in st2)
            {
                Console.WriteLine(item);
            }
            students.Sort(StudentComparison);
            Console.WriteLine("------------------------");
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }
        static void FullNameStudent(Student st)
        {
            Console.WriteLine($"{st.FirstName}  {st.LastName}");
        }
        static string FullNameStudentString(Student st)
        {
            return $"{st.FirstName}  {st.LastName}";
        }
        
    }

    //class Point3D<T> where T: class, IComparable<T>,new()
    //{
    //    T x;
    //    T y;
    //    T z;
    //    public Point3D()
    //    {
    //        x = default(T);
    //        y = default(T);
    //        z = default(T);
    //    }
    //}
}

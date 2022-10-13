using System;
namespace ClassWork
{
    internal class Program
    {
        //static void f1()
        //{

        //}
        //static void f2()
        //{
        //    f1();
        //}
        //static void f3()
        //{
        //    try
        //    {
        //        f2();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //        Console.WriteLine(e.StackTrace);
        //        Console.WriteLine(e.InnerException);
        //        Console.WriteLine(e.TargetSite);
        //    }
        //}
        //static void f4(string param)
        //{
        //    if (param == null)
        //    {
        //        throw new ArgumentNullException(nameof(param));
        //    }
        //}
        //static int div(int n1, int n2)
        //{
        //    int res = 0;
        //    try
        //    {
        //        res = n1 / n2;
        //    }
        //    catch (DivideByZeroException)
        //    {
        //        throw;
        //    }
        //    return res;
        //}
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

            //StudentCard st1 = new StudentCard();
            //StudentCard st2 = new StudentCard();
            //st2 = (StudentCard)(st1.Clone());

            /////////////////////////12.10.2022///////////////////////////////



            //Console.WriteLine(GC.MaxGeneration);
            using (ClassWork.GarbageGenereation gg = new ClassWork.GarbageGenereation())
            {
                gg.MakeGarbage();
            }
            //Console.WriteLine(GC.GetGeneration(gg));
            //Console.WriteLine(GC.GetTotalMemory(false));
            //gg.MakeGarbage();
            //Console.WriteLine(GC.GetGeneration(gg));
            //Console.WriteLine(GC.GetTotalMemory(false));
            //GC.Collect(0);
            //Console.WriteLine(GC.GetGeneration(gg));
            //Console.WriteLine(GC.GetTotalMemory(false));
            //GC.Collect();
            //gg.MakeGarbage();
            //Console.WriteLine(GC.GetGeneration(gg));
            //Console.WriteLine(GC.GetTotalMemory(false));
            //GC.Collect();
            //Console.WriteLine(GC.GetGeneration(gg));
            //Console.WriteLine(GC.GetTotalMemory(false));

            //byte b = 100;

            //try
            //{
            //    checked // or use Project->Properties->Check Arythmetic Overflow to use this in the entirety of the project
            //    {
            //        Console.WriteLine(b+250);
            //    }
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine(e.Message);
            //}
            //try
            //{
            //    f4(null);
            //    //int n1 = Convert.ToInt32(Console.ReadLine());
            //    //int n2 = Convert.ToInt32(Console.ReadLine());
            //    //int res = div(n1, n2);
            //    //Console.WriteLine(res);
            //}
            //catch (Exception e) /*when (e.InnerException != null)*/
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e.StackTrace);
            //    Console.WriteLine(e.InnerException);
            //    Console.WriteLine(e.TargetSite.Name);
            //}


        }
    }
}

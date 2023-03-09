using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice0803
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Multithreaded";
            #region Task1
            mutex1 = new Mutex(false, "mutexAscending");
            Console.WriteLine("Generated numbers");
            Thread threadAsc = new Thread(NumsAscending);
            Thread threadDesc = new Thread(NumsDescending);
            threadAsc.Start();
            threadDesc.Start();

            Mutex final;
            while (!Mutex.TryOpenExisting("mutexDescending", out final))
            {
                Thread.Sleep(1000);
            }
            final.WaitOne();
            Console.WriteLine("Press ENTER...");
            Console.ReadLine();
            final.ReleaseMutex();
            #endregion
            #region Task2
            //list = new List<int>();
            //mutexFill = new Mutex(false, "mutexFillArray");
            //mutexIncrease = new Mutex(false, "mutexIncreaseArray");
            //Thread threadFill = new Thread(FillAraay);
            //Thread threadIncrease = new Thread(IncreaseArray);
            //Thread threadMax = new Thread(FindMax);

            //threadFill.Start();
            //threadIncrease.Start();
            //threadMax.Start();
            //Console.WriteLine("Starting the process...");
            //Mutex mut;
            //while (!Mutex.TryOpenExisting("mutexFindMax",out mut))
            //{
            //    Thread.Sleep(1000);
            //}
            //mut.WaitOne();
            //Console.WriteLine("Array:");
            //Console.WriteLine("-------------------------------------");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine($"Max: {max}");
            //Console.WriteLine("Press ENTER...");
            //Console.ReadLine();
            //mut.ReleaseMutex();
            #endregion
        }
        #region Task1 Logic
        private static Mutex mutex1;
        private static void NumsAscending()
        {
            mutex1.WaitOne();
            for (int i = 0; i < 21; i++)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine("-------------------------------------------------------------");
            mutex1.ReleaseMutex();
        }
        private static void NumsDescending()
        {
            Mutex mutexDescending = new Mutex(false, "mutexDescending");
            mutexDescending.WaitOne();
                Mutex mut;
                while (!Mutex.TryOpenExisting("mutexAscending", out mut))
                {
                    Thread.Sleep(1000);
                }
                mut.WaitOne();
                for (int i = 10; i >= 0; i--)
                {
                    Console.WriteLine(i.ToString());
                }
                mut.ReleaseMutex();
            mutexDescending.ReleaseMutex();
        }
        #endregion

        #region Task2 Logic
        //private static Mutex mutexFill;
        //private static Mutex mutexIncrease;
        //private static List<int> list;
        //private static int max;
        //private static void FillAraay()
        //{
        //    mutexFill.WaitOne();
        //    Random rnd = new Random();
        //    for (int i = 0; i < rnd.Next(10,101); i++)
        //    {
        //        list.Add(rnd.Next(0, 501));
        //    }
        //    mutexFill.ReleaseMutex();
        //}
        //private static void IncreaseArray() 
        //{
        //    mutexIncrease.WaitOne();
        //    Mutex mut;
        //    while (!Mutex.TryOpenExisting("mutexFillArray",out mut))
        //    {
        //        Thread.Sleep(1000);
        //    }
        //    mut.WaitOne();
        //    int ampl = new Random().Next(1, 11);
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        list[i] += ampl;
        //    }
        //    mutexIncrease.ReleaseMutex();
        //    mut.ReleaseMutex();
        //}
        //private static void FindMax()
        //{
        //    Mutex mutexFindMax = new Mutex(false,"mutexFindMax");
        //        mutexFindMax.WaitOne();
        //        Mutex mut;
        //        while (!Mutex.TryOpenExisting("mutexIncreaseArray", out mut))
        //        {
        //            Thread.Sleep(1000);
        //        }
        //        mut.WaitOne();
        //        max = list.Max();
        //        mut.ReleaseMutex();
        //    mutexFindMax.ReleaseMutex();
        //}
        #endregion
    }
}

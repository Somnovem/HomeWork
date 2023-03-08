using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;

namespace SysApps4_1Pool
{
    internal class Program4_1
    {
        static void Main(string[] args)
        {
            Console.Title = "Test ThreadPool";

            #region Test 1
            //вывод инфы про пул
            //ThreadPoolInfo();




            //Console.WriteLine($"Start Main({Thread.CurrentThread.ManagedThreadId}) working");


            ////симуляция роботы на потоке
            ////ThreadPool.QueueUserWorkItem(CalculateUsingThreadPool);//все потоки в пуле - ФОНОВЫЕ

            ////рандомное количество потоков для запуска
            //Random random = new Random();
            //int nMax = random.Next(5, 21),n;
            //Console.WriteLine($"Threads count = {nMax}");
            //for (int i = 0; i < nMax; i--)
            //{
            //    n = random.Next(5, 11);
            //    ThreadPool.QueueUserWorkItem(CalculateUsingThreadPool,n);
            //}


            //Thread.Sleep(1000);
            //Console.WriteLine($"End Main({Thread.CurrentThread.ManagedThreadId}) working");



            ////повторный вывод
            //ThreadPoolInfo();

            #endregion
            #region Sync Delegates
            //Console.WriteLine("Sync call display");
            //DisplayDelegate display = new DisplayDelegate(Display);
            //int res = display.Invoke();
            //Console.WriteLine($"Result = {res}");
            //Console.WriteLine("End main");
            #endregion
            #region Async Delegates
            //Console.WriteLine("Aysnc call display");
            //DisplayDelegate display = new DisplayDelegate(Display);
            //var asyncResult = display.BeginInvoke(null,null);
            //Console.WriteLine("Continue main");
            //int res = display.EndInvoke(asyncResult);
            //Console.WriteLine($"Result = {res}");
            //Console.WriteLine("End main");
            #endregion

            #region Async Delegates with Params
            //Console.WriteLine("Async call CalculateSum");
            ////если ретурн воид то используем action
            //Func<int,int,int> calc = new Func<int,int,int>(CalculateSum);
            //var asyncResult = calc.BeginInvoke(7,10,null, null);
            //Console.WriteLine("Continue main");
            //int res = calc.EndInvoke(asyncResult);
            //Console.WriteLine($"Result = {res}");
            //Console.WriteLine("End main");
            #endregion

            #region Async Delegates with Params and Callback
            Console.WriteLine("Async call CalculateSum");
            Func<int, int, int> calc = new Func<int, int, int>(CalculateSum);
            var asyncResult = calc.BeginInvoke(17, 10, AsyncCallbackCalculate, calc);
            Console.WriteLine("Continue main");
            Thread.Sleep(1000);
            Console.WriteLine("End main");
            #endregion
            Console.ReadKey();
        }

        private static void ThreadPoolInfo()
        {
            int Worker, Completion; // worker - работающие по 25 на процессор
                                    // compleyeion - ввода\вывода 1000 всего

            ThreadPool.GetMaxThreads(out Worker, out Completion);
            Console.WriteLine($"Maximum: Working = {Completion}, Completion = {Completion}");
            ThreadPool.GetMinThreads(out Worker, out Completion);
            Console.WriteLine($"Minimum: Working = {Worker}, Completion = {Completion}");
            ThreadPool.GetAvailableThreads(out Worker, out Completion);
            Console.WriteLine($"Avalaible: Working = {Worker}, Completion = {Completion}");
            //ThreadPool.SetMaxThreads(100, 100);
            //ThreadPool.GetMaxThreads(out Worker, out Completion);
            //Console.WriteLine($"Maximum: Working = {Worker}, Completion = {Completion}");
        }

        private static void CalculateUsingThreadPool(object state)//стейт нужен чтобы пул работал
        {
            int num;
            try
            {
                num = (int)state;
            }
            catch 
            {
                num = 5;
            }
            Console.WriteLine($"\t\t Start another thread,num = {num}, id = {Thread.CurrentThread.ManagedThreadId}");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"\t\t Work another thread, id = {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(100);
            }
            Console.WriteLine($"\t\t Stop another thread, id = {Thread.CurrentThread.ManagedThreadId}");
        }

        private static int CalculateSum(int count,int start)//стейт нужен чтобы пул работал
        {
            Console.WriteLine($"\t\t Start another thread,num = {count}, id = {Thread.CurrentThread.ManagedThreadId}");
            int s = start;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\t\t Work another thread, id = {Thread.CurrentThread.ManagedThreadId}");
                start += i * 5;
                Thread.Sleep(50);
            }
            Thread.Sleep(1000);
            Console.WriteLine($"\t\t Stop another thread, id = {Thread.CurrentThread.ManagedThreadId}");
            return s;
        }

        public delegate int CaclculateSumDelegate(int count, int start);
        private static void AsyncCallbackCalculate(IAsyncResult asyncResult)
        {
            CaclculateSumDelegate calc = asyncResult.AsyncState as CaclculateSumDelegate;
            int res = calc.EndInvoke(asyncResult);
            Console.WriteLine($"Result callback = {res}");
        }

        public delegate int DisplayDelegate();
        private static int Display()
        {
            Console.WriteLine();
            int s = 0;
            Random random = new Random();
            for (int i = 0; i < random.Next(20,41); i++)
            {
                s += i * 10;
            }
            Thread.Sleep(2000);
            return s;
        }
    }
}

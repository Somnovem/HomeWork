using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace SysApp5_1
{
    internal class Program
    {
        private static object lockObject = new object();
        private static Mutex mutex;//определяем мьтекс
        private static Mutex extMutex;
        static void Main(string[] args)
        {
            Console.Title = "Sync test";
            string assemblyName = Marshal.GetTypeLibGuidForAssembly(Assembly.GetExecutingAssembly()).ToString();
            bool created;
            extMutex = new Mutex(true, assemblyName,out created);//тестовый мьютекс для теста мультипроцесного взаимодействия
            if (created)
            { Console.WriteLine("First instance of application"); }
            else
            {
                Console.WriteLine("Such application is/was already running!");
                Console.WriteLine("Press Any Key to exit");
                Console.ReadKey();
                return;
            }
            Counter.value = 0;

        }

        private void TestThreads() 
        {
            //иницализация мьютекса
            mutex = new Mutex();//если поставить true то он будет уже заблокированным, что может результировать в дедлок, если не освободить его в нужный нам момент
            Thread[] threads = new Thread[5];
            Console.WriteLine("Create and start threads...");
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(CounterIncrementMutex);
                threads[i].Start();
            }
            Console.WriteLine("Waiting for threads...");
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Join();
            }
            Console.WriteLine($"All threads finished, Value = {Counter.value}");
            Console.WriteLine("Press ENTER...");
            Console.ReadLine();
        }

        private static void CounterIncrement()
        {
            //lock (this)//this используеться если нужно залочить весь обьект, поэтому нужно использовать статический обьект синхронизации
            //{

            //}
            lock (lockObject)//теперь мы достигли синхронизации, говоря каждому следующему потоку ждать когда закончиться прошлый
            {
                Console.WriteLine($"Current thread: {Thread.CurrentThread.ManagedThreadId}");
                for (int i = 0; i < 1000000; i++)
                {
                    Counter.value++;
                }
            }

        }

        private static void CounterIncrementMonitor()
        {
            //монитор инициал при первом обращении
            //блокируем ресурс, если он доступен(никем не занят)
            try
            {
                Monitor.Enter(lockObject);//теперь мы достигли синхронизации, говоря каждому следующему потоку ждать когда закончиться прошлый
                Console.WriteLine($"Current thread: {Thread.CurrentThread.ManagedThreadId}");
                for (int i = 0; i < 1000000; i++)
                {
                    Counter.value++;
                    Thread.Sleep(1000);
                    //return; || throw new Exception("Test);   //создаст дедлок, так как мы не разблокируем ресурс
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Monitor.Exit(lockObject); //обернув код в tryf, мы превентим дедлок, так как неважно какой код раниться в try, мы все равно зайдем в finally
            }


            //освободить ресурс для следующих потоков
        }

        private static void CounterIncrementInterlocked()//интерлокед используеться для атомарных операций, почти что не блокируя ресурс, тоесть для операций одной строкой
        {
          Console.WriteLine($"Current thread: {Thread.CurrentThread.ManagedThreadId}");
          for (int i = 0; i < 1000000; i++)
          {                                              //в цикле использовать - плохая идея, так как каждый вызов требует проверки синхронизации   
              Interlocked.Increment(ref  Counter.value); //еще и возвращает новоустановленное значение
           }
        }


        private static void CounterIncrementMutex()//интерлокед используеться для атомарных операций, почти что не блокируя ресурс
        {
            mutex.WaitOne();//следующая секция кода будет блокирована на 1 поток || перевести его в "несигнальное" состояние
            try
            {
                Console.WriteLine($"Current thread: {Thread.CurrentThread.ManagedThreadId}");
                for (int i = 0; i < 1000000; i++)
                {                                              //в цикле использовать - плохая идея, так как каждый вызов требует проверки синхронизации   
                    Counter.value++; //еще и возвращает новоустановленное значение
                }
            }
            finally
            {
                mutex.ReleaseMutex();//освободить мьютекс для следующих потоков || перевести его в "сигнальное" состояние
            }
            //так как мьютекс системный, то он немного медленее за все остальное
        }
    }
    internal class Counter
    {
        public static int value;
    }
}

//лок или монитор делают секцию кода эксклюзивной для потока, после завершения которого секция вновь освождаеться
//если потоку для роботы нужна эта секция, то он ожидает освобождения и занимает место
//ресурс который используеться больше че 1 потоком - ресурс общего пользования


//"Race condition возникает, когда два или более потока могут получить доступ к общим данным и одновременно попытаться их изменить.
//Поскольку алгоритм планирования потоков может переключаться между потоками в любое время, вы не знаете порядок, в котором
//потоки будут пытаться получить доступ к общим данным. Таким образом, результат изменения данных зависит от
//алгоритма планирования потоков, т. е. оба потока «соревнуются» в доступе/изменении данных."

//монитор - тоже средство для достижения синхронизации

//deadlock - ресурс был заблокирован и не может быть разблокирован(Enter был указан, ресурс был заблокирован, но Exit указан не был, а значит ресурс не будет разблокирован)

//лок и монитор нужны для работы в одном приложении, и ним же и контролируються

//мютексы, семафоры и обьекты синхронизации - все направлены на синронизацию и межпроцесное взаимодействие

//мьютекс - системный способ достижения синхронизации, котролируеться системой, междупроцесный синглтон
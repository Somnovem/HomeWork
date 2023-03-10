using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


//исследование событий сихронизаций с ручным и автоматическым вбросом
namespace SysApps6_2
{
    internal class Program6_2
    {
        internal class Counter
        {
            public static int value;
        }
        private static ManualResetEvent mre;//обьект сихронизации с ручным вбросом
        private static AutoResetEvent are;//обьект сихронизации с ручным вбросом

        static void Main(string[] args)
        {
            AutomaticTest();
            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
        private static void ManualTest()
        {
            mre = new ManualResetEvent(true);//бул - изначальное состояние(поидеи включен или нет)
            Thread[] threads = new Thread[5];
            for (int i = 0; i < 5; i++)
            {
                threads[i] = new Thread(CounterIncrementManual);
                threads[i].Name = $"Counter {i}";
                threads[i].Start();
            }
            Thread.Sleep(5000);
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Join();
            }
            Console.WriteLine($"Value = {Counter.value}");
        }
        private static void AutomaticTest()
        {
            are = new AutoResetEvent(true);
            Thread[] threads = new Thread[5];
            for (int i = 0; i < 5; i++)
            {
                threads[i] = new Thread(CounterIncrementAutomatic);
                threads[i].Name = $"Counter {i}";
                threads[i].Start();
            }
            Thread.Sleep(5000);
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Join();
            }
            Console.WriteLine($"Value = {Counter.value}");
        }
        private static void CounterIncrementManual()
        {
            
            mre.WaitOne();//ожиаем освобождения
            mre.Reset();//блокируем ресурс --конкретно почему он ручной, ждать и блокировать теперь разные методы, и блокировка проходит полностью вручную
            Console.WriteLine($"Current thread: {Thread.CurrentThread.ManagedThreadId}");
            for (int i = 0; i < 1000000; i++)
            {
                Counter.value++;
            }
            mre.Set();//разблокируем ресурс
        }
        private static void CounterIncrementAutomatic()
        {
            are.WaitOne();//ожиаем освобождения
            Console.WriteLine($"Current thread: {Thread.CurrentThread.ManagedThreadId}");
            for (int i = 0; i < 1000000; i++)
            {
                Counter.value++;
            }
            are.Set();//разблокируем ресурс
        }
    }
}

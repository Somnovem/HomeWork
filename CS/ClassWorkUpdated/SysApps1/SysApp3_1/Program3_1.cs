using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SysApp3_1
{
    internal class Program3_1
    {
        static void Main(string[] args)
        {
            //Thread thread = new Thread(new ThreadStart(Calculate)); - полная версия(все равно будет вызвана)
            CalculateFunction();
            Console.WriteLine("Main End");
        }
        private static void TestThread1()
        {
            Thread calculateThread = new Thread(Calculate);
            calculateThread.IsBackground = true;
            calculateThread.Start();
            Console.WriteLine("TestThread1 working - start");
            Thread currentThread = Thread.CurrentThread;
            //currentThread.Suspend(); //заморозить поток
            //currentThread.Resume(); //отморозить поток
            //currentThread.Abort(); //прервать поток
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"\n{i}.Main thread");
                Thread.Sleep(100);
                if (i == 3)
                {
                    calculateThread.Suspend();
                    Console.WriteLine("SUSpended");
                }
                if (i == 7) 
                {
                    calculateThread.Resume();
                    Console.WriteLine("RESumed");
                }
            }
            Console.WriteLine("\nWait Calculate thread");
            calculateThread.Join();
            Console.WriteLine("TestThread end!");
        }
        private static void Calculate() 
        {
            Console.WriteLine("\n\tCalculate thread - start");
            int a = 1, b = 1, x;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"\t\t{i}. {a + b} (Calculate thread)");
                Thread.Sleep(500);
                x = a;
                a = b;
                b = x + a;
            }
            Console.WriteLine("\n\tCalculate thread - end");
        }
        private static void TestThreadFactorial()
        {
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());
            //Thread factorial = new Thread(new ParameterizedThreadStart( CalculateFactorial)); --так же полная версия
            Thread factorial = new Thread(CalculateFactorial);
            factorial.Start(n);
            Console.WriteLine("\n Wait CalculateFactorial...");
            factorial.Join();
            Console.WriteLine("\n CalculateFactorial End! Press Enter...");
            Console.ReadKey();
        }
        private static void CalculateFactorial(object value)
        {
            Console.WriteLine("\n\tCalculateFactorial thread - start");
            int a = 1, n;
            n = (int)value;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\t\t{i}. (CalculateFactorial thread) = {a}");
                a *= (i+1);
                Thread.Sleep(500);
            }
            Console.WriteLine("\n\tCalculateFactorial thread - end");
        }
        private static void CalculateFunction() 
        {
            Console.Write("Enter first value = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second value = ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Enter count = ");
            uint count = uint.Parse(Console.ReadLine());
            FunctionCalc func = new FunctionCalc() { StartX1 = x1, StartX2 = x2, Count = count};
            func.StartCalculation += Func_StartCalculation;
            func.EndCalculation += Func_EndCalculation;
            //func.CalculationEvent += Func_CalculationEvent;
            Thread thread = new Thread(func.Calculate);
            thread.Start();
            Console.WriteLine("\nJoined - waiting...");
            thread.Join();
            Console.WriteLine("\nThread exited");

            Console.WriteLine("\nTPress ENTER...");
            Console.ReadKey();
        }

        //private static void Func_CalculationEvent(FunctionCalc func, string msg)
        //{
        //    Console.WriteLine($"\n\t{msg}");
        //}

        private static void Func_EndCalculation(FunctionCalc func, string msg)
        {
            Console.WriteLine($"\n\t{msg}");
            for (int i = 0; i < func.Y.Count; i++)
            {
                Console.WriteLine($"Y{i} = {func.Y[i]}");
            }
        }

        private static void Func_StartCalculation(FunctionCalc func, string msg)
        {
            Console.WriteLine($"\n\t{msg}");
        }
    }
}

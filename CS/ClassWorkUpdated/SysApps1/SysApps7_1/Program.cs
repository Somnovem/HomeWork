using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SysApps7_1
{
    internal class Program
    {
        private static Random rng = new Random(1000);
        static void Main(string[] args)
        {
            Console.Title = "Test Tasks";
            //TestTasks7_Cancel();
            //Task.WaitAll();
            

            //как работает цикл фор
            Parallel.For(1, 10, FactorialParallel);

            //как работает цикл форич
            ParallelLoopResult result = new Parallel.ForEach<int>(new List<int>() { 1, 3, 5, 8 }, FactorialParallel);
            Console.WriteLine("Press ENTER...");
            Console.ReadLine();
        }
        private static void TestTasks1()
        {
            Task task = new Task(CalcSum); //the simplest creation of a task
            //Task task = Task.Run(CalcSum); // дает нам обьект уже с этим кодом, но уже запущенный
            //Task task = Task.Factory.StartNew(CalcSum); //создание через фабрику

            //Разные виды создания дают свой функционал и возможности создания обьектов

            task.Start();
            Console.WriteLine("\n Main Continue...");
            int sum = rng.Next(10, 101);
            for (int i = 0; i < 10; i++)
            {
                sum += i;
                Thread.Sleep(100);//simulate hard work
            }
            Console.WriteLine("Wait other task");
            task.Wait();//ждать таск который запустил этот обьект, также есть много конструкторов на условия
            Console.WriteLine($"\n Main End -> {sum}");
        }
        private static void CalcSum()
        {
            Console.WriteLine($"Start TaskId = {Thread.CurrentThread.ManagedThreadId}");
            int sum = rng.Next(10, 101);
            for (int i = 0; i < 10; i++)
            {
                sum += i;
                Thread.Sleep(100);//simulate hard work
            }
            Console.WriteLine($"Stop TaskId = {Thread.CurrentThread.ManagedThreadId}, Sum = {sum}");
        }

        private static void TestTasks2()
        {
            Console.WriteLine("Create array of tasks");
            //запуск паралельных задач
            Task[] tasks = new Task[5];
            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = Task.Run(CalcSum);
            }
            Console.WriteLine("\n Main Continue...");
            int sum = rng.Next(10, 101);
            for (int i = 0; i < 10; i++)
            {
                sum += i;
                Thread.Sleep(100);//simulate hard work
            }
            Console.WriteLine("Wait other task");
            Task.WaitAll(tasks);//статик метод, который ждет всез в массиве, есть WaitAny чтобы ждать любого первого
            Console.WriteLine($"\n Main End -> {sum}");
        }
        private static void TestTasks3() 
        {
            do
            {
                Console.Write("Enter number (<=0 to exit)= ");
                int n = int.Parse(Console.ReadLine());
                if (n <= 0) return;
                Task<int> task = new Task<int>(() => Factorial(n));
                task.Start();
                Task.Run(() =>
                {
                    Console.WriteLine("Calculating...");
                    Console.WriteLine($"{n}! = {task.Result}");
                });
            } while (true);
        }
        private static int Factorial(int x)
        {
            Thread.Sleep(100);
            if (x == 1) return 1;
            else return x * Factorial(x - 1);
        }
        private static void FactorialParallel(int x)
        {
            int result = 1;
            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            Thread.Sleep(100);
            if (x == 1) Console.WriteLine(1);
            else Console.WriteLine($"{result}"); ;
        }
        private static void TestTasks4_Continue()
        {
            List<int> list = new List<int>();
            Task task1 = new Task(() =>
            {
                Console.WriteLine($"TaskId {Task.CurrentId}.Start generating");
                for (int i = 0; i < 20; i++)
                {
                    list.Add(rng.Next(100,1001));
                    Thread.Sleep(100);
                }
                Console.WriteLine($"TaskId {Task.CurrentId}.End generating");
            });

            Task task2 = task1.ContinueWith((t) => //должен принимать параметр типа Task, будет ран когда тот у кого был вызван метод закончит
            {
                Console.WriteLine($"TaskId {Task.CurrentId}.Start Printing");
                for (int i = 0; i < list.Count; i++)
                {
                Console.WriteLine($"{i+1}. {list[i]}");
                }
                Console.WriteLine($"TaskId {Task.CurrentId}.End Printing");
            });

            Task task3 = task2.ContinueWith((t) => 
            {
                Console.WriteLine($"TaskId {Task.CurrentId}.Start calculating sum");
                Console.WriteLine($"Sum = {list.Sum()}");
                Console.WriteLine($"TaskId {Task.CurrentId}.End calculating sum");
            });

            Task task4 = task3.ContinueWith((t) =>
            {
                Console.WriteLine($"TaskId {Task.CurrentId}.Start calculating average value");
                Console.WriteLine($"Average value = {list.Average()}");
                Console.WriteLine($"TaskId {Task.CurrentId}.End calculating value");
            });

            task1.Start(); //в итоге потребуеться запустить только корневой метод, так как остальные сами пойдут по каскаду
            Console.WriteLine("Waiting for all tasks to finish");
            task4.Wait();
            Console.WriteLine("\n\tAll tasks finished");
        }

        private static void TestTasks5_Cancel()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(); // генератор токена отмены
            CancellationToken token = cancellationTokenSource.Token;

            Task task = Task.Run(() =>
            {
                int mult = 1;
                for (int i = 1; i < 21; i++)
                {
                    Console.WriteLine($"\t{i}");
                    Thread.Sleep(200);
                    if (token.IsCancellationRequested) 
                    {
                        Console.WriteLine($"{Task.CurrentId} -> Cancelation requested");
                        return;
                    }
                    mult *= i;
                    Console.WriteLine($"\nMult = {mult}");
                    Thread.Sleep(200);
                }
            },token); //дали ему наш токен
            Thread.Sleep(1000);
            cancellationTokenSource.Cancel();
            task.Wait();
            Console.WriteLine($"Task status = {task.Status}");
            cancellationTokenSource.Dispose();// использовать using, чтобы точно не забывать очищать
        }

        private static void TestTasks6_Exception()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            Task task = Task.Run(() =>
            {
                int mult = 1;
                for (int i = 1; i < 21; i++)
                {
                    Console.WriteLine($"\t{i}");
                    Thread.Sleep(200);
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine($"{Task.CurrentId} -> Cancelation requested");
                        token.ThrowIfCancellationRequested(); 
                    }
                    mult *= i;
                    Console.WriteLine($"\nMult = {mult}");
                    Thread.Sleep(200);
                }
            }, token);
            Thread.Sleep(1000);
            try
            {
                cancellationTokenSource.Cancel();
                task.Wait();
            }
            catch (AggregateException ex)
            {
                foreach (var item in ex.InnerExceptions)
                {
                    Console.WriteLine(item.Message);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine($"Task status = {task.Status}");
                cancellationTokenSource.Dispose();
            }
        }

        private static void TestTasks7_Cancel()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(); // генератор токена отмены
            CancellationToken token = cancellationTokenSource.Token;

            Task task = Task.Factory.StartNew(() => MultNumbers(token), token);


            Thread.Sleep(1000);
            cancellationTokenSource.Cancel();
            task.Wait();
            Console.WriteLine($"Task status = {task.Status}");
            cancellationTokenSource.Dispose();
        }
        private static void MultNumbers(CancellationToken token)
        {
            int mult = 1;
            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine($"\t{i}");
                Thread.Sleep(200);
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine($"{Task.CurrentId} -> Cancelation requested");
                    return;
                }
                mult *= i;
                Console.WriteLine($"\nMult = {mult}");
                Thread.Sleep(200);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ShowDateTimeWithTasks();
            //CountPrimesTask();
            //AnalyzeArrayTask();
            ProcessArrayTask();
            Console.WriteLine("Press ENTER...");
            Console.ReadLine();
        }
        #region Task 1
        private static void ShowDateTimeWithTasks()
        {
            new Task(ShowDateTime).Start();
            Task.Run(ShowDateTime);
            Task.Factory.StartNew(ShowDateTime);
        }
        private static void ShowDateTime()
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine($"TaskId: {Task.CurrentId} -> Current date: " + dateTime.ToShortDateString());
            Console.WriteLine($"TaskId: {Task.CurrentId} -> Current time: " + dateTime.ToShortTimeString());
        }
        #endregion
        #region Task 2 and 3
        private static int primesCount = 0;
        private static void CountPrimesTask()
        {
            try
            {
                Console.Write("Enter start of range: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter end of range: ");
                int num2 = int.Parse(Console.ReadLine());
                Task task = Task.Run(() => CountPrimes(num1, num2));
                task.Wait();
                Console.WriteLine("Number of encountered prime numbers: {0}", primesCount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        private static void CountPrimes(int min, int max)
        {
            for (int i = min; i <= max; i++)
            {
                if (i.IsPrime())
                {
                    ++primesCount;
                }
            }
        }
        #endregion
        #region Task 4
        private static List<int> list;
        private static int max;
        private static int min;
        private static int sum;
        private static double avg;
        private static void AnalyzeArrayTask()
        {
            list = new List<int>() { };
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                list.Add(rand.Next(1, 1001));
            }
            Task[] tasks = new Task[4];
            tasks[0] = Task.Run(FindMinimum);
            tasks[1] = Task.Run(FindMaximum);
            tasks[2] = Task.Run(FindSum);
            tasks[3] = Task.Run(FindAverage);
            Task.WaitAll(tasks);
            Console.WriteLine($"Maximum: {max}");
            Console.WriteLine($"Minimum: {min}");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average value: {avg}");
        }
        private static void FindMinimum() 
        {
            min = list.Min();
        }
        private static void FindMaximum()
        {
            max = list.Max();
        }
        private static void FindSum()
        {
            sum = list.Sum();
        }
        private static void FindAverage()
        {
            avg = list.Average();
        }
        #endregion
        #region Task 5
        private static List<int> processedList;
        private static void ProcessArrayTask()
        {
            processedList = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                processedList.Add(rand.Next(1, 1001));
            }
            Task taskRemoveCopies = new Task(RemoveCopies);
            Task taskSort = taskRemoveCopies.ContinueWith((t) => SortArray());
            Task taskSearch = taskSort.ContinueWith((t) => BinarySearch());
            taskRemoveCopies.Start();
            taskSearch.Wait();
        }
        private static void RemoveCopies() 
        {
            HashSet<int> copyHolder = new HashSet<int>();
            for (int i = 0; i < processedList.Count; i++)
            {
                if (!copyHolder.Add(processedList[i])) 
                {
                    processedList.RemoveAt(i);
                }
            }
        }
        private static void SortArray() => processedList.Sort();
        private static void BinarySearch()
        {
            Console.Write("Enter number to search for: ");
            int num;
            bool converted = int.TryParse(Console.ReadLine(), out num);
            if (!converted) Console.WriteLine("INPUT error, 0 will be used in search instead");
            int ind = processedList.BinarySearch(num);
            if (ind < 0)
            {
                Console.WriteLine("No such number was found in the array!");
            }
            else
            {
                Console.WriteLine("Got a match! Index: {0}",ind);
            }
        }
        #endregion
    }





    public static partial class Extensions
    {
        public static bool IsPrime(this Int32 @this)
        {
            if (@this == 1 || @this == 2)
            {
                return true;
            }

            if (@this % 2 == 0)
            {
                return false;
            }

            var sqrt = (Int32)Math.Sqrt(@this);
            for (Int64 t = 3; t <= sqrt; t += 2)
            {
                if (@this % t == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

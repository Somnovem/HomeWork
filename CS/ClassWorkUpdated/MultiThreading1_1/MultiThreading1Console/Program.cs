using MultiThreading1Console;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace SpPractice3_1Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "MultiThreading1_1";
            NumbersRanged();
            Console.WriteLine("\nPress ENTER...");
            Console.ReadKey();
        }
        private static void Numbers0to50() 
        {
            Console.Clear();
            FunctionIterator func = new FunctionIterator();
            Thread thread = new Thread(func.Iterate);
            thread.Start();
            thread.Join();
        }
        private static void NumbersRanged() 
        {
            int start, end, threads;
            try
            {
                Console.Write("Enter start = ");
                start = int.Parse(Console.ReadLine());
                Console.Write("Enter end = ");
                end = int.Parse(Console.ReadLine());
                Console.Write("Enter number of threads working = ");
                threads = int.Parse(Console.ReadLine());
                if (threads <= 0)
                {
                    Console.WriteLine("Number of threads cannot be less than 1");
                    return;
                }
            }
            catch 
            {
                return;
            }
            int gap = end - start;
            if (gap <= 0) 
            {
                Console.WriteLine("Invalid input");
                return;
            }
            int step = gap / threads;
            while ((start+step) < end)
            {
                FunctionIterator func = new FunctionIterator() { Start = start,End = start+step};
                Thread thread = new Thread(func.Iterate);
                thread.Start();
                start += step;
            }
            FunctionIterator funcEnd = new FunctionIterator() { Start = start, End = end };
            Thread threadEnd = new Thread(funcEnd.Iterate);
            threadEnd.Start();
        }
        private static void AnalyzeNumbersTo10000() 
        {
            List<int> nums = new List<int>();
            Random r = new Random();
            Console.WriteLine("Generating numbers");
            for (int i = 0; i < 10000; i++)
            {
                nums.Add(r.Next(1, 100000));
            }
            Thread thread = new Thread(PrintListResult);
            thread.Start(nums);
            thread.Join();
        }
        private static void FindMaximum(object list) 
        {
            List<int> nums = list as List<int>;
            int max = nums.Max();
            using (StreamWriter file = new StreamWriter("analyze.txt",true))
            {
                file.WriteLine($"Maximum: {max}");
            }
        }
        private static void FindMinimum(object list)
        {
            List<int> nums = list as List<int>;
            int min = nums.Min();
            using (StreamWriter file = new StreamWriter("analyze.txt", true))
            {
                file.WriteLine($"Minimum: {min}");
            }
        }
        private static void FindAverage(object list)
        {
            List<int> nums = list as List<int>;
            double avg = nums.Average();
            using (StreamWriter file = new StreamWriter("analyze.txt", true))
            {
                file.WriteLine($"Average: {avg}");
            }
            Console.WriteLine("Analyzing end!");
        }
        private static void PrintListResult(object list) 
        {
            List<int> nums = list as List<int>;
            using (StreamWriter file = new StreamWriter("analyze.txt"))
            {
                Console.WriteLine("Started writing");
                foreach (var item in nums)
                {
                    file.WriteLine(item);
                }
            }
            Console.WriteLine("Writing end");
            Console.WriteLine("--------------");
            Console.WriteLine("Searching for maximum...");
            Thread threadMax = new Thread(FindMaximum);
            threadMax.Start(nums);
            threadMax.Join();
            Console.WriteLine("Searching for minimum...");
            Thread threadMin = new Thread(FindMinimum);
            threadMin.Start(nums);
            threadMin.Join();
            Console.WriteLine("Searching for average...");
            Thread threadAvg = new Thread(FindAverage);
            threadAvg.Start(nums);
            threadAvg.Join();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace Practice2_1
{
    internal class Program
    {

        private static object lockObject = new object();
        static void Main(string[] args)
        {
            #region Task 1 Main
            //analyzeNumbers = new AutoResetEvent(false);
            //Thread thread1 = new Thread(GenerateNumbers);
            //Thread thread2 = new Thread(MaxNumber);
            //Thread thread3 = new Thread(MinNumber);
            //Thread thread4 = new Thread(AvgNumber);
            //thread1.Start();
            //thread2.Start();
            //thread3.Start();
            //thread4.Start();
            //while (count > 0)
            //{
            //    Thread.Sleep(200);
            //}
            //Console.WriteLine($"Maximum: {max}");
            //Console.WriteLine($"Minumum: {min}");
            //Console.WriteLine($"Average: {avg}");
            #endregion
            #region Task 2 Main
            Console.Write("Enter path to the file: ");
            string path = Console.ReadLine();
            if (!File.Exists(path))
            {
                Console.WriteLine("No such file exists");
                Console.WriteLine("Press Enter to exit...");
                Console.ReadLine();
                return;
            }
            Thread thread1 = new Thread(CountSentences);
            thread1.Start(path);
            Thread thread2 = new Thread(Replacer);
            thread2.Start(path);
            #endregion
            #region Task 3 Main
            //Thread thread1 = new Thread(SortArray);
            //thread1.Start(list);
            //Thread thread2 = new Thread(ArrayContains);
            //thread2.Start(1);
            #endregion
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
        #region Task 1
        //private static List<int> list;
        //private static AutoResetEvent analyzeNumbers;
        //private static int count = 3;
        //private static int max = 0;
        //private static int min = 0;
        //private static double avg = 0d;
        //private static void GenerateNumbers()
        //{
        //    Random random = new Random();
        //    list = new List<int>();
        //    for (int i = 0; i < 1000; i++)
        //    {
        //        list.Add(random.Next(0, 5001));
        //    }
        //    analyzeNumbers.Set();
        //}
        //private static void MaxNumber()
        //{
        //    analyzeNumbers.WaitOne();
        //    max = list.Max();
        //    count--;
        //    analyzeNumbers.Set();
        //}
        //private static void MinNumber()
        //{
        //    analyzeNumbers.WaitOne();
        //    min = list.Min();
        //    count--;
        //    analyzeNumbers.Set();
        //}
        //private static void AvgNumber()
        //{
        //    analyzeNumbers.WaitOne();
        //    avg = list.Average();
        //    count--;
        //    analyzeNumbers.Set();
        //}
        #endregion
        #region Task 2
        private static void CountSentences(object obj)
        {
            lock (lockObject)
            {
                string path = (string)obj;
                string content = "";
                foreach (var item in File.ReadAllLines(path))
                {
                    content += item;
                }
                Console.WriteLine("Number of sentences = " + content.Split(".?!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Count());
            }
        }
        private static void Replacer(object obj)
        {
            lock (lockObject)
            {
                string path = (string)obj;
                string content = "";
                foreach (var item in File.ReadAllLines(path))
                {
                    content += item + '\n';
                }
                content = content.Replace('!', '#');
                File.WriteAllLines(path, content.Split('\n'));
            }
        }
        #endregion
        #region Task 3
        //private static List<int> list = new List<int> { 8, 99, 4, 10, 2, 634 };
        //private static void SortArray(object obj)
        //{
        //    lock (lockObject)
        //    {
        //        List<int> temp = (List<int>)obj;
        //        temp.Sort();
        //        for (int i = 0; i < temp.Count; i++)
        //        {
        //            Console.WriteLine(temp[i]);
        //        }
        //    }
        //}
        //private static void ArrayContains(object obj)
        //{
        //    lock (lockObject)
        //    {
        //        int num = (int)obj;
        //        string res = list.Contains(num) ? "contains" : "does not contain";
        //        Console.WriteLine($"Array {res} {num}");
        //    }
        //}
        #endregion
    }
}

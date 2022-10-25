using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace smth
{
    class Moderator
    {
        public static string Multiply(string str, int count)
        {
            string res = "";
            for (int i = 0; i < count; i++)
            {
                res += str;
            }
            return res;
        }
        public static void Work()
        {
            Console.Write("Path to the file to moderate: ");
            string moderate = Console.ReadLine();
            if (!File.Exists(moderate))
            {
                Console.WriteLine("No such file exists");
                Environment.Exit(-1);
            }
            Console.Write("Path to the file of words to moderate with: ");
            string words = Console.ReadLine();
            if (!File.Exists(words))
            {
                Console.WriteLine("No such file exists");
                Environment.Exit(-1);
            }
            string container = null;
            using (FileStream mod = new FileStream(moderate,FileMode.Open,FileAccess.Read,FileShare.Read))
            {
                string[] ModeretionalWords = null;
                using (FileStream word = new FileStream(words, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    using (StreamReader sr = new StreamReader(word, Encoding.Default))
                    {
                        ModeretionalWords = sr.ReadToEnd().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                    }
                }

                using (StreamReader sr = new StreamReader(mod, Encoding.Default))
                {
                    container = sr.ReadToEnd();
                }
                foreach (var item in ModeretionalWords)
                {
                    container = container.Replace(item, Multiply("*", item.Length));
                }
            }
            using (FileStream mod = new FileStream(moderate, FileMode.Truncate, FileAccess.Write, FileShare.None))
            {
                using (StreamWriter sw = new StreamWriter(mod,Encoding.Default))
                {
                    sw.Write(container);
                }
            }
        }
    }

    static class RandomNumberAnalyzer
    {
        static RandomNumberAnalyzer()
        {
            if (!File.Exists("Random Numbers.txt"))
            {
                using (FileStream fs = new FileStream("Random Numbers.txt",FileMode.Create,FileAccess.Write,FileShare.None))
                {
                    Random random = new Random();
                    using (StreamWriter sw = new StreamWriter(fs,Encoding.Default))
                    {
                        for (int i = 0; i < 100000; i++)
                        {
                            sw.Write(random.Next(-15000, 15000) + " ");
                        }
                    }
                }
            }
        }
        public static void Work()
        {
            if (!File.Exists("Random Numbers.txt"))
            {
                throw new FileNotFoundException();
            }
            int[] numbers = null;
            using (FileStream fs = new FileStream("Random Numbers.txt",FileMode.Open,FileAccess.Read,FileShare.Read))
            {
                using (StreamReader sr = new StreamReader(fs,Encoding.Default))
                {
                    numbers = Array.ConvertAll(sr.ReadToEnd().Split(" ", StringSplitOptions.RemoveEmptyEntries), item => (int)Convert.ToInt32(item));
                }
            }
            int[] positiveNumbers = numbers.FilterBy(x => x > 0).ToArray();
            int[] negativeNumbers = numbers.FilterBy(x => x < 0).ToArray();
            int[] twoDigitsNumbers = numbers.FilterBy(x => x/10 >= 1 && x/100 <1).ToArray();
            int[] fiveDigitsNumbers = numbers.FilterBy(x => x / 10000 >= 1 && x / 100000 < 1).ToArray();
            Console.WriteLine($"Number of positive numbers: {positiveNumbers.Length}");
            Console.WriteLine($"Number of negative numbers: {negativeNumbers.Length}");
            Console.WriteLine($"Number of numbers with 2 digits: {twoDigitsNumbers.Length}");
            Console.WriteLine($"Number of numbers with 5 digits: {fiveDigitsNumbers.Length}");
            using (FileStream fs = new FileStream("positiveNumbers.txt", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (StreamWriter sr = new StreamWriter(fs, Encoding.Default))
                {
                    foreach (int number in positiveNumbers)
                    {
                        sr.Write(number + " ");
                    }
                }
            }
            using (FileStream fs = new FileStream("negativeNumbers.txt", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (StreamWriter sr = new StreamWriter(fs, Encoding.Default))
                {
                    foreach (int number in negativeNumbers)
                    {
                        sr.Write(number + " ");
                    }
                }
            }
            using (FileStream fs = new FileStream("twoDigitsNumbers.txt", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (StreamWriter sr = new StreamWriter(fs, Encoding.Default))
                {
                    foreach (int number in twoDigitsNumbers)
                    {
                        sr.Write(number + " ");
                    }
                }
            }
            using (FileStream fs = new FileStream("fiveDigitsNumbers.txt", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (StreamWriter sr = new StreamWriter(fs, Encoding.Default))
                {
                    foreach (int number in fiveDigitsNumbers)
                    {
                        sr.Write(number + " ");
                    }
                }
            }
        }
    }
}

using ExternFunctions;
using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Homework2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SearchWordInDirectory("one","C:\\Users\\Artem\\Desktop", "C:\\Users\\Artem\\Desktop\\Analysis2.txt"));
            Console.ReadLine();
        }
        private static readonly object lockObject = new object();
        public static int SearchWordInDirectory(string word, string sourceDirectory, string logfilePath)
        {
            if (!Directory.Exists(sourceDirectory)) return -1;
            Regex regex = new Regex("^[a-zA-Z]:[\\\\\\/][\\w\\\\\\/]+\\w+\\.txt$");
            if (!regex.IsMatch(logfilePath)) return -2;
            int count = 0;
            using (StreamWriter writer = new StreamWriter(File.Create(logfilePath))) //ensures file is created, or cleared
            {
                writer.WriteLine($"Word(s) scanned for: {word}");
                writer.WriteLine($"Date of search: {DateTime.Now}");
                writer.WriteLine("------------------------------------------------------------------------------");
                foreach (var filename in Directory.GetFiles(sourceDirectory, "*.txt", SearchOption.AllDirectories))
                {
                    count += CountWordInFile(word,filename,writer);
                }

            }
            return count;
        }
        private static int CountWordInFile(string word, string filepath,StreamWriter writer)
        {
            try
            {
                Monitor.Enter(lockObject);
                int appearences = File.ReadAllLines(filepath).Count(c => c.Contains(word));
                writer.WriteLine($"File scanned: {filepath}");
                writer.WriteLine($"Number of appearences: {appearences}");
                return appearences;
            }
            finally
            {
                Monitor.Exit(lockObject);
            }

        }
    }
}
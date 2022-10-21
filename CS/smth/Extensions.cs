using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smth
{
    static class ExtensionMethod
    {
        public static bool IsPerfectSquare(this int number)
        {
            int square = (int)Math.Sqrt(number);
            return Math.Pow(square, 2) == number;
        }
        public static bool IsFibonacci(this int number)
        {
            return IsPerfectSquare(5 * (int)Math.Pow(number, 2) + 4) ||
                   IsPerfectSquare(5 * (int)Math.Pow(number, 2) - 4);
        }
        public static int WordsCount(this string str)
        {
            char[] separators = { ' ', '.', ';', '?', ',', '!', ':' };
            return str.Split(separators, StringSplitOptions.RemoveEmptyEntries).Count();
        }

        public static int LastWordLength(this string str)
        {
            char[] separators = { ' ', '.', ';', '?', ',', '!', ':' };
            return str.Split(separators, StringSplitOptions.RemoveEmptyEntries).Last().Length;
        }
        public static bool IsValidParenthes(this string str)
        {
            Stack<char> validator = new Stack<char>();
            foreach (var item in str)
            {
                if (item == '(' || item == '{' || item == '[')
                {
                    validator.Push(item);
                }
                else if (item == ')')
                {
                    if (validator.Peek() != '(')
                    {
                        return false;
                    }
                    validator.Pop();
                }
                else if (item == '}')
                {
                    if (validator.Peek() != '{')
                    {
                        return false;
                    }
                    validator.Pop();
                }
                else if (item == ']')
                {
                    if (validator.Peek() != '[')
                    {
                        return false;
                    }
                    validator.Pop();
                }
            }
            return validator.Count == 0;
        }
        public static T[] FilterBy<T>(this T[] arr, Predicate<T> predicate)
        {
            T[] res = arr.ToList().FindAll(predicate).ToArray();
            return res;
        }
        public static void Tests()
        {
            int[] arr = { 14, 1, 17, 15, 34, 47, 15 };
            foreach (var item in arr)
            {
                if (item.IsFibonacci())
                {
                    Console.WriteLine($"{item} is Fibonacci");
                }
                else
                {
                    Console.WriteLine($"{item} isn't Fibonacci");
                }
            }

            string str = "I love.Paris;As?such,I!am:French";
            Console.WriteLine(str.WordsCount());

            Console.WriteLine(str.LastWordLength());

            Console.WriteLine("[[{]}]".IsValidParenthes());
            Predicate<int> predicate = (int a) => { return a % 2 == 0; };
            int[] newArr = arr.FilterBy(IsPrime);
            Console.WriteLine("-------------");
            foreach (var item in newArr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static bool IsPrime(int n)
        {
        return n % 2 == 0;
        }
    }
}

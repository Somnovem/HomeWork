using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Tas8
    {
        public void Work()
        {
            while (true)
            {
                Console.Clear();
                int[] A = new int[5];
                int[,] B = new int[3, 4];
                Random r = new Random { };
                int sumPrime = 0;
                for (int i = 0; i < 5; i++)
                {
                    A[i] = int.Parse(Console.ReadLine());
                    if (i % 2 ==0)
                    {
                        sumPrime += A[i];
                    }
                }
                Console.Clear();
                Console.WriteLine();
                int sumNotPrime = 0;
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        B[i, j] = r.Next(1, 21);
                        if (i % 2 !=0)
                        {
                            sumNotPrime += B[i, j];
                        }
                    }
                }
                Console.WriteLine("First array: ");
                foreach (var a in A)
                {
                    Console.Write(" " + a);
                }
                Console.WriteLine();
                Console.WriteLine("Second array: ");
                int sum = 0;
                int max = B[0,0];
                int min = B[0, 0];
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        int temp = B[i, j];
                        Console.Write(" " + temp);
                        sum += temp;
                        if (max < temp)
                        {
                            max = temp;
                        }
                        else if (min > temp)
                        {
                            min = temp;
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Sum of the first array: " + A.Sum(x => x));
                Console.WriteLine("Sum of the second array: " + sum);
                Console.WriteLine("Max of the first array: " + A.Max(x => x));
                Console.WriteLine("Max of the second array: " + max);
                Console.WriteLine("Min of the first array: " + A.Min(x => x));
                Console.WriteLine("Min of the second array: " + min);
                int mult1 = 1;
                int mult2 = 1;
                foreach (var item in A)
                {
                    mult1 *= item;
                }
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        mult2*=B[i,j];    
                    }
                }
                Console.WriteLine("Multiplication of the first array: " + mult1);
                Console.WriteLine("Multiplication of the second array: " + mult2);
                Console.WriteLine("Sum of numbers with a prime index in first array: " + sumPrime);
                Console.WriteLine("Sum of numbers with a not prime index in second array: " + sumNotPrime);
                Console.WriteLine();
                Console.ReadKey();
            }
            
        }
    }
}

namespace Task9
{
    internal class Tas9
    {
        public class Pair<T, U>
        {
            public Pair()
            {
            }

            public Pair(T first, U second)
            {
                this.First = first;
                this.Second = second;
            }

            public T First { get; set; }
            public U Second { get; set; }
        };
        public void Work()
        {
            int[,] arr = new int[5, 5];
            Random r = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = r.Next(-100, 101);
                }
            }
            Pair<int,int> first_Coords = new Pair<int,int>(0,0);
            Pair<int, int> second_Coords = new Pair<int, int>(0, 0);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[first_Coords.First,first_Coords.Second] > arr[i,j])
                    {
                        first_Coords.First = i;
                        first_Coords.Second = j;
                    }
                    else if (arr[second_Coords.First, second_Coords.Second] < arr[i,j])
                    {
                        second_Coords.First = i;
                        second_Coords.Second = j;
                    }
                }
            }

            for (int i = 0; i < first_Coords.First + second_Coords.First + 1; i++)
            {
                int j = (i == 0) ? first_Coords.Second : 0;
                for (; j < arr.GetLength(1); j++)
                {
                    Console.Write(" " + arr[i, j]);
                    if (i == second_Coords.First && j == second_Coords.Second)
                    {
                        break;
                    }
                }
            }
        }
    }
}

namespace Ceasar
{
    internal class Chyphere
    {
    public void Work()
    {
            Console.Write("Line to encode: ");
            String clear = Console.ReadLine();
            Console.Write("Positions changed: ");
            int difference = int.Parse(Console.ReadLine());
            String encoded = "";
            Console.WriteLine("Choose mode:\n 1 - Encode\n 2 - Decode");
            int mode = int.Parse(Console.ReadLine());
            switch (mode)
            {
                case 1:
                    foreach (var item in clear)
                    {
                        int temp = ((int)item + difference);
                        if (temp < 0) temp += 256;
                        else if(temp > 255) temp -= 255;
                        encoded += (char)temp;
                    }
                    break;
                case 2:
                    foreach (var item in clear)
                    {
                        int temp = ((int)item - difference);
                        if (temp < 0) temp += 256;
                        else if (temp > 255) temp -= 255;
                        encoded += (char)temp;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine(encoded);
            Console.ReadKey();
    }
    }
}

namespace Matrix
{

    internal class Matrixa
    {
        int[,] arr;
        public Matrixa(int rows, int cols,bool toInitialize = true) { arr = new int[rows, cols];
            Random random = new Random();
            if (toInitialize)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        arr[i, j] = random.Next(1, 21);
                    }
                }
            }
           
        }
        public static Matrixa operator +(Matrixa a, Matrixa b)
        {
            if (a.arr.GetLength(0) != b.arr.GetLength(0) || a.arr.GetLength(1) != b.arr.GetLength(1))
            {
                Console.WriteLine("Inccorect sizes. Returning an empty matrix");
                return null;
            }
            Matrixa temp = new Matrixa(a.arr.GetLength(0),a.arr.GetLength(1),false);
            for (int i = 0; i < temp.arr.GetLength(0); i++)
            {
                for (int j = 0; j < temp.arr.GetLength(1); j++)
                {
                    temp.arr[i, j] = a.arr[i, j] + b.arr[i, j];
                }
            }
            return temp;
        }
        public static Matrixa operator *(Matrixa a, Matrixa b)
        {
            if (a.arr.GetLength(1) != b.arr.GetLength(0))
            {
                Console.WriteLine("Inccorect sizes. Returning an empty matrix");
                return null;
            }
            Matrixa temp = new Matrixa(a.arr.GetLength(0), a.arr.GetLength(0),false);

            for (int i = 0; i < temp.arr.GetLength(0); i++)
            {
                for (int j = 0; j < b.arr.GetLength(1); j++)
                {
                    for (int m = 0; m < temp.arr.GetLength(1); m++)
                    {
                        temp.arr[i, j]+= a.arr[i,m] * b.arr[m,j];
                    }
                }
            }
            return temp;
        }
        public static Matrixa operator *(Matrixa a, int b)
        {
            Matrixa temp = new Matrixa(a.arr.GetLength(0),a.arr.GetLength(1), false);
            for (int i = 0; i < temp.arr.GetLength(0); i++)
            {
                for (int j = 0; j < temp.arr.GetLength(1); j++)
                {
                    temp.arr[i, j] = a.arr[i, j] * b;
                }
            }
            return temp;
        }
        public void print()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(" " + arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

namespace Task10
{
    internal class Tas10
    {
    public void Work()
        {
            Console.Clear();
            Console.Write("Line: ");
            String line = Console.ReadLine();
            List<String> temp = (line.Split("+-\n\0".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)).ToList();
            List<int> temp2 = temp.ConvertAll(x=>int.Parse(x));
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '+')
                {
                    int first = temp2.ElementAt(0);
                    temp2.Remove(first);
                    int second = temp2.ElementAt(0);
                    temp2.Remove(second);
                    temp2.Insert(0,first + second);
                }
                else if (line[i] == '-')
                {
                    int first = temp2.ElementAt(0);
                    temp2.Remove(first);
                    int second = temp2.ElementAt(0);
                    temp2.Remove(second);
                    temp2.Insert(0,first - second);
                }
            }
            Console.WriteLine("Result: " + temp2.First());
        }
    }
}

namespace Task11
{
    internal class Tas11
    {
    public void Work()
    {
            Console.Clear();
            Console.Write("Text: ");
            String temp = Console.ReadLine();
            var unedited = temp.Split(".!?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            List<String> edited = new List<String> { };
            for (int i = 0; i < unedited.Length; i++)
            {
                edited.Add(Char.ToUpper(unedited[i][0]) + unedited[i].Substring(1));
            }
            foreach (var item in edited)
            {
                Console.WriteLine(item);
            }
    }
    }
}

namespace Task12
{
    internal class Tas12
    {
    public void Work()
    {
            Console.Write("Text: ");
            String unedited = Console.ReadLine();
            Console.Write("Banned words(separate by commas): ");
            String temp = Console.ReadLine();
            var bannedWords = temp.Split(",\n".ToCharArray(), StringSplitOptions.None);
            Console.WriteLine("Result: ");
            Dictionary<String, int> voc = new Dictionary<String, int>();
            for (int i = 0; i < bannedWords.Length; i++)
            {
                String equivalent = "";
                for (int j = 0; j < bannedWords[i].Length; j++)
                {
                    equivalent += '*';
                }
                String trash = unedited.Replace(bannedWords[i], equivalent);
                if (unedited != trash)
                {
                    int value = 0;
                    if (voc.TryGetValue(bannedWords[i], out value))
                    {
                        voc.Remove(bannedWords[i]);
                        voc.Add(bannedWords[i],++value);
                    }
                    else
                    {
                        voc.Add(bannedWords[i], ++value);
                    }
                    unedited = trash;
                }
            }
            Console.WriteLine(unedited);
            var tempVoc = voc.ToArray();
            for (int i = 0; i < tempVoc.Length; i++)
            {
                Console.WriteLine(tempVoc[i].Key + " was found " + tempVoc[i].Value + " times");
            }
    }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SpHomeWork3_1
{
    internal class PrimeGenerator
    {
        public  int Start { get; set; }
        public  int End { get; set; }
        public  event Action<int> FoundPrime;
        public event Action Finished;
        public  void GeneratePrimeNumbers() 
        {
            int start = Start;
            int end = End;
            int n = 1, m;
            bool found = false;
            if (start == -1)
            {
                for (n = 2;  n < end; n++)
                {
                    m = n / 2;
                    found = false;
                    for (int i = 2; i <= m; i++)
                    {
                        if (n % i == 0)
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found) FoundPrime.Invoke(n);
                }
            }
            else if (end == -1) 
            {
                while (true)
                {
                    m = n / 2;
                    found = false;
                    for (int i = 2; i <= m; i++)
                    {
                        if (n % i == 0)
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found) FoundPrime.Invoke(n);
                    n++;
                }
            }
            else
            {
                for (;n < end; n++)
                {
                    m = n / 2;
                    found = false;
                    for (int i = 2; i <= m; i++)
                    {
                        if (n % i == 0)
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found) FoundPrime.Invoke(n);
                }
            }
            Thread.Sleep(50);
            Finished.Invoke();
        }

    }
    internal class FibonacciGenerator
    {
        private int a = 1, b = 1, x;
        public event Action<long> NextFibonacci;
        public event Action Finished;
        public void GenerateFibonacciNumbers()
        {
            while (true)
            {
                x = a;
                a = b;
                b = x + a;
                if (b < 1)
                {
                    Finished.Invoke();
                }
                Thread.Sleep(50);
                NextFibonacci.Invoke(b);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading1Console
{
    internal class FunctionIterator
    {
        private int start, end;
        private List<int> res;
        public List<int> Res => res;
        public int Start
        {
            get => start;
            set { if (value != start) start = value; }
        }
        public int End
        {
            get => end;
            set { if (value != end) end = value; }
        }
        public FunctionIterator()
        {
            start = 0;
            end = 50;
            res = new List<int>();
        }
        public void Iterate()
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine($"--{i}--");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    interface IA
    {
        void Print();
    }

    interface IB
    {
        void Print();
    }
    interface IC: IA, IB
    {
        void Print();
    }

    class ABC : IC
    {
        public void Print()
        {
            Console.WriteLine("HELLO C");
        }

        void IA.Print()
        {
            Console.WriteLine("HELLO A");
        }

        void IB.Print()
        {
            Console.WriteLine("HELLO B");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Homework1_1
{
    internal class ValueProvider : IDisposable
    {
        private Thread thread;
        public int Count { get; set; }
        public event Action<int[]> ReadyToProvide;
        public ValueProvider(int count)
        {
            Count = count;
        }
        public void StartProviding() 
        {
            thread = new Thread(Provide);
            thread.Start();
        }
        private void Provide() 
        {
            Random rnd = new Random();
            while (true)
            {
                int[] arr = new int[Count];
                for (int i = 0; i < Count; i++)
                {
                    arr[i] = rnd.Next(50, 95);
                }
                Thread.Sleep(250);
                ReadyToProvide?.Invoke(arr);
            }
        }
        public void Dispose()
        {
            thread.Abort();
        }
    }
}

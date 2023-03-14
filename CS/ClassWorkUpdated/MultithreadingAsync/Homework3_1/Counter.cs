using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Homework3_1
{
    internal class Counter : IDisposable
    {
        public static int semaphoreSize = 3;
        private static Semaphore semaphore = new Semaphore(semaphoreSize, semaphoreSize);
        public static int threadCount = 1;
        public static void RecreateSemaphore() 
        {
            semaphore.Close();
            semaphore = new Semaphore(semaphoreSize, semaphoreSize);
        }
        public Thread mainThread;
        public int count = 2;
        public bool wasRunning = false;
        public delegate void EnteredSemaphoreEvent(Counter counter);
        public event EnteredSemaphoreEvent SemaphoreStateChanged;
        public delegate void CounterEvent(Counter counter, int num);
        public event CounterEvent CountPerformed;
        public Counter()
        {
            mainThread = new Thread(Count);
            mainThread.Name = $"Thread {threadCount++}";
        }
        public void Count() 
        {
            semaphore.WaitOne();
            wasRunning = true;
            if (count == 2) SemaphoreStateChanged?.Invoke(this);//signaling only when counter is new
            else count--;//preventing skipping a number
            while (true)
            {
                CountPerformed?.Invoke(this, count++);
                Thread.Sleep(1000);
            }
        }
        public override string ToString()
        {
            string init = $"{mainThread.Name} -> ";
            switch (mainThread.ThreadState)
            {
                case ThreadState.Running:
                    init += "Waiting";
                    break;
                default:
                    init += $"{mainThread.ThreadState}";
                    break;
            }
            return init;
        }
        public void Dispose()
        {
            try
            {
                if (wasRunning) semaphore.Release();
                mainThread.Abort();
            }
            catch
            {

            }
        }
    }
}

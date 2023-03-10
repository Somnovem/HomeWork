using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SysApps6_1
{
    internal class Reader
    {
        //семафор тоже системный
        private static Semaphore semaphore = new Semaphore(3, 3);//розраничивает сколько изначальных запросов, и сколько могут одновременно читать данные

        private Thread thread;
        private int count = 3;
        public string ThreadName => thread.Name;

        public delegate void ReaderMessageEvent(Reader sender, string message);
        public event ReaderMessageEvent ReaderMessage;

        public delegate void ReadCompleteEvent(Reader sender);
        public event ReadCompleteEvent ReadCompleted;
        public Reader(int id)
        {
            thread = new Thread(Read);
            thread.Name = $"Reader {id}";
            thread.Start();
        }
        private void Read()
        {
            while (count-- > 0)
            {
                if (semaphore.WaitOne(200))
                {
                    //читатель входит в библиотеку и занимает место
                    ReaderMessage?.Invoke(this, $" entered the library");
                    Thread.Sleep(100);
                    ReaderMessage?.Invoke(this, $" is reading");
                    Thread.Sleep(1000);
                    ReaderMessage?.Invoke(this, $" left the library");
                    semaphore.Release();
                    Thread.Sleep(1000);
                }
                else
                {
                    ReaderMessage?.Invoke(this, $" timedout");
                    Thread.Sleep(500);
                }

            }
            ReadCompleted?.Invoke(this);
        }
        public override string ToString()
        {
            return ThreadName;
        }
    }
}

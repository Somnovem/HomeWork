using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Homework3_1Server
{
    internal class QueueLogger
    {
        private List<string> loggingQueue;
        private string logPath;
        private object lockObject = new object();
        public QueueLogger()
        {
            loggingQueue = new List<string>();
            logPath = @"..\..\log.txt";
            File.Create(logPath); //create or empty the file
        }
        public void AddToQueue(string message)
        {
            loggingQueue.Add(message);
            if (loggingQueue.Count >= 15) Log();
        }
        public void Log()
        {
            lock (lockObject)
            {
                using (StreamWriter writer = new StreamWriter(logPath, true))
                {
                    foreach (string message in loggingQueue.ToList())
                    {
                        writer.WriteLine(message);
                        loggingQueue.Remove(message);
                    }
                }
            }

        }
    }
}

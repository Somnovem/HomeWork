using System;
using System.Linq;
using System.Threading;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Practice1_1
{
    internal class CopyHolder : IDisposable
    {
        public string[] Sources { get; set; }
        public string Destination { get; set; }
        public bool SimulateHardProcess { get; set; }
        private Thread workingThread;
        public event Action<int> Finished;


        public void StartWork() 
        {
            workingThread = new Thread(PerformCopy);
            workingThread.Start();
        }
        private void PerformCopy() 
        {
            int count = 0;
            for (int i = 0; i < Sources.Count(); i++)
            {
                string fName = Sources[i];
                string name = fName.Substring(fName.LastIndexOf('\\') + 1);
                string newPath = $"{Destination}\\{name}";
                using (Stream source = File.Open(fName, FileMode.Open, FileAccess.Read, FileShare.Read))
                 {
                     using (Stream destination = File.Create(newPath))
                     {
                         if(SimulateHardProcess) Thread.Sleep(5000);
                         source.CopyTo(destination);
                         count++;
                     }
                 }
            }
            Finished?.Invoke(count);
        }
        public void FreezeWork() 
        {
            if (workingThread == null || workingThread.ThreadState == ThreadState.Suspended) return;
            workingThread.Suspend();
        }
        public void ResumeWork() 
        {
            if (workingThread == null || workingThread.ThreadState != ThreadState.Suspended) return;
            workingThread.Resume();
        }
        public void AbortWork() 
        {
            if (workingThread == null) return;
            if (workingThread.ThreadState == ThreadState.SuspendRequested || workingThread.ThreadState == ThreadState.Suspended) workingThread.Resume();
            workingThread.Abort();
        }

        public void Dispose()
        {
            AbortWork();
        }
    }
}

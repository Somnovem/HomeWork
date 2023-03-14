using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Management;

namespace Homework3_1
{
    public partial class MainFormSemaphores : Form
    {
        private List<Counter> counters;
        private int lastSitCount;
        public MainFormSemaphores()
        {
            InitializeComponent();
            counters = new List<Counter>();
            lastSitCount = (int)edSemaphoreSitCount.Value;
        }

        /// <summary>
        /// Auto scales size of the form to always see all threads in their respective lists
        /// </summary>
        private void CheckResizeNeeded()
        {
            int max = 5;
            if(lbCreatedThreads.Items.Count > max) max = lbCreatedThreads.Items.Count;
            if(lbWaitingThreads.Items.Count > max) max = lbWaitingThreads.Items.Count;
            if(lbWorkingThreads.Items.Count > max) max = lbWorkingThreads.Items.Count;
            int newHeight = (19 * max) + 108;
            if(this.Size.Height != newHeight)this.Size = new Size(this.Size.Width, newHeight);
        }

        /// <summary>
        /// Creating new counter-thread to work with
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateThread_Click(object sender, EventArgs e)
        {
            Counter counter = new Counter();
            counter.CountPerformed += Counter_CountPerformed;
            counter.SemaphoreStateChanged += Counter_SemaphoreStateChanged;
            counters.Add(counter);
            lbCreatedThreads.Items.Add(counter);
            CheckResizeNeeded();
        }

        /// <summary>
        /// Counter entered semaphore, react
        /// </summary>
        /// <param name="counter"></param>
        private void Counter_SemaphoreStateChanged(Counter counter)
        {
            Action a = () =>
            {
                lbWaitingThreads.Items.Remove(counter);
                lbWorkingThreads.Items.Add($"{counter.mainThread.Name} -> 1");
                CheckResizeNeeded();
            };
            if (InvokeRequired) Invoke(a);
            else a();
        }

        /// <summary>
        /// Working counter returned a new value
        /// </summary>
        /// <param name="counter"></param>
        /// <param name="num"></param>
        private void Counter_CountPerformed(Counter counter, int num)
        {
            Action a = () =>
            {
               int ind = lbWorkingThreads.Items.IndexOf($"{counter.mainThread.Name} -> {num - 1}");
               if (ind == -1) return;
               lbWorkingThreads.Items[ind] = $"{counter.mainThread.Name} -> {num}";
            };
            try
            {
                if (InvokeRequired) Invoke(a);
                else a();
            }
            catch 
            {
                //invoking a disposed object
            }
 
        }

        /// <summary>
        /// Change number of sits in semaphore, restarting old ones and adding a new one if it was increased, 
        /// or clearing the list if it was decreased
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void edSemaphoreSitCount_ValueChanged(object sender, EventArgs e)
        {
            int newCount = (int)edSemaphoreSitCount.Value;
            Counter.semaphoreSize = newCount;
            Counter.RecreateSemaphore();
            if (lastSitCount > newCount)
            {
                lbWorkingThreads.Items.Clear();
                foreach (var item in counters.Where(c => c.wasRunning).ToList())
                {
                    counters.Remove(item);
                }
            }
            foreach (var item in counters.Where(c => c.mainThread.ThreadState == System.Threading.ThreadState.WaitSleepJoin).ToList())
            {
                string name = item.mainThread.Name;
                item.mainThread.Abort();
                item.mainThread = new Thread(item.Count);
                item.mainThread.Name = name;
                item.mainThread.Start();
            }
            lastSitCount = newCount;
            CheckResizeNeeded();
        }
        
        /// <summary>
        /// Send a created counter to semaphore
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbCreatedThreads_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbCreatedThreads.SelectedItems.Count == 0) return;
            Counter startingCounter = counters.Where(c => c == lbCreatedThreads.SelectedItem).ToArray()[0];
            lbCreatedThreads.Items.Remove(startingCounter);
            startingCounter.mainThread.Start();
            lbWaitingThreads.Items.Add(startingCounter);
            CheckResizeNeeded();
        }

        /// <summary>
        /// Stop and delete working counter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbWorkingThreads_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbWorkingThreads.SelectedItems.Count == 0) return;
            Counter deleteCounter = counters.Where(c => ((string)lbWorkingThreads.SelectedItem).Contains(c.mainThread.Name)).ToArray()[0];
            lbWorkingThreads.Items.Remove($"{deleteCounter.mainThread.Name} -> {deleteCounter.count - 1}");
            counters.Remove(deleteCounter);
            deleteCounter.Dispose();
            CheckResizeNeeded();
        }


        private void MainFormSemaphores_FormClosing(object sender, FormClosingEventArgs e)
        {
            KillProcessAndChildren(Process.GetCurrentProcess().Id);
        }


        /// <summary>
        /// Close this thread and all its children(recursively)
        /// </summary>
        private static void KillProcessAndChildren(int pid)
        {
            // Cannot close 'system idle process'.
            if (pid == 0)
            {
                return;
            }
            ManagementObjectSearcher searcher = new ManagementObjectSearcher
                    ("Select * From Win32_Process Where ParentProcessID=" + pid);
            ManagementObjectCollection moc = searcher.Get();
            foreach (ManagementObject mo in moc)
            {
                KillProcessAndChildren(Convert.ToInt32(mo["ProcessID"]));
            }
            try
            {
                Process proc = Process.GetProcessById(pid);
                proc.Kill();
            }
            catch (ArgumentException)
            {
                // Process already exited.
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SpHomeWork3_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Thread threadPrimes;
        Thread threadFibon;

#region Prime numbers
        private void btnPrimesStart_Click(object sender, EventArgs e)
        {
            if (!cbRangeStart.Checked && !cbRangeEnd.Checked)
            {
                MessageBox.Show("Can`t leave both limits unused");
                return;
            }
            lbPrimes.Items.Clear();
            btnPrimesStart.Enabled = false;
            int start = cbRangeStart.Checked ? (int)edRangeStart.Value : -1;
            int end = cbRangeEnd.Checked ? (int)edRangeEnd.Value : -1;
            PrimeGenerator gen = new PrimeGenerator() { Start = start, End = end };
            gen.FoundPrime += Gen_FoundPrime;
            gen.Finished += Gen_Finished;
            threadPrimes = new Thread(gen.GeneratePrimeNumbers);
            threadPrimes.Start();
        }

        private void Gen_Finished()
        {
            MessageBox.Show("Search for primes ended!");
            btnPrimesStop.BackColor = Color.Coral;
            threadPrimes.Abort();
        }

        private void Gen_FoundPrime(int obj)
        {
            Action a = () =>
            {
                if (threadPrimes != null)
                    lbPrimes.Items.Add(obj);
            };
            if (InvokeRequired)
                Invoke(a);
            else
                a();
        }

        private void btnPrimesReset_Click(object sender, EventArgs e)
        {
            if (threadPrimes == null) return;
            if (threadPrimes.IsAlive) btnPrimesStop_Click(null, null);
            btnPrimesStart.Enabled = true;
            cbRangeStart.Checked = true;
            cbRangeEnd.Checked = false;
            edRangeStart.Value = 0;
            edRangeEnd.Value = 0;
            btnPrimesStop.BackColor = Color.White;
            threadPrimes = null;
            lbPrimes.Items.Clear();
        }

        private void btnPrimesFreeze_Click(object sender, EventArgs e)
        {
            if (threadPrimes != null && threadPrimes.IsAlive && threadPrimes.ThreadState != ThreadState.SuspendRequested && threadPrimes.ThreadState != ThreadState.Suspended)
            {
                threadPrimes.Suspend();
            }

        }

        private void btnPrimesUnfreeze_Click(object sender, EventArgs e)
        {
            if (threadPrimes != null && threadPrimes.IsAlive && threadPrimes.ThreadState == ThreadState.Suspended)
            {
                threadPrimes.Resume();
            }

        }

        private void btnPrimesStop_Click(object sender, EventArgs e)
        {
            if (threadPrimes != null && threadPrimes.IsAlive)
            {
                if(threadPrimes.ThreadState == ThreadState.Suspended) threadPrimes.Resume();
                threadPrimes.Abort();
                btnPrimesStop.BackColor = Color.Coral;
            }
        }
#endregion

#region Fibonacci numbers
        private void btnFibonacciStart_Click(object sender, EventArgs e)
        {
            btnFibonacciStart.Enabled = false;
            FibonacciGenerator gen = new FibonacciGenerator() { };
            gen.NextFibonacci += Gen_NextFibonacci;
            gen.Finished += Fibonacci_Finished;
            threadFibon = new Thread(gen.GenerateFibonacciNumbers);
            threadFibon.Start();
        }

        private void Fibonacci_Finished()
        {
            MessageBox.Show("Fibonacci numbers generator finished");
            btnFibonacciStop.BackColor = Color.Coral;
            threadFibon.Abort();
        }

        private void Gen_NextFibonacci(long obj)
        {
            Action a = () =>
            {
                if(threadFibon != null)
                lbFibonacci.Items.Add(obj);
            };
            if (InvokeRequired)
                Invoke(a);
            else
                a();
        }

        private void btnFibonacciFreeze_Click(object sender, EventArgs e)
        {
            if (threadFibon != null && threadFibon.IsAlive && threadFibon.ThreadState != ThreadState.SuspendRequested && threadFibon.ThreadState != ThreadState.Suspended)
            {
                threadFibon.Suspend();
            }
        }

        private void btnFibonacciStop_Click(object sender, EventArgs e)
        {
            if (threadFibon != null && threadFibon.IsAlive)
            {
                if(threadFibon.ThreadState == ThreadState.Suspended) threadFibon.Resume();
                threadFibon.Abort();
                btnFibonacciStop.BackColor = Color.Coral;
            }
        }

        private void btnFibonacciUnfreeze_Click(object sender, EventArgs e)
        {
            if (threadFibon != null && threadFibon.IsAlive && threadFibon.ThreadState == ThreadState.Suspended)
            {
                threadFibon.Resume();
            }
        }

        private void btnFibonacciReset_Click(object sender, EventArgs e)
        {
            if (threadFibon == null) return;
            if (threadFibon.IsAlive) btnFibonacciStop_Click(null, null);
            btnFibonacciStart.Enabled = true;
            lbFibonacci.Items.Clear();
            btnFibonacciStop.BackColor = Color.White;
            threadFibon = null;
        }
#endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnPrimesStop_Click(null, null);
            btnFibonacciStop_Click(null, null);
        }
    }
}

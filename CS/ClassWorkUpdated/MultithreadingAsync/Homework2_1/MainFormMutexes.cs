using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Homework2_1
{
    public partial class MainFormMutexes : Form
    {
        public MainFormMutexes()
        {
            string assemblyName = Marshal.GetTypeLibGuidForAssembly(Assembly.GetExecutingAssembly()).ToString();
            bool created;
            Mutex extMutex = new Mutex(true, assemblyName, out created);
            if (created)
            {
                Console.WriteLine("First instance of application");
            }
            else
            {
                MessageBox.Show("Such app is already running!");
                Environment.Exit(0);
            }
            InitializeComponent();
            this.GenerationFinished += GenerationStopped;
        }

        private void GenerationStopped()
        {
            Action a = () =>
            {
                lblState.Text = "Finished";
                didGenerateFiles = true;
                btnPerformOperations.Enabled = true;
            };
            if (InvokeRequired) Invoke(a);
            else a();
        }

        private bool didGenerateFiles = false;
        private event Action GenerationFinished;


        private void btnPerformOperations_Click(object sender, EventArgs e)
        {
            Reset();
            Thread threadGenerate = new Thread(GenerateRandomNumbers);
            Thread threadPickPrimes = new Thread(PickPrimeNumbers);
            Thread threadPickSevens = new Thread(PickEndingWith7);
            Thread threadAnalysis = new Thread(PerformAnalysis);
            threadGenerate.Start();
            threadPickPrimes.Start();
            threadPickSevens.Start();
            threadAnalysis.Start();
        }

        private void Reset()
        {
            didGenerateFiles = false;
            btnPerformOperations.Enabled = false;
            lblState.Text = "Running";
            Mutex mut;
            if (Mutex.TryOpenExisting("mutexGenerateNumbers", out mut)) mut.Close();
            if (Mutex.TryOpenExisting("mutexPrimeNumbers", out mut)) mut.Close();
            if (Mutex.TryOpenExisting("mutexPrimeNumbersEnding7", out mut)) mut.Close();
        }

        private void GenerateRandomNumbers()
        {
            Mutex mutexGenerateNumbers = new Mutex(false, "mutexGenerateNumbers");
            mutexGenerateNumbers.WaitOne();
            Random rnd = new Random();
            using (StreamWriter writer = new StreamWriter("InitialNumbers.txt"))
            {
                for (int i = 0; i < rnd.Next(50, 201); i++)
                {
                    writer.WriteLine(rnd.Next(10, 1001).ToString());
                }
            }
            mutexGenerateNumbers.ReleaseMutex();
        }

        private void PickPrimeNumbers()
        {
            Mutex mut;
            while (!Mutex.TryOpenExisting("mutexGenerateNumbers", out mut))
            {
                Thread.Sleep(1000);
            }
            mut.WaitOne();
            Mutex mutexPrimeNumbers = new Mutex(false, "mutexPrimeNumbers");
            mutexPrimeNumbers.WaitOne();
            List<int> initialNumbers = (from n in File.ReadAllLines("InitialNumbers.txt") select int.Parse(n)).ToList();
            using (StreamWriter writer = new StreamWriter("PrimeNumbers.txt"))
            {
                for (int i = 0; i < initialNumbers.Count; i++)
                {
                    if (initialNumbers[i].IsPrime()) writer.WriteLine(initialNumbers[i].ToString());
                }
            }
            mutexPrimeNumbers.ReleaseMutex();
            mut.ReleaseMutex();
        }

        private void PickEndingWith7()
        {
            Mutex mut;
            while (!Mutex.TryOpenExisting("mutexPrimeNumbers", out mut))
            {
                Thread.Sleep(1000);
            }
            mut.WaitOne();
            Mutex mutexPrimeNumbersEnding7 = new Mutex(false, "mutexPrimeNumbersEnding7");
            mutexPrimeNumbersEnding7.WaitOne();
            List<int> primeNumbers = (from n in File.ReadAllLines("PrimeNumbers.txt") select int.Parse(n)).ToList();
            using (StreamWriter writer = new StreamWriter("PrimeNumbersEnding7.txt"))
            {
                for (int i = 0; i < primeNumbers.Count; i++)
                {
                    if (primeNumbers[i] % 10 == 7) writer.WriteLine(primeNumbers[i].ToString());
                }
            }
            mutexPrimeNumbersEnding7.ReleaseMutex();
            mut.ReleaseMutex();
        }

        private void PerformAnalysis()
        {
            Mutex mut;
            while (!Mutex.TryOpenExisting("mutexPrimeNumbersEnding7", out mut))
            {
                Thread.Sleep(1000);
            }
            mut.WaitOne();
            string[] initialNumbers = File.ReadAllLines("InitialNumbers.txt");
            string[] primeNumbers = File.ReadAllLines("PrimeNumbers.txt");
            string[] primeNumbersWith7 = File.ReadAllLines("PrimeNumbersEnding7.txt");
            using (StreamWriter writer = new StreamWriter("Analysis.txt"))
            {
                writer.WriteLine("Original array:");
                for (int i = 0; i < initialNumbers.Length; i++)
                {
                    writer.WriteLine(initialNumbers[i]);
                }
                writer.WriteLine("------------------------------------------");
                writer.WriteLine("Array with only primes:");
                for (int i = 0; i < primeNumbers.Length; i++)
                {
                    writer.WriteLine(primeNumbers[i]);
                }
                writer.WriteLine("------------------------------------------");
                writer.WriteLine("Array with only primes ending with 7:");
                for (int i = 0; i < primeNumbersWith7.Length; i++)
                {
                    writer.WriteLine(primeNumbersWith7[i]);
                }
                writer.WriteLine("------------------------------------------");
                writer.WriteLine($"Initial array: {initialNumbers.Length} items");
                writer.WriteLine($"Primes array: {primeNumbers.Length} items");
                writer.WriteLine($"Primes ending in 7 array: {primeNumbersWith7.Length} items");
                writer.WriteLine("------------------------------------------");
                FileInfo initInfo = new FileInfo("InitialNumbers.txt");
                FileInfo primesInfo = new FileInfo("PrimeNumbers.txt");
                FileInfo primes7Info = new FileInfo("PrimeNumbersEnding7.txt");
                writer.WriteLine($"Size of init file: {initInfo.Length} bytes");
                writer.WriteLine($"Size of file with primes: {primesInfo.Length} bytes");
                writer.WriteLine($"Size of file with primes ending in 7: {primes7Info.Length} bytes");
            }
            GenerationFinished?.Invoke();
            mut.ReleaseMutex();
        }

        private void OpenFile(string path) 
        {
            if (didGenerateFiles) Process.Start(path);
        }

        private void btnOpenInit_Click(object sender, EventArgs e)
        {
            OpenFile("InitialNumbers.txt");
        }

        private void btnOpenPrimes_Click(object sender, EventArgs e)
        {
            OpenFile("PrimeNumbers.txt");
        }

        private void btnOpenPrimes7_Click(object sender, EventArgs e)
        {
            OpenFile("PrimeNumbersEnding7.txt");
        }

        private void btnOpenAnalysis_Click(object sender, EventArgs e)
        {
            OpenFile("Analysis.txt");
        }
    }
}

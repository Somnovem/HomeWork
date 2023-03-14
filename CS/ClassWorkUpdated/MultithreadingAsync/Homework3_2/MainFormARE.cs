using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3__
{
    public partial class MainFormARE : Form
    {
        private static AutoResetEvent are;
        public delegate void ActionFinishedEvent();
        public event ActionFinishedEvent ActionFinished;
        private bool didGenerateFiles = false;
        public MainFormARE()
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
            this.ActionFinished += MainFormARE_ActionFinished;
        }

        private void MainFormARE_ActionFinished()
        {
            Action a = () =>
            {
                lblState.Text = "Finished";
                btnRunFileOperation.Enabled = true;
                didGenerateFiles = true;
            };
            if (InvokeRequired) Invoke(a);
            else a();
        }
        private void VisualizeStart()
        {
            lblState.Text = "Running";
            btnRunFileOperation.Enabled = false;
            didGenerateFiles = false;
        }
        private void btnRunFileOperation_Click(object sender, EventArgs e)
        {
            are = new AutoResetEvent(false);
            Thread threadPairs = new Thread(GeneratePairsFile);
            Thread threadSums = new Thread(GenerateSumFile);
            Thread threadProducts = new Thread(GenerateProductFile);
            threadPairs.Start();
            VisualizeStart();
            threadProducts.Start();
            threadSums.Start();
        }
        private void GeneratePairsFile() 
        {
            are.Set();
            are.WaitOne();
            int pairsCount = (int)edPairsCount.Value;
            Random rng = new Random();
            using (StreamWriter writer = new StreamWriter("Pairs.txt"))
            {
                for (int i = 0; i < pairsCount; i++)
                {
                    writer.WriteLine($"{rng.Next(1,1000)};{rng.Next(1, 1000)}");
                }
            }
            are.Set();
        }
        private void GenerateSumFile()
        {
            are.WaitOne();
            using (StreamReader reader = new StreamReader("Pairs.txt"))
            {
                int num1,num2;
                string str;
                using (StreamWriter writer = new StreamWriter("Sums.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        str = reader.ReadLine();
                        var temp = str.Split(';');
                        num1 = Convert.ToInt32(temp[0]);
                        num2 = Convert.ToInt32(temp[1]);
                        writer.WriteLine($"{num1 + num2}");
                    }
                }
            }
            are.Set();
        }
        private void GenerateProductFile()
        {
            are.WaitOne();
            using (StreamReader reader = new StreamReader("Pairs.txt"))
            {
                int num1, num2;
                string str;
                using (StreamWriter writer = new StreamWriter("Products.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        str = reader.ReadLine();
                        var temp = str.Split(';');
                        num1 = Convert.ToInt32(temp[0]);
                        num2 = Convert.ToInt32(temp[1]);
                        writer.WriteLine($"{num1 * num2}");
                    }
                }
            }
            are.Set();
            ActionFinished?.Invoke();
        }
        private void OpenFile(string path)
        {
            if (didGenerateFiles) Process.Start(path);
        }

        private void btnOpenPairsFile_Click(object sender, EventArgs e)
        {
            OpenFile("Pairs.txt");
        }

        private void btnOpenSumFile_Click(object sender, EventArgs e)
        {
            OpenFile("Sums.txt");
        }

        private void btnOpenProductFile_Click(object sender, EventArgs e)
        {
            OpenFile("Products.txt");
        }
    }
}

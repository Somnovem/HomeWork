using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SpPractice3_1WinForms
{
    public partial class MainFormPractice3_1 : Form
    {
        public MainFormPractice3_1()
        {
            InitializeComponent();
        }
        private bool isRanged = false;

        private void Iterate(FunctionIterator func)
        {
            func.EndIterating += Func_EndIterating;
            Thread thread = new Thread(func.Iterate);
            thread.Start();
        }

        private void btnIterateStandart_Click(object sender, EventArgs e)
        {
            FunctionIterator func = new FunctionIterator();
            Iterate(func);
            lbIterateStandart.Items.Clear();
        }

        private void btnIterateRanged_Click(object sender, EventArgs e)
        {
            int start = (int)edRangeStart.Value;
            int end = (int)edRangeEnd.Value;
            int gap = end - start;
            if (gap <= 0) 
            {
                MessageBox.Show("Invalid input");
                return;
            }
            int threadsCount = (int)edThreadsCount.Value;
            int step = gap / threadsCount;
            lbIterateRanged.Items.Clear();
            while ((start+step)<end)
            {
                isRanged = true;
                FunctionIterator func = new FunctionIterator() { Start = start, End = (start + step) };
                Iterate(func);
                start += step;
            }
            FunctionIterator funcEnd = new FunctionIterator() { Start = start, End = end };
            Iterate(funcEnd);

        }

        private void Func_EndIterating(FunctionIterator func)
        {
            ListBox listBox = (isRanged) ? lbIterateRanged  : lbIterateStandart;
            Action a = () =>
            {
                for (int i = 0; i < func.Res.Count; i++)
                {
                    listBox.Items.Add(func.Res[i]);
                }
            };
            if (InvokeRequired)
                Invoke(a);
            else
                a();
            isRanged = false;
        }

        private static void PrintListResult(object list)
        {
            List<int> nums = list as List<int>;
            using (StreamWriter file = new StreamWriter("analyze.txt"))
            {
                foreach (var item in nums)
                {
                    file.WriteLine(item);
                }
            }
            Thread threadMax = new Thread(FindMaximum);
            threadMax.Start(nums);
            threadMax.Join();
            Thread threadMin = new Thread(FindMinimum);
            threadMin.Start(nums);
            threadMin.Join();
            Thread threadAvg = new Thread(FindAverage);
            threadAvg.Start(nums);
            threadAvg.Join();
        }

        private static void FindMaximum(object list)
        {
            List<int> nums = list as List<int>;
            int max = nums.Max();
            using (StreamWriter file = new StreamWriter("analyze.txt", true))
            {
                file.WriteLine($"Maximum: {max}");
            }
        }
        private static void FindMinimum(object list)
        {
            List<int> nums = list as List<int>;
            int min = nums.Min();
            using (StreamWriter file = new StreamWriter("analyze.txt", true))
            {
                file.WriteLine($"Minimum: {min}");
            }
        }
        private static void FindAverage(object list)
        {
            List<int> nums = list as List<int>;
            double avg = nums.Average();
            using (StreamWriter file = new StreamWriter("analyze.txt", true))
            {
                file.WriteLine($"Average: {avg}");
            }
        }

        private void btnGenerateNumbers_Click(object sender, EventArgs e)
        {
            List<int> nums = new List<int>();
            Random r = new Random();
            for (int i = 0; i < 10000; i++)
            {
                nums.Add(r.Next(1, 100000));
            }
            Thread thread = new Thread(PrintListResult);
            thread.Start(nums);
            thread.Join();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (File.Exists("analyze.txt"))
            {
                Process.Start("notepad.exe", "analyze.txt");
            }
            else
            {
                MessageBox.Show("File doesn't yet exist");
            }
        }
    }
}

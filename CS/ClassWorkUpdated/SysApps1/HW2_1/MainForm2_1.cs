using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace HW2_1
{
    public partial class MainForm2_1 : Form
    {
        string path = @"..\..\..\HW2_1Child\bin\Debug\HW2_1Child.exe";
        Process process;
        public MainForm2_1()
        {
            InitializeComponent();
            cbMathSign.SelectedIndex = 0;
        }
        private void btnStartEmpty_Click(object sender, EventArgs e)
        {
            process = Process.Start(path);
            process.EnableRaisingEvents = true;
            process.Exited += Process_Exited;
        }

        private void Process_Exited(object sender, EventArgs e)
        {
            MessageBox.Show($"Child from ended with {process.ExitCode}");
        }

        private void StartChildWithParams(string parameters)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(this.path);
            startInfo.Arguments = parameters;
            startInfo.UseShellExecute = true;
            process = new Process();
            process.StartInfo = startInfo;
            process.EnableRaisingEvents = true;
            process.Exited += Process_Exited;
            process.Start();
        }

        private void btnStartMath_Click(object sender, EventArgs e)
        {
            decimal num1 = edMathFirst.Value;
            decimal num2 = edMathSecond.Value;
            decimal res = 0.0m;
            char sign = ((string)cbMathSign.SelectedItem)[0];
            switch (sign)
            {
                case '+':
                    res = num1 + num2;
                    break;
                case '-':
                    res = num1 - num2;
                    break;
                case '*':
                    res = num1 * num2;
                    break;
                case '/':
                    res = num1 / num2;
                    break;
                case '^':
                    res = (decimal)Math.Pow((double)num1, (double)num2);
                    break;
                default:
                    break;
            }
            StartChildWithParams($"{num1}{sign}{num2}={res} {0}");
        }

        private void btnStartFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edFileName.Text)) return;
            string path = edPath.Text;
            string fileName = edFileName.Text;
            int count = Directory.EnumerateFiles(path).Where(p => p.Contains(fileName)).Count();
            var subdirectories = Directory.EnumerateDirectories(path);
            foreach (var directory in subdirectories)
            {
                try
                {
                    count += Directory.EnumerateFiles(directory).Where(p => p.Contains(fileName)).Count();
                }
                catch 
                {
                    // do nothing(error - access denied )
                }

            }
            StartChildWithParams($"0+0=0 {count}");
        }

        private void btnKillChild_Click(object sender, EventArgs e)
        {
            if (process != null && !process.HasExited) 
            {
                process.Kill();
            }
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            if (folderDialog.ShowDialog() != DialogResult.OK) return;
            edPath.Text = folderDialog.SelectedPath;
        }
    }
}

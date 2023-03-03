using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SysApp3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FunctionCalc func = new FunctionCalc() 
            {
            StartX1 =(double) numericUpDown1.Value,
            StartX2 = (double)numericUpDown2.Value,
            Count = (uint)numericUpDown3.Value
            };
            func.EndCalculation += Func_EndCalculation;
            button1.Enabled = false;
            Thread thread = new Thread(func.Calculate);
            listBox1.Items.Clear();
            thread.Start();
        }

        private void Func_EndCalculation(FunctionCalc func, string msg)
        {
            MessageBox.Show($"Accept message: {msg}");
            Action a = () =>
            {
                for (int i = 0; i < func.Y.Count; i++)
                {
                    listBox1.Items.Add($"Y = {func.Y[i]}");
                }
                button1.Enabled = true;
            };
            if (InvokeRequired) 
                Invoke(a);
            else
                a();
        }
    }
}

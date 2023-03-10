using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice0803_WinForms
{
    public partial class MainFormMutex : Form
    {
        public MainFormMutex()
        {
            InitializeComponent();
            MainFormMutex.Finished += Counting_Finished;
        }
        #region Task 1
        private void Counting_Finished(List<int> list)
        {
            Action a = () =>
            {
                foreach (var item in list)
                {
                    lbCounter.Items.Add(item);
                }
            };
            if (InvokeRequired) Invoke(a);
            else a();
        }

        private static Mutex mutexAscending;
        private static event Action<List<int>> Finished;
        private static void NumsAscending()
        {
            List<int> list = new List<int>();
            mutexAscending.WaitOne();
            for (int i = 0; i < 21; i++)
            {
                list.Add(i);
            }
            Finished.Invoke(list);
            mutexAscending.ReleaseMutex();
        }
        private static void NumsDescending()
        {
            Mutex mut;
            while (!Mutex.TryOpenExisting("mutexAscending", out mut))
            {
                Thread.Sleep(1000);
            }
            mut.WaitOne();
            List<int> list = new List<int>();
            for (int i = 10; i >= 0; i--)
            {
                list.Add(i);
            }
            Finished.Invoke(list);
            mut.ReleaseMutex();
        }
        private void btnOperationGenerate_Click(object sender, EventArgs e)
        {
            lbCounter.Items.Clear();
            mutexAscending = new Mutex(false, "mutexAscending");
            Thread threadAsc = new Thread(NumsAscending);
            Thread threadDesc = new Thread(NumsDescending);
            threadAsc.Start();
            threadDesc.Start();
            btnOperationGenerate.Enabled = false;
        }

        #endregion

        #region Task2
        private static Mutex mutexFill;
        private static List<int> list;
        private static int max;

        private static void FillAraay()
        {
            mutexFill.WaitOne();
            Random rnd = new Random();
            for (int i = 0; i < rnd.Next(10, 101); i++)
            {
                list.Add(rnd.Next(0, 501));
            }
            mutexFill.ReleaseMutex();
        }
        private static void IncreaseArray()
        {
            Mutex mutexIncrease = new Mutex(false, "mutexIncreaseArray");
            mutexIncrease.WaitOne();
            Mutex mut;
            while (!Mutex.TryOpenExisting("mutexFillArray", out mut))
            {
                Thread.Sleep(1000);
            }
            mut.WaitOne();
            int ampl = new Random().Next(1, 11);
            for (int i = 0; i < list.Count; i++)
            {
                list[i] += ampl;
            }
            mutexIncrease.ReleaseMutex();
            mut.ReleaseMutex();
        }
        private static void FindMax()
        {
            Mutex mutexFindMax = new Mutex(false, "mutexFindMax");
            mutexFindMax.WaitOne();
            Mutex mut;
            while (!Mutex.TryOpenExisting("mutexIncreaseArray", out mut))
            {
                Thread.Sleep(1000);
            }
            mut.WaitOne();
            max = list.Max();
            mut.ReleaseMutex();
            mutexFindMax.ReleaseMutex();
        }
        private void brnOperationArray_Click(object sender, EventArgs e)
        {
            lbArray.Items.Clear();
            list = new List<int>();
            mutexFill = new Mutex(false, "mutexFillArray");
            Thread threadFill = new Thread(FillAraay);
            Thread threadIncrease = new Thread(IncreaseArray);
            Thread threadMax = new Thread(FindMax);

            threadFill.Start();
            threadIncrease.Start();
            threadMax.Start();
            Mutex mut;
            while (!Mutex.TryOpenExisting("mutexFindMax", out mut))
            {

            }

            mut.WaitOne();
            foreach (var item in list)
            {
                lbArray.Items.Add(item);
            }
            edMax.Value = max;
            btnOperationArray.Enabled = false;
            mut.ReleaseMutex();

        }

        #endregion

    }
}

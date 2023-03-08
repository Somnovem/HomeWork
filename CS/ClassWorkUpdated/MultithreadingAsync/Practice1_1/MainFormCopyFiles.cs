using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using ThreadState = System.Threading.ThreadState;
using System.IO;
using System.Threading.Tasks;
using Practice1_1.Properties;
using System.Runtime.InteropServices;

namespace Practice1_1
{
    public partial class MainFormCopyFiles : Form
    {
        public MainFormCopyFiles()
        {
            InitializeComponent();
        }

        int progress = 0;


        private void btnAddFile_Click(object sender, EventArgs e)
        {
            if(fileSearch.ShowDialog() != DialogResult.OK)return;
            foreach (var filename in fileSearch.FileNames)
            {
                if (lbFiles.Items.Contains(filename))
                {
                    MessageBox.Show($"This file is already in queue: {filename}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }
                lbFiles.Items.Add(filename);
            }
        }

        private void btnRemoveSelectedFile_Click(object sender, EventArgs e)
        {
            if (lbFiles.SelectedItems.Count == 0) return;
            lbFiles.Items.RemoveAt(lbFiles.SelectedIndex);
        }

        private void btnClearListFiles_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to clear the list?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            lbFiles.Items.Clear();
            usedCopynators = null;
        }

        private void btnDestinFolder_Click(object sender, EventArgs e)
        {
            if (folderSearch.ShowDialog() != DialogResult.OK) return;
            edDestination.Text = folderSearch.SelectedPath;
        }
        List<CopyHolder> usedCopynators;
        private void btnCopyStart_Click(object sender, EventArgs e)
        {
            if (lbFiles.Items.Count == 0) return;
            usedCopynators = new List<CopyHolder>();
            progress = 0;
            edProgress.Value = 0;
            int threadCount = (int)edThreadsCount.Value;
            int fileCount = lbFiles.Items.Count;
            int step = fileCount/threadCount;
            if (step == 0)
            {
                MessageBox.Show("Too much threads for this number of files");
                return;
            }
            string destination = edDestination.Text;
            int current = 0;
            while (current + step < fileCount-1)
            {
                CopyHolder holder = new CopyHolder() { Sources = lbFiles.Items.Cast<string>().Skip(current).Take(step).ToArray(), Destination = destination,SimulateHardProcess = cbSimulation.Checked };
                holder.Finished += Holder_Finished;
                usedCopynators.Add(holder);
                current += step;
            }
            CopyHolder lastHolder = new CopyHolder() { Sources = lbFiles.Items.Cast<string>().Skip(current).ToArray(), Destination = destination, SimulateHardProcess = cbSimulation.Checked };
            lastHolder.Finished += Holder_Finished;
            usedCopynators.Add(lastHolder);
            foreach (var item in usedCopynators)
            {
                item.StartWork();
            }
            lblState.Text = "Running";
        }

        private void Holder_Finished(int res)
        {
            Action a = () =>
            {
                progress += res;
                edProgress.Value = (progress / lbFiles.Items.Count) * 100;
            };
            if (InvokeRequired)
                Invoke(a);
            else
                a();
        }

        private void btnCopyAbort_Click(object sender, EventArgs e)
        {
            if (usedCopynators == null) return;
            foreach (var item in usedCopynators)
            {
                item.AbortWork();
            }
            lblState.Text = "Aborted";
        }

        private void btnCopyFreeze_Click(object sender, EventArgs e)
        {
            if (usedCopynators == null) return;
            foreach (var item in usedCopynators)
            {
                item.FreezeWork();
            }
            lblState.Text = "Frozen";
        }

        private void btnCopyResume_Click(object sender, EventArgs e)
        {
            if (usedCopynators == null) return;
            foreach (var item in usedCopynators)
            {
                item.ResumeWork();
            }
            lblState.Text = "Running";
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start(edDestination.Text);
        }

        private void MainFormCopyFiles_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnCopyAbort_Click(null, null);
        }
    }
}

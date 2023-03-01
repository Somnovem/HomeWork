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
namespace SysAppPractice2_1
{
    public partial class MainFormPractice2_1 : Form
    {
        public MainFormPractice2_1()
        {
            InitializeComponent();

            dgvProcess.MultiSelect = false;
            dgvProcess.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProcess.ReadOnly = true;

            FileDialogProcess.InitialDirectory = "C:";

            timerProcess.Interval = (int)edTimerSeconds.Value * 1000;
            timerProcess.Tick += TimerProcess_Tick;
            timerProcess.Start();

        }

        private void UpdateDgv() 
        {
            dgvProcess.DataSource = null;
            dgvProcess.DataSource = Process.GetProcesses().Select(p => new { Id = p.Id, StartTime = DateTime.Now, SpentTime = 0, ThreadsCount = p.Threads.Count, CopiesCount = Process.GetProcesses().Count(c => c.ProcessName == p.ProcessName), Process = p }).ToList();
            dgvProcess.Columns["Process"].Visible = false;
        }

        private void TimerProcess_Tick(object sender, EventArgs e)
        {
            UpdateDgv();
        }

        private void btnChangeUpdate_Click(object sender, EventArgs e)
        {
            timerProcess.Stop();
            timerProcess.Interval = (int)edTimerSeconds.Value * 1000;
            timerProcess.Start();
        }

        private void dgvProcess_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //do nothing
        }

        private void btnKillProcess_Click(object sender, EventArgs e)
        {
            if (dgvProcess.SelectedRows.Count == 0) return;
            DataGridViewRow row = dgvProcess.SelectedRows[0];
            var p = row.Cells["Process"].Value as Process;
            if (p == null) return;
            p.Kill();
            UpdateDgv();
        }
        private void ExecuteApplication(string path)
        {
            Process p = Process.Start(path);
        }

        private void btnRunPaint_Click(object sender, EventArgs e)
        {
            ExecuteApplication("c:\\windows\\system32\\mspaint.exe");
        }

        private void btnRunCalc_Click(object sender, EventArgs e)
        {
            ExecuteApplication("c:\\windows\\system32\\calc.exe");
        }

        private void btnRunNotepad_Click(object sender, EventArgs e)
        {
            ExecuteApplication("c:\\windows\\system32\\notepad.exe");
        }

        private void btnRunPersonal_Click(object sender, EventArgs e)
        {
            if(FileDialogProcess.ShowDialog() == DialogResult.OK) ExecuteApplication(FileDialogProcess.FileName);
        }
    }
}

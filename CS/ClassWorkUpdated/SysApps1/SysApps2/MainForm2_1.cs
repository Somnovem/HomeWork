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
using System.Management;
using System.Runtime.InteropServices;

namespace SysApps2
{
    public partial class MainForm2_1 : Form
    {
        public MainForm2_1()
        {
            InitializeComponent();
            dgvProcess.MultiSelect = false;
            dgvProcess.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnGetPocesses_Click(object sender, EventArgs e)
        {
            //Process process = Process.GetCurrentProcess(); // вставляет в него процесс из которого был вызван
            dgvProcess.DataSource = Process.GetProcesses().Select(p => new{p.ProcessName,p.MainWindowTitle,p.Id,p.Threads.Count,p.BasePriority,Process = p })
                                    .OrderBy(p => p.ProcessName).ToList();
            dgvProcess.Columns["Process"].Visible = false;
        }

        private void dgvProcess_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //чтобы проблема не возникала из-за доступа
        }

        private void btnKillProcess_Click(object sender, EventArgs e)
        {
            if (dgvProcess.SelectedRows.Count == 0) return;
            DataGridViewRow row = dgvProcess.SelectedRows[0];
            var p = row.Cells["Process"].Value as Process;
            if (p != null) {
                p.Kill();
                btnGetPocesses_Click(null, null);
            }
        }

        private void btnProcessRun_Click(object sender, EventArgs e)
        {
            dlgOpen.InitialDirectory = "C:";
            if (dlgOpen.ShowDialog() == DialogResult.OK) 
            {
                Process p = Process.Start(dlgOpen.FileName);
                if (Process.GetCurrentProcess().Id == GetParentProcessId(p.Id)) 
                {
                    p.EnableRaisingEvents = true; //включить обработку событий в процессе
                    p.Exited += Process_Exited;
                    SetChildWindowText(p.MainWindowHandle, "Child process");
                    MessageBox.Show("Child process","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Not child process", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Process_Exited(object sender, EventArgs e)
        {
            MessageBox.Show("Process ended", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private int GetParentProcessId(int Id) 
        {
            int parentId = 0;
            using (ManagementObject obj = new ManagementObject("win32_process.handle="+Id.ToString()))
            {
                obj.Get();
                parentId = Convert.ToInt32(obj["ParentProcessId"]);
            }
            return parentId;
        }

        const uint WM_SETTEXT = 0x0C;

        [DllImport("user32.dll",SetLastError =true,CharSet =CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool SetWindowText(IntPtr hwnd, String lpString);

        private void SetChildWindowText(IntPtr hWnd, string text) 
        {
            // SendMessage(hWnd, WM_SETTEXT, 0, text);
            SetWindowText(hWnd, text);
        }
    }
}

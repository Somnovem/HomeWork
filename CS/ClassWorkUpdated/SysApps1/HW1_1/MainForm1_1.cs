using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1_1
{
    public partial class MainForm1_1 : Form
    {
        string caption;
        bool captionLocked;
        public MainForm1_1()
        {
            InitializeComponent();
            MainFormSettings wnd = new MainFormSettings();
            wnd.Show();
            caption = this.Text;
            edColor.ReadOnly = true;
            edTitle.ReadOnly = true;
        }

        private void btnPersonalInMessageBoxes_Click(object sender, EventArgs e)
        {
            FunctionsExt.MessageBox(IntPtr.Zero, "Name: Zhmura Artem", "Info", FunctionsExt.MB_OK | FunctionsExt.MB_ICONQUESTION);
            DateTime birth = new DateTime();
            birth = birth.AddYears(2005);
            birth = birth.AddMonths(7);
            birth = birth.AddDays(2);
            FunctionsExt.MessageBox(IntPtr.Zero, $"Birth: {birth.ToShortDateString()}", "Info", FunctionsExt.MB_OK | FunctionsExt.MB_ICONQUESTION);
            FunctionsExt.MessageBox(IntPtr.Zero, "Nationality: Ukrainian", "Info", FunctionsExt.MB_OK | FunctionsExt.MB_ICONQUESTION);
        }

        private void btnChangeCaption_Click(object sender, EventArgs e)
        {
            if (captionLocked) return;
            if (string.IsNullOrEmpty(edCaption.Text)) 
            {
                FunctionsExt.MessageBox(IntPtr.Zero, "Can't change caption to empty", "Warning", FunctionsExt.MB_OK | FunctionsExt.MB_ICONWARNING);
                return;
            }
            
            IntPtr handle = FunctionsExt.FindWindow(null, caption);
            caption = edCaption.Text;
            FunctionsExt.SetWindowText(handle, caption);
        }

        private void btnSendClose_Click(object sender, EventArgs e)
        {
            IntPtr handle = FunctionsExt.FindWindow(null, caption);
            FunctionsExt.SendMessage(handle, FunctionsExt.WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
        }

        private void btnRandomNumber_Click(object sender, EventArgs e)
        {
            if (captionLocked) return;
            int num = new Random().Next(0, 101);
            IntPtr handle = FunctionsExt.FindWindow(null, caption);
            caption = num.ToString();
            FunctionsExt.SendMessage(handle, FunctionsExt.WM_SETTEXT, IntPtr.Zero, caption);
        }

        private void btnSetTimer_Click(object sender, EventArgs e)
        {
            int num = (int)edTimer.Value;
            IntPtr handle = FunctionsExt.FindWindow(null, caption);
            captionLocked = true;
            while (num > 0)
            {
                caption = num.ToString();
                FunctionsExt.SendMessage(handle, FunctionsExt.WM_SETTEXT, IntPtr.Zero, caption);
                num--;
                System.Threading.Thread.Sleep(1000);
            }
            captionLocked = false;
            FunctionsExt.MessageBox(IntPtr.Zero, "Time is up!", "Info", FunctionsExt.MB_OK | FunctionsExt.MB_ICONEXCLAMATION);
        }

        private void btnChime_Click(object sender, EventArgs e)
        {
            List<BeepType> order = new List<BeepType>() { BeepType.SimpleBeep, BeepType.Question, BeepType.Exclamation, BeepType.OK, BeepType.OK, BeepType.SimpleBeep };
            Random r = new Random();
            foreach (BeepType beep in order)
            {
                FunctionsExt.MessageBeep(beep);
                System.Threading.Thread.Sleep(r.Next(500,1000));
            }
        }

        private void edColor_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edColor.Text)) return;
            this.BackColor = Color.FromName(edColor.Text);
        }
    }
}

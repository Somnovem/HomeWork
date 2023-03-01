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
    public partial class MainFormSettings : Form
    {
        string colorCaption = "White";
        string titleCaption = "Greetings!";
        string editClass = "WindowsForms10.EDIT.app.0.141b42a_r8_ad1";
        IntPtr windowHandle;
        IntPtr colorHandle;
        IntPtr titleHandle;
        public MainFormSettings()
        {
            InitializeComponent();
        }

        private void btnSettingColor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edSettingColor.Text)) return;
            if (windowHandle == IntPtr.Zero) windowHandle = FunctionsExt.FindWindow(null, "SP-Homework1_1");
            if (colorHandle == IntPtr.Zero) colorHandle = FunctionsExt.FindWindowEx(windowHandle, IntPtr.Zero, editClass, colorCaption);
            FunctionsExt.SendMessage(colorHandle, FunctionsExt.WM_SETTEXT,IntPtr.Zero,edSettingColor.Text);
        }

        private void btnSettingTitle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edSettingTitle.Text)) return;
            if (windowHandle == IntPtr.Zero) windowHandle = FunctionsExt.FindWindow(null, "SP-Homework1_1");
            if (titleHandle == IntPtr.Zero) titleHandle = FunctionsExt.FindWindowEx(windowHandle, IntPtr.Zero, editClass, titleCaption);
            FunctionsExt.SendMessage(titleHandle, FunctionsExt.WM_SETTEXT, IntPtr.Zero, edSettingTitle.Text);
        }
    }
}

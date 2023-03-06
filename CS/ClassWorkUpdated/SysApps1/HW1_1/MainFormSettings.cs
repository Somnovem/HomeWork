using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace HW1_1
{
    public partial class MainFormSettings : Form
    {
        private string[] vStylesClass;
        private string[] vStylesStandart;
        private string[] vStylesExtended;
        IntPtr handle;
        public MainFormSettings()
        {
            InitializeComponent();
            vStylesClass = Enum.GetNames(typeof(ClassStyles));
            vStylesStandart = Enum.GetNames(typeof(WS));
            vStylesExtended = Enum.GetNames(typeof(EWS));
            GetStylesWnd();
        }

        /// <summary>
        /// Update lists
        /// </summary>
        /// <param name="updateClass">Update first listbox</param>
        /// <param name="updateStandart">Update second listbox</param>
        /// <param name="updateEx">Update third listbox</param>
        private void GetStylesWnd(bool updateClass = true, bool updateStandart = true, bool updateEx = true)
        {
            if(handle == IntPtr.Zero)handle = FunctionsExt.FindWindow(null, "SP-Homework1_1");
            var style = (uint)FunctionsExt.GetWindowLongPtr(handle, (int)WindowLongFlags.GWL_STYLE);
            if (updateClass) 
            {
                lbClassStyles.Items.Clear();
                for (int i = 0; i < vStylesClass.Length; i++)
                {
                    var v = (ClassStyles)Enum.Parse(typeof(ClassStyles), vStylesClass[i]);
                    uint code = (uint)v;
                    string res = v.ToString();
                    res += (code & style) == code ? " = On" : " = Off";
                    lbClassStyles.Items.Add(res);
                }
            }
            if (updateStandart)
            {
                lbStandartStyles.Items.Clear();
                for (int i = 0; i < vStylesStandart.Length; i++)
                {
                    var v = (WS)Enum.Parse(typeof(WS), vStylesStandart[i]);
                    uint code = (uint)v;
                    string res = v.ToString();
                    res += (code & style) == code ? " = On" : " = Off";
                    lbStandartStyles.Items.Add(res);
                }
            }
            if (updateEx)
            {
                lbExtendedStyles.Items.Clear();
                for (int i = 0; i < vStylesExtended.Length; i++)
                {
                    var v = (EWS)Enum.Parse(typeof(EWS), vStylesExtended[i]);
                    uint code = (uint)v;
                    string res = v.ToString();
                    res += (code & style) == code ? " = On" : " = Off";
                    lbExtendedStyles.Items.Add(res);
                }
            }
        }

        private void lbClassStyles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbClassStyles.SelectedIndex == ListBox.NoMatches) return;
            ClassStyles item = (ClassStyles)Enum.Parse(typeof(ClassStyles), vStylesClass[lbClassStyles.SelectedIndex]);
            IntPtr res = FunctionsExt.GetWindowLongPtr(handle, (int)WindowLongFlags.GWL_STYLE);
            uint code = (uint)res;
            uint newCode = code ^ (uint)item;
            IntPtr newRes = FunctionsExt.SetWindowLongPtr(handle, (int)WindowLongFlags.GWL_STYLE, (IntPtr)newCode);
            GetStylesWnd(true, false, false);
        }

        private void lbStandartStyles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbStandartStyles.SelectedIndex == ListBox.NoMatches) return;
            WS item = (WS)Enum.Parse(typeof(WS), vStylesStandart[lbStandartStyles.SelectedIndex]);
            IntPtr res = FunctionsExt.GetWindowLongPtr(handle, (int)WindowLongFlags.GWL_STYLE);
            uint code = (uint)res;
            uint newCode = code ^ (uint)item;
            IntPtr newRes = FunctionsExt.SetWindowLongPtr(handle, (int)WindowLongFlags.GWL_STYLE, (IntPtr)newCode);
            GetStylesWnd(false, true, false);
        }

        private void lbExtendedStyles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbExtendedStyles.SelectedIndex == ListBox.NoMatches) return;
            EWS item = (EWS)Enum.Parse(typeof(EWS), vStylesExtended[lbExtendedStyles.SelectedIndex]);
            IntPtr res = FunctionsExt.GetWindowLongPtr(handle, (int)WindowLongFlags.GWL_STYLE);
            uint code = (uint)res;
            uint newCode = code ^ (uint)item;
            IntPtr newRes = FunctionsExt.SetWindowLongPtr(handle, (int)WindowLongFlags.GWL_STYLE, (IntPtr)newCode);
            GetStylesWnd(false, false, true);
        }

        /// <summary>
        /// Ignore closing the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFormSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}

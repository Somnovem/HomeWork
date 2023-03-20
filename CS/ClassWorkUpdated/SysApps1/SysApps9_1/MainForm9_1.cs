using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SysApps9_1
{
    public partial class MainForm9_1 : Form
    {
        public MainForm9_1()
        {
            InitializeComponent();
            ShowInTaskbar = false;
            FormClosing += MainForm9_1_FormClosing;
        }

        private void MainForm9_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hookKeyboard != IntPtr.Zero)
                ExtClasses.UnhookWindowsHookEx(hookKeyboard);
            if (hookMouse != IntPtr.Zero)
                ExtClasses.UnhookWindowsHookEx(hookMouse);
        }

        private void btnSetHook_Click(object sender, EventArgs e)
        {
            hookKeyboard = ExtClasses.SetHook(HookProcedure, ExtClasses.HookType.WH_KEYBOARD_LL); //LL - low-level
            if (hookKeyboard != IntPtr.Zero)
            {
                btnSetHook.Enabled = false;
                btnReleaseHook.Enabled = true;
                lbHistory.Items.Insert(0, "Hook set!");
            }
        }

        private void btnReleaseHook_Click(object sender, EventArgs e)
        {
            if (hookKeyboard != IntPtr.Zero)
            {
                ExtClasses.UnhookWindowsHookEx(hookKeyboard);
                hookKeyboard = IntPtr.Zero;
                btnSetHook.Enabled = true;
                btnReleaseHook.Enabled = false;
                lbHistory.Items.Insert(0, "Hook released!");
            }
        }

        private IntPtr hookKeyboard = IntPtr.Zero;//дескриптор установленого хука клавиатуры
        private IntPtr hookMouse = IntPtr.Zero;//дескриптор установленого хука мыши
        public IntPtr HookProcedure(int code, IntPtr wParam, IntPtr lParam)
        {
            if (code >= 0 && wParam == (IntPtr)ExtClasses.WM_KEYDOWN) 
            {
                //int vkCode = Marshal.ReadInt32(lParam); //прочитать виртуальный код нажатой клавиши

                ExtClasses.KBDLLHOOKSTRUCT kbd = (ExtClasses.KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lParam,typeof(ExtClasses.KBDLLHOOKSTRUCT));
                //если кнопка RWin/LWin, блокировать клавишу
                if ((Keys)kbd.vkCode == Keys.RWin || (Keys)kbd.vkCode == Keys.LWin)
                {
                    //вывести сообщение в lisbox
                    Action a = () => 
                    {
                        lbHistory.Items.Insert(0, $"Lock key: {(Keys)kbd.vkCode}");
                    };
                    if (InvokeRequired) Invoke(a);
                    else a();
                    //signal everyone that message has been handled and must not be passed further in chain
                    return (IntPtr)1;
                }
            }
            return ExtClasses.CallNextHookEx(hookKeyboard, code, wParam, lParam);
        }
        //code -- числовое значение меседжа, которое используеться для упрощенного анализа меседжа(если он меньше нуля необходимо прокинуть дальше)

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            Visible = !Visible;
            if (Visible)
                this.BringToFront();
        }

        private IntPtr HookProcMouse(int code, IntPtr wParam, IntPtr lParam) 
        {
            if (code >= 0 && wParam == (IntPtr)ExtClasses.WM_MOUSEMOVE)
            {
                //получить координаты курсора
                int x = Marshal.ReadInt32(lParam);
                //int y = Marshal.ReadInt32(lParam);
                if (x > 400) return (IntPtr)1;
            }
            return ExtClasses.CallNextHookEx(hookMouse, code, wParam, lParam);
        }
        private void btnSetMouseHook_Click(object sender, EventArgs e)
        {
            hookMouse = ExtClasses.SetHook(HookProcMouse, ExtClasses.HookType.WH_MOUSE_LL);
            if (hookMouse != IntPtr.Zero)
            {
                btnSetMouseHook.Enabled = false;
                btnReleaseMouseHook.Enabled = true;

                lbHistory.Items.Insert(0, "Mouse set hook!");
            }
        }

        private void btnReleaseMouseHook_Click(object sender, EventArgs e)
        {
            
            if (hookMouse != IntPtr.Zero)
            {
                ExtClasses.UnhookWindowsHookEx(hookMouse);
                btnSetMouseHook.Enabled = true;
                btnReleaseMouseHook.Enabled = false;
                hookMouse = IntPtr.Zero;
                lbHistory.Items.Insert(0, "Mouse release hook!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HW1_1
{

    public enum BeepType : uint
    {           
        SimpleBeep = 0xFFFFFFFF,
        OK = 0x00,
        Question = 0x20,
        Exclamation = 0x30,
        Asterisk = 0x40,
    }
    internal class FunctionsExt
    {
        #region constants
        //buttons
        public const int MB_OK = 0x00000000;
        public const int MB_OKCANCEL = 0x00000001;
        public const int MB_YESNO = 0x00000004;

        //icons
        public const int MB_ICONEXCLAMATION = 0x00000030;
        public const int MB_ICONWARNING = 0x00000030;
        public const int MB_ICONINFORMATION = 0x00000040;
        public const int MB_ICONQUESTION = 0x00000020;
        public const int MB_ICONHAND = 0x00000010;

        //messages
        public const int WM_CLOSE = 0x0010;
        public const int WM_SETTEXT = 0x000C;
        #endregion


        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWind, String text, String caption, uint type);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr hWndChildAfter, string className, string windowTitle);

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, string lParam);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool SetWindowText(IntPtr hwnd, String lpString);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MessageBeep(BeepType uType);
    }
}

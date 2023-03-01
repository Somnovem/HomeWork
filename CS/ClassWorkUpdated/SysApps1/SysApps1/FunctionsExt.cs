using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace SysApps1
{
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

        //how to preview window
        public const int SW_HIDE = 0;
        public const int SW_SHOWNORMAL = 1;
        public const int SW_SHOWMINIMIZED = 2;
        public const int SW_SHOWMAXIMIZED = 3;
        public const int SW_SHOW = 5;


        public const int WM_CLOSE = 0x0010;
        public const int WM_SETTEXT = 0X000C;
        #endregion

        #region funcs
        [DllImport("user32.dll",SetLastError =true,CharSet =CharSet.Auto,EntryPoint ="MessageBox")]
        public static extern int MessageBoxUnicode(IntPtr hWind, String text,String caption, uint type);

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnableWindow(IntPtr hWnd, bool bEnable);

        #region Practice1_1

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public  static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool SetWindowText(IntPtr hwnd, String lpString);
        #endregion

        #endregion
    }
}

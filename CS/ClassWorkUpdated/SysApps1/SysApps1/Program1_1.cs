using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysApps1
{
    internal class Program1_1
    {
        static void Main(string[] args)
        {
            Console.Title = "System Applications - 1";
            Practice1_1.UpdateNotepad();
            Console.WriteLine("Press Enter...");
            Console.ReadKey();
        }
        static void TestMessageBox()
        {
            int result = FunctionsExt.MessageBoxUnicode(IntPtr.Zero, "Hello world!", "Test", FunctionsExt.MB_YESNO | FunctionsExt.MB_ICONQUESTION);
            Console.WriteLine(result);
            result = FunctionsExt.MessageBoxUnicode(IntPtr.Zero, "Hello world!", "Test", FunctionsExt.MB_OKCANCEL | FunctionsExt.MB_ICONHAND);
            Console.WriteLine(result);
            result = FunctionsExt.MessageBoxUnicode(IntPtr.Zero, "Hello world!", "Test", FunctionsExt.MB_OK | FunctionsExt.MB_ICONINFORMATION);
            Console.WriteLine(result);
        }

        static void TestShowWindow() 
        {
            FunctionsExt.ShowWindow((IntPtr)0x0056054C, FunctionsExt.SW_HIDE);
            Console.WriteLine("Press Enter to view window");
            Console.ReadKey();
            FunctionsExt.ShowWindow((IntPtr)0x0056054C, FunctionsExt.SW_SHOW);
        }
        static void TestEnableWindow()
        {
            FunctionsExt.EnableWindow((IntPtr)0x009408BE, false);
            Console.WriteLine("Press Enter to view window");
            Console.ReadKey();
            FunctionsExt.EnableWindow((IntPtr)0x009408BE, true);
        }
        static void TestGetWindowText()
        {
            StringBuilder sb = new StringBuilder();
            int h;
            do
            {
                Console.Write("Enter handle: ");
                h = int.Parse(Console.ReadLine(), NumberStyles.HexNumber);
                int len = FunctionsExt.GetWindowText((IntPtr)h, sb, 1024);
                Console.WriteLine($"Length = {len}: {sb} ");
                Console.ReadKey();
            } while (h != 1);

        }
    }
}

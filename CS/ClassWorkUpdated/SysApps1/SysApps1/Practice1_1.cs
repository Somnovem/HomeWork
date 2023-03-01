using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysApps1
{
    internal class Practice1_1
    {
        public static void HelloWorldMessageBox()
        {
            int result = FunctionsExt.MessageBoxUnicode(IntPtr.Zero, "Hello,World!", "Test", FunctionsExt.MB_OK | FunctionsExt.MB_ICONHAND);
            Console.WriteLine(result);
        }
        public static void GuessNumberMessageBox()
        {
            int ans = 0;
            while (ans != 6)
            {
                Console.Clear();
                Console.Write("Enter your number(0-100):");
                int num;
                try
                {
                    num = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    FunctionsExt.MessageBoxUnicode(IntPtr.Zero, "Wrong format!", "Warning", FunctionsExt.MB_OK | FunctionsExt.MB_ICONWARNING);
                    return;
                }
                if (num < 0 || num > 100)
                {
                    FunctionsExt.MessageBoxUnicode(IntPtr.Zero, "Wrong format!", "Warning", FunctionsExt.MB_OK | FunctionsExt.MB_ICONWARNING);
                    return;
                }
                int guessed = new Random().Next(0, 101);
                string res = num == guessed ? "Computer won!" : $"Computer lost with {guessed}!";
                res += "Would you like to retry?";
                ans = FunctionsExt.MessageBoxUnicode(IntPtr.Zero, res, "Result", FunctionsExt.MB_YESNO | FunctionsExt.MB_ICONINFORMATION);
            }
        }
        public static void ClosingNotepad()
        {
            IntPtr handle = FunctionsExt.FindWindow("Notepad", "test.txt – Блокнот");
            FunctionsExt.SendMessage(handle, FunctionsExt.WM_CLOSE,IntPtr.Zero, IntPtr.Zero);
        }
        public static void UpdateNotepad() 
        {
            IntPtr handle = FunctionsExt.FindWindow("Notepad", null);
            while (true)
            {
                FunctionsExt.SetWindowText(handle, DateTime.Now.ToString("HH:mm:ss"));
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}

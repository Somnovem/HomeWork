using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


//Сначала в настройках проекта включить использование небезопасного кода
//                  ВОЗВРАЩЕНИЕ В ВЕСЕЛЫЙ МИР УКАЗАТЕЛЕЙ


namespace SysApps8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            unsafe //блок только в котором можно использовать unsafe код
            {
                int d = 12;
                int* p = &d;

            }
            IntPtr ptr;
            //Pow(&x, y); // error -> using unsafe code out of block unsafe
            unsafe
            {
                int x = 10, y = 3;
                Pow(&x, y);
                ptr = (IntPtr)x;
            }
            Console.WriteLine($"ptr = {ptr}");
            Console.ReadLine();
        }

        unsafe static void Pow(int* x, int n)//должно быть ключевое слово unsafe, чтобы собственно использвать опасный код
        {
            int y = *x;
            for (int i = 0; i < n; i++)
            {
                *x *= y; 
            }
        }
    }
    public unsafe struct MyStruct
    {
        public int Val1;
        public unsafe char* Val2;
        public unsafe MyStruct* Val3;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
namespace SysApps8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Write to registry,2 - read from registry, 3 - delete from registry");
            int action = int.Parse(Console.ReadLine());
            switch (action)
            {
                case 1:
                    RegistryKey keySoftware = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);//доступны разные ветки каталога(даже скрытые);OpenSubKey -открывает подветку                                                                      //бул нужен чтобы разрешить запись в регистр и изменение
                    RegistryKey keyMyApp = keySoftware.CreateSubKey("MySystemApps");
                    keyMyApp.SetValue("login", "user1");
                    keyMyApp.SetValue("password", "1234");
                    keyMyApp.SetValue("value", 100, RegistryValueKind.DWord);//DWord = int
                    RegistryKey keySybMyApp = keyMyApp.CreateSubKey("apps");
                    keySybMyApp.SetValue("app1", "appname.exe");
                    keySybMyApp.Close();
                    keyMyApp.Close();
                    keySoftware.Close();
                    break;
                case 2:
                    using (RegistryKey keyMyAppRead = Registry.CurrentUser.OpenSubKey("SOFTWARE\\MySystemApps"))
                    {
                        string login = keyMyAppRead.GetValue("login", "user1").ToString();
                        string password = keyMyAppRead.GetValue("password", "1234").ToString();
                        Console.WriteLine($"{login} -> {password}");
                    }
                    break;
                case 3:
                    //key.DeleteSubKey()
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
            Console.WriteLine("Press ENTER key...");
        }
    }
}

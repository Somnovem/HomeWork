﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK8;
namespace ConsoleApp1
{
    internal class Controller
    {
        static void Main()
        {
            WebSite MySite = new WebSite(new DateTime(2022, 4, 10));
            Console.WriteLine(WebSite.browser);
            MySite.Name = "Google";
            MySite.Url = "google";
            MySite.Ip = "8.8.8.8";
            MySite.Print();
        }
    }
}

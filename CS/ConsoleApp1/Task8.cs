using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK8
{
    class WebSite
    {
        static public string browser;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string url;

        public string Url
        {
            get { return url; }
            set
            {
                if (!value.StartsWith("https://"))
                {
                    url += "https://";
                }
                url += value;
                if (!value.EndsWith(".com"))
                {
                    url += ".com";
                }
            }
        }

        private string info;

        public string Info
        {
            get { return info; }
            set { info = value; }
        }
        private string ip;
        public string Ip
        {
            get { return ip; }
            set { ip = value; }
        }
        private DateTime foundation;

        public DateTime Foundation
        {
            get { return foundation; }
           private  set { foundation = value; }
        }
        public void Print()
        {
            Console.WriteLine($"Name of the website: {Name}");
            Console.WriteLine($"URL of the website: {Url}");
            Console.WriteLine($"Info of the website: {Info}");
            Console.WriteLine($"IP of the website: {Ip}");
            Console.WriteLine($"Date of the foundation of the website: {Foundation}");
        }
        public WebSite(DateTime foundation)
        {
            Foundation = foundation;
        }
        static WebSite()
        {
            //browser = GetBrowser();
            browser = "Google Chrome";
        }
    }
}

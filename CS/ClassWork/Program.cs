using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{

    class WebSite
    {
        public string Name{ get; set; }
        public string Url { get { return Url; } set {
                if (!value.StartsWith("https://"))
                {
                    Url += "https://";
                }
                Url += value;
                if (!value.EndsWith(".com"))
                {
                    Url += ".com";
                }
            } }
        public string Info{ get; set; }
        public string Ip { get; set; }
        public DateTime Foundation { get;set; }
        public void Print()
        {
            Console.WriteLine($"Name of the website: {Name}");
            Console.WriteLine($"URL of the website: {Url}");
            Console.WriteLine($"Info of the website: {Info}");
            Console.WriteLine($"IP of the website: {Ip}");
            Console.WriteLine($"Date of the foundation of the website: {Foundation}");
        }
        //public WebSite(DateTime foundation)
        //{
        //    Foundation = foundation;
        //}   
    }

    //internal partial class MyClass
    //{
    //    public static int count;
    //    public const int age = 5; // can be assigned to in an cpnstructor, unlike c++
    //    public readonly int mark = 7; // can only be assigned to by creation,like const from c++
    //    public readonly int[] mark2 = { 1, 2, 3 };
    //    public int temp;
       
    //    public MyClass() : this(0) { }
    //    public MyClass(int mark)
    //    {
    //        this.mark = mark;
    //        Name = "Alabaster";
    //    }
    //    static MyClass()
    //    {
    //    count = 5;
    //    }
    //    public void foo()
    //    {
    //        count++;
    //    }

    //    public static void foo2()
    //    {
    //        count++;
    //    }

    //    int num;
    //    public int Num
    //    {
    //        get { return num; }
    //        set {
    //            if (value < 0)
    //            {
    //                num = 0;
    //            }
    //            else
    //            {
    //                num = value;
    //            }
    //        }
    //    }

    //    private string name;

    //    public string Name
    //    {
    //        get { return name; }
    //        protected set { name = value; }
    //    }


    //    DateTime trash;
    //    public DateTime Trash { get; set; } = DateTime.Now;

    //    public void setTemp(int t)
    //    {
    //        temp = t;
    //    }
    //    public int getTemp() { return temp; }
    //}

    //struct Point
    //{
    //    public int X;
    //    public int Y;
    //    public void Print() 
    //    {
    //        Console.WriteLine($"X: {X}   Y: {Y}");
    //    }
    //}

    internal class Program
    {


        //static int fooo(ref int[] arr, ref int a, out int b)
        //{
        //    a = 100;
        //    b = 10000;
        //    arr =new int[] {a,b,(b+1)*100};
        //    return a;
        //}

        //static int Sum(int a,params int[] s)
        //{ 
        //int sum = 0;
        //    foreach (var item in s) { sum += item; }
        //return sum; 
        //}

        static void Main(string[] args)
        {
            Console.Title = "I love Minecraft";
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            WebSite MySite  = new WebSite();
            MySite.Foundation = new DateTime(2022, 4, 10);
            MySite.Name = "Google";
            MySite.Url = "google";
            MySite.Ip = "8.8.8.8";
            MySite.Print();
        }
    }
}

using NLog;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
namespace ClassWork
{
    class Company
    {
        public int Code { get; set; }
        public string Name { get; set; }
    }


    /// <summary>
    /// Class Vacancies
    /// </summary>
    class Job
    {
        public int Id { get; set; }
        public string Vacancy { get; set; }
        public decimal Salary { get; set; }

        /// <summary>
        /// summs 2 ints
        /// </summary>
        /// <param name="a">first to sum</param>
        /// <param name="b">second to sum</param>
        /// <returns>sum</returns>
        public int Foo(int a, int b) 
        {
            return a + b;
        }
        /// <summary>
        /// Overriiten method to properly represent the object
        /// </summary>
        /// <returns>Strinw equivalent</returns>
        public override string ToString()
        {
            return $"Id : {Id}\nVacancy : {Vacancy}\nSalary : {Salary}";
        }
    }

    internal class Program
    {

        static int div(int a, int b) 
        {
            return a / b;
        }
        //static T Max3<T>(T first, T second, T third) where T : IComparable
        //{
        //    T firstBigger;
        //    if (first.CompareTo(second) <= 0)
        //    {
        //        firstBigger = second;
        //    }
        //    else
        //    {
        //        firstBigger = first;
        //    }
        //    if (third.CompareTo(firstBigger) <= 0)
        //    {
        //        return firstBigger;
        //    }
        //    else
        //    {
        //        return third;
        //    }
        //}

        //static T Min<T>(T[] arr) where T : IComparable<T>
        //{
        //    T min = arr[0];
        //    foreach (T item in arr)
        //    {
        //        if (item.CompareTo(min) < 0)
        //        {
        //            min = item;
        //        }
        //    }
        //    return min;
        //}

        //static void AddMark(Hashtable hs, string Name, int grade)
        //{
        //    foreach (var item in hs.Keys)
        //    {
        //        Student temp = item as Student;
        //        if (temp.FirstName + temp.LastName == Name)
        //        {
        //            (hs[item] as ArrayList).Add(grade);
        //        }
        //    }
        //}

        //static void PrintRaiting(Hashtable hs)
        //{
        //    foreach (var item in hs.Keys)
        //    {
        //        Student temp1 = item as Student;
        //        Console.Write(temp1.FirstName + " " + temp1.LastName + " --- ");
        //        ArrayList grades = (hs[item] as ArrayList);
        //        foreach (var temp2 in grades)
        //        {
        //            Console.Write($"{temp2}, ");
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //public delegate int Arithmetic(int t1, int t2);
        //public delegate bool Method<T>(T t1, T t2);
        //public delegate T GenericDelegate<T>(T t1, T t2);

        //static bool SeriesAC(Student st)
        //{
        //    return st.StudentCard.Series == "AC";
        //}
        //static int StudentComparison(Student st1, Student st2)
        //{
        //    return st1.Birthday.CompareTo(st2.Birthday);
        //}
        //static void Sort(int[] arr, Method<int> m)
        //{

        //}

        //class Calc
        //{
        //    public int Sum(int x, int y) => x + y;
        //    public int Diff(int x, int y) => x - y;
        //    static public int Mult(int x, int y) => x * y;
        //    public int Div(int x, int y) => x / y;
        //}



        //static bool isValidStudent(Student s)
        //{
        //    foreach (var item in typeof(Student).GetCustomAttributes())
        //    {
        //        if (item is AgeValidationAttribute)
        //        {
        //            return (DateTime.Now - s.BirthDay).TotalDays/365.25 > (item as AgeValidationAttribute).Age;
        //        }
        //    }
        //    return false;
        //}

        //static void printNode(XmlNode node)
        //{
        //    Console.WriteLine($"Type = {node.NodeType},".PadRight(20) + $"Name = {node.Name},".PadRight(20) + $"Value = {node.Value}");
        //    if (node.Attributes != null)
        //    {
        //        foreach (XmlNode item in node.Attributes)
        //        {
        //            Console.WriteLine($"Type = {item.NodeType},".PadRight(20) + $"Name = {item.Name},".PadRight(20) + $"Value = {item.Value}");
        //        }
        //    }
        //    if (node.HasChildNodes)
        //    {
        //        foreach (XmlNode item in node.ChildNodes)
        //        {
        //            printNode(item);
        //        }
        //    }
        //}
        static string GetTagValue(XmlTextReader xml, string tag)
        {
            while (xml.Read())
            {
                if (xml.NodeType == XmlNodeType.Element && xml.Name == tag)
                {
                    return xml.Value;
                }
            }
            return null;
        }
        static void Main(string[] args)
        {
            var logger = LogManager.GetCurrentClassLogger();
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.Title = "Console";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WindowHeight = 35;
            Console.WindowWidth = 120;
            Console.Clear();
            try
            {
                div(1, 0);
            }
            catch (Exception e)
            {

                logger.Error(e,"Exception message");
            }
            

            //string input = Console.ReadLine();
            //XmlTextReader xml = new XmlTextReader("dczvac20221031112152551.xml");
            //xml.WhitespaceHandling = WhitespaceHandling.None;
            //List<Job> jobs = new List<Job>();
            //while (xml.Read())
            //{
            //    if (xml.NodeType == XmlNodeType.Element && xml.Name == "job" && xml.HasAttributes)
            //    {
            //        Job job = new Job();
            //        xml.MoveToAttribute(0);
            //        job.Id = Convert.ToInt32(xml.GetAttribute("id"));
            //        job.Vacancy = new String(GetTagValue(xml, "name").Skip(8).SkipLast(2).ToArray());
            //        string region = (new String(GetTagValue(xml, "region").Skip(8).SkipLast(2).ToArray()).Split(',')[0]);
            //        job.Salary = Convert.ToDecimal(new String(GetTagValue(xml, "salary").Skip(8).SkipLast(2).ToArray()).Split('₴')[0]);
            //        if (region == input)
            //        {
            //            jobs.Add(job);
            //        }
            //    }
            //}

            //var holder = from j in jobs
            //             where j.Salary >= 20000
            //             select j;
            //foreach (Job item in holder)
            //{
            //    Console.WriteLine(item);
            //}

            //printNode(xml.DocumentElement);
            //xml.AppendChild(xml.CreateXmlDeclaration("1.0", "utf-8", "yes"));
            ////XmlNode root = xml.DocumentElement;
            ////xml.InsertBefore(xmlDeclaration, root);
            ////root.RemoveChild(root.LastChild);

            //XmlNode root = xml.CreateElement("Computers");
            //xml.AppendChild(root);
            //XmlNode comp = xml.CreateElement("Computer");

            //XmlAttribute attr = xml.CreateAttribute("Type");
            //attr.Value = "Office";
            //comp.Attributes.Append(attr);

            //XmlNode comp1 = xml.CreateElement("Motherboard");
            //XmlNode comp2 = xml.CreateElement("Processor");
            //XmlNode comp3 = xml.CreateElement("RAM");
            //XmlNode comp4 = xml.CreateElement("HDD");
            //XmlNode comp5 = xml.CreateElement("GraphicsCard");

            //XmlNode text1 = xml.CreateTextNode("Gigabyte");
            //XmlNode text2 = xml.CreateTextNode("IntelCoreI11");
            //XmlNode text3 = xml.CreateTextNode("256GB");
            //XmlNode text4 = xml.CreateTextNode("500Gb");
            //XmlNode text5 = xml.CreateTextNode("Radeon");

            //comp1.AppendChild(text1);
            //comp2.AppendChild(text2);
            //comp3.AppendChild(text3);
            //comp4.AppendChild(text4);
            //comp5.AppendChild(text5);

            //comp.AppendChild(comp1);
            //comp.AppendChild(comp2);
            //comp.AppendChild(comp3);
            //comp.AppendChild(comp4);
            //comp.AppendChild(comp5);

            //root.AppendChild(comp);
            //xml.Save("Computerssss.xml");

            //XmlTextWriter xmlTextWriter = new XmlTextWriter("Computers.xml",Encoding.Unicode);
            //xmlTextWriter.Formatting = Formatting.Indented;
            //xmlTextWriter.WriteStartDocument();
            //xmlTextWriter.WriteStartElement("Computers");

            //xmlTextWriter.WriteStartElement("Computer");
            //xmlTextWriter.WriteAttributeString("Type", "Home");
            //xmlTextWriter.WriteElementString("Motherboard", "MSI");
            //xmlTextWriter.WriteElementString("Processor", "Intel");
            //xmlTextWriter.WriteElementString("RAM", "DDR4 16Gb");
            //xmlTextWriter.WriteElementString("HDD", "4TB");
            //xmlTextWriter.WriteElementString("Graphics card", "GEFORCE RTX 8900");
            //xmlTextWriter.WriteEndElement();

            //xmlTextWriter.WriteStartElement("Computer");
            //xmlTextWriter.WriteAttributeString("Type", "Gaming");
            //xmlTextWriter.WriteElementString("Motherboard", "ASUS");
            //xmlTextWriter.WriteElementString("Processor", "AMD");
            //xmlTextWriter.WriteElementString("RAM", "DDR3 8Gb");
            //xmlTextWriter.WriteElementString("HDD", "8TB");
            //xmlTextWriter.WriteElementString("Graphics card", "MSI");
            //xmlTextWriter.WriteEndElement();

            //xmlTextWriter.WriteEndElement();
            //xmlTextWriter.WriteEndDocument();
            //xmlTextWriter.Close();



            //Student student = new Student()
            //{
            //    FirstName = "Olga",
            //    LastName = "Petrova",
            //    BirthDay = new DateTime(2005, 5, 14),
            //    StudentCard = new StudentCard()
            //    {
            //        Series = "AC",
            //        Number = 123456
            //    }
            //};

            //Point point = new Point() { X = 10, Y = 10 };
            //XmlSerializer xmlp = new XmlSerializer(typeof(Point));
            //using (Stream stream = File.Create("Point.xml"))
            //{
            //    xmlp.Serialize(stream, point);
            //}




            //Console.WriteLine(student);
            //BinaryFormatter binaryFormatter = new BinaryFormatter();

            //List<Student> students = new List<Student>()
            //{
            //            new Student()
            //            {
            //                FirstName = "Olga",
            //                LastName = "Petrova",
            //                BirthDay = new DateTime(2005,5,14),
            //                StudentCard = new StudentCard()
            //                {
            //                    Series = "AC",Number =123456
            //                }
            //             },
            //            new Student()
            //            {
            //                FirstName = "Natasha",
            //                LastName = "Romanoff",
            //                BirthDay = new DateTime(2005,7,2),
            //                StudentCard = new StudentCard()
            //                {
            //                    Series = "AB",Number =123466
            //                }
            //             },
            //            new Student()
            //            {
            //                FirstName = "Petro",
            //                LastName = "Oleksiiv",
            //                BirthDay = new DateTime(1995,4,25),
            //                StudentCard = new StudentCard()
            //                {
            //                    Series = "AC",Number =123478
            //                }
            //             },
            //            new Student()
            //            {
            //                FirstName = "Geralt",
            //                LastName = "of Rivia",
            //                BirthDay = new DateTime(1999,6,16),
            //                StudentCard = new StudentCard()
            //                {
            //                    Series = "AB",Number =123444
            //                }
            //             },
            //            new Student()
            //            {
            //                FirstName = "Microft",
            //                LastName = "Holmes",
            //                BirthDay = new DateTime(2002,6,16),
            //                StudentCard = new StudentCard()
            //                {
            //                    Series = "AB",Number =123444
            //                }
            //             }

            //        };

            //XmlSerializer xml = new XmlSerializer(typeof(Student));
            //using (Stream stream = File.Create("student.xml"))
            //{
            //    xml.Serialize(stream, student);
            //}
            //student = null;
            //using (Stream stream = File.OpenRead("student.xml"))
            //{
            //   student =  (Student)xml.Deserialize(stream);
            //}
            //using (Stream stream = File.Create("student.xml"))
            //{
            //    foreach (var item in students)
            //    {
            //        xml.Serialize(stream, item);
            //    }

            //}
            //using (Stream stream = File.OpenRead("student.xml"))
            //{
            //    students = (List<Student>)xml.Deserialize(stream);
            //}
            //foreach (var item in students)
            //{
            //    Console.WriteLine(item);
            //}
            //using (Stream stream  =File.Create("student.bin"))
            //{
            //    foreach (var item in students)
            //    {
            //        binaryFormatter.Serialize(stream, item);
            //    }
            //}


            //foreach (var item in typeof(Student).GetCustomAttributes())
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in typeof(Student).GetMembers())
            //{
            //    foreach (var item2 in item.GetCustomAttributes())
            //    {
            //        Console.WriteLine(item.Name + " - " + item2);
            //    }
            //}







            /*
             .
             \w
             \W             
             \s
             \S
             \d
             \D
             [a-z or A-Z]
             [^a-z]
             * - 0 or more
             + - 1 or more
             ? - 0 or 1
             {n}
             {n,m}
             {n,}
             ^
             $
            */
            //string pattern = "^[A-Z][a-z]+(-[A-Z][a-z]+){0,2}$";
            //string mobilePhonePatter = @"^\+38\(0(50|66)\)\s\d{3}-\d{2}-\d{2}$";
            //string isDigit = "^-?\\d+$";

            //Regex regex = new Regex(isDigit);
            //while (true)
            //{
            //    Console.WriteLine(regex.IsMatch(Console.ReadLine()) ? "Correct" : "Incorrect"); ;
            //}






            //DirectoryInfo dir = new DirectoryInfo(".");
            ////Console.WriteLine(dir.Attributes & FileAttributes.Compressed);
            //dir.CreateSubdirectory("dir2");
            //List<string> list = new List<string>();
            //var d = dir.GetDirectories();
            //foreach (var item in d)
            //{
            //    list.Add(item.Name);
            //}

            //ConsoleMenu.SelectVertical(HPosition.Center,VPosition.Center, HorizontalAlignment.Center, Directory.GetLogicalDrives().ToArray());
            //Console.Clear();
            //var f = dir.GetFiles();
            //foreach (var item in f)
            //{
            //    list.Add(item.Name);
            //}

            //PV111_CSharp.ConsoleMenu.SelectVertical(PV111_CSharp.HPosition.Center, PV111_CSharp.VPosition.Center, PV111_CSharp.HorizontalAlignment.Center, list.ToArray());
            //Console.Clear();
            //Directory.GetLogicalDrives().ToList().ForEach(s => Console.WriteLine(s));
            //Console.Clear();
            //FileInfo f1 = new FileInfo("file.txt");
            //using (StreamWriter sw = File.CreateText("text22.txt"))
            //{
            //    sw.WriteLine("LOKI IS AWAKE");    
            //}




            //using (FileStream fs = new FileStream("file.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            //{
            //    string str = Console.ReadLine();
            //    byte[] bytes = Encoding.Default.GetBytes(str);
            //    fs.Write(bytes, 0, bytes.Length);

            //}

            //using (FileStream fs = new FileStream("file.txt", FileMode.Open, FileAccess.Read, FileShare.Read))
            //{
            //    byte[] bytes = new byte[fs.Length];
            //    fs.Read(bytes, 0, bytes.Length);
            //    Console.WriteLine(Encoding.Default.GetString(bytes));
            //}


            //using (FileStream fs = new FileStream("file1.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None)) 
            //{
            //    using (StreamWriter sw= new StreamWriter(fs,Encoding.Default))
            //    {
            //        sw.WriteLine("I love Minecraft");
            //    }
            //}


            //using (FileStream fs = new FileStream("file1.txt", FileMode.Open, FileAccess.Read, FileShare.None))
            //{
            //    using (StreamReader sw = new StreamReader(fs, Encoding.Default))
            //    {
            //        Console.Write(sw.ReadToEnd()); 
            //    }
            //}


            //using (FileStream fs = new FileStream("file2.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            //{
            //    using (BinaryWriter bw = new BinaryWriter(fs, Encoding.Default))
            //    {
            //        string str = "I love minecraft";
            //        int i = 12345;
            //        double d = 1.14151674;
            //        char c = 'A';
            //        bw.Write(str);
            //        bw.Write(i);
            //        bw.Write(d);
            //        bw.Write(c);
            //    }
            //}

            //using (FileStream fs = new FileStream("file2.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
            //{
            //    using (BinaryReader bw = new BinaryReader(fs, Encoding.Default))
            //    {
            //        Console.WriteLine(bw.ReadString());
            //        Console.WriteLine(bw.ReadInt32());
            //        Console.WriteLine(bw.ReadDouble());
            //        Console.WriteLine(bw.ReadChar());
            //    }
            //}


            //int[] arr = { 125, 45, 23, 1, 56, 67, 54, 60 };

            //var linq = from i in arr
            //           where i % 5 == 0
            //           orderby i descending
            //           select i;


            //var linq1 = from i in arr
            //           group i by i /10;

            //foreach (var item in linq1)
            //{
            //    Console.Write(item.Key + ": ");
            //    foreach (var item2 in item)
            //    {
            //        Console.Write(item2 + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();



            //Console.CancelKeyPress += Console_CancelKeyPress;
            //Console.ReadLine();
            //Calc calc = new Calc();
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //char op = Convert.ToChar(Console.ReadLine());
            //Arithmetic ariphmetic = null;
            //switch (op)
            //{
            //    case '+':
            //        ariphmetic = calc.Sum;
            //        break;
            //    case '-':
            //        ariphmetic = calc.Diff;
            //        break;
            //    case '*':
            //        ariphmetic = Calc.Mult;
            //        break;
            //    case '/':
            //        ariphmetic = calc.Div;
            //        break;
            //    default:
            //        break;
            //}
            //Console.WriteLine($"{a} {op} {b} = {ariphmetic(a, b)}");
            //Arithmetic ariphmetic1 = calc.Sum;
            //ariphmetic += ariphmetic1;
            //ariphmetic += Calc.Mult;
            //foreach (Arithmetic item in ariphmetic.GetInvocationList())
            //{
            //    Console.WriteLine(item(a, b));
            //}
            //Func<int, int, int> func = Calc.Mult;
            //func += delegate (int c, int d) { return (int)Math.Pow(c, d); };
            //foreach (Func<int, int, int> item in func.GetInvocationList())
            //{
            //    Console.WriteLine(item(2,3));
            //}
            //Group group = new Group();
            //foreach (Student item in group.Top3())
            //{
            //    Console.WriteLine(item);
            //}
            //func += (int a, int b) => { return a * b; };

            //int c = 8, d = 4;
            //func += (c, d) => { return c * d; };
            //Action<int> actionInt = null;
            //actionInt += c => { Console.WriteLine(c); };

            //Action ac = null;
            //ac += () => { Console.WriteLine("Hallo"); };
            //Action cc = () => { };












            //List<GroupName> groups = new List<GroupName>
            //{
            //    new GroupName(){ ID = 1, Name = "PV111"},
            //    new GroupName(){ ID = 2, Name = "PVU151"},
            //    new GroupName(){ ID = 3, Name = "PVB119"},
            //};

            //var st_gr = from g in groups
            //            join st in students on g.ID equals st.Group.ID
            //            select new {LastName = st.LastName, FirstName = st.FirstName, GroupNames = g.Name};

            //foreach (var item in st_gr)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine($"{item.LastName} {item.FirstName} {item.GroupNames}");
            //}
            //Teacher teacher = new Teacher();
            //foreach (var item in students)
            //{
            //    teacher.Exam += item.Exam;
            //}
            //teacher.SetExam(new DateTime(2022, 10, 19));
            //teacher.SetExam2(new ExamEventArgs { Date = new DateTime(2022, 12, 26) });
            //teacher.Exam -= students[1].Exam;
            //teacher.Exam3 += delegate (string d) { Console.WriteLine(d); };
            //teacher.SetExam(new DateTime(2022, 11, 26));
            //teacher.SetExam("Hello");
            //students.ForEach(FullNameStudent);


            //students.FindAll(s => (DateTime.Now.Year - s.Birthday.Year) > students.Average(y=> (DateTime.Now.Year - y.Birthday.Year))).ForEach(s => Console.WriteLine(s));



            //var st = students.Select(s => $"{s.LastName}");
            //foreach (var item in st)
            //{
            //    Console.WriteLine(item);
            //}
            //students.FindAll(s => (s.Birthday.Year >= 2000)).ForEach(s => Console.WriteLine(s));

            //students.Sort((s1, s2) => s1.StudentCard.CompareTo(s2.StudentCard));
            //students.ForEach(s => Console.WriteLine(s));
            //Action<Hashtable> action = PrintRaiting;
            //Func<int, int, int> func = Calc.Mult;
            //Console.WriteLine(func(3, 2));
            ////var temp = students.Select(FullNameStudentString);
            ////foreach (var item in temp)
            ////{
            ////    Console.WriteLine(item);
            ////}
            //List<Student> st2 = students.FindAll(SeriesAC);
            //foreach (var item in st2)
            //{
            //    Console.WriteLine(item);
            //}
            //students.Sort(StudentComparison);
            //Console.WriteLine("------------------------");
            //foreach (var item in students)
            //{
            //    Console.WriteLine(item);
            //}
        }

        //private static void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        //{
        //    Console.WriteLine("Ctrl+C");
        //    Console.ReadKey();
        //}

        //private static void Teacher_Exam3(string obj)
        //{
        //    throw new NotImplementedException();
        //}
        //static void FullNameStudent(Student st)
        //{
        //    Console.WriteLine($"{st.FirstName}  {st.LastName}");
        //}
        //static string FullNameStudentString(Student st)
        //{
        //    return $"{st.FirstName}  {st.LastName}";
        //}

    }

    //class Point3D<T> where T: class, IComparable<T>,new()
    //{
    //    T x;
    //    T y;
    //    T z;
    //    public Point3D()
    //    {
    //        x = default(T);
    //        y = default(T);
    //        z = default(T);
    //    }
    //}
}

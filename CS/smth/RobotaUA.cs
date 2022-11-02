using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace smth
{
    internal class Job
    {
        static int x = 105;
        static int y = 2;
        public Int64 Id { get; set; }
        public string JobName { get; set; }

        public decimal Salary { get; set; }
        public void Print()
        {
            Console.WriteLine(Id + "\t\t" + JobName);
            Console.SetCursorPosition(x, y++);
            Console.WriteLine(Salary);
        }
    }
    public static class RobotaUA
    {
        static string GetTagValue(XmlTextReader reader, string Tag)
        {
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.Name == Tag)
                {
                    reader.Read();
                    return reader.Value;
                }
            }
            return null;
        }

        public static void GetVacanciesOblast()
        {
            string[] oblasts = new string[] { "Дніпропетровськ", "Харків", "Київ", "Одеська", "Вінницька", "Донецьк", "Чернігів", "Миколаїв", "Полтавська", "Житомир", "Волинська", "Івано-Франківська", "Кіровоградська", "Луганськ", "Львівська", "Рівненська", "Сумська", "Тернопільська", "Херсонська", "Хмельницька", "Черкаська", "Чернівецька" };
            Console.SetCursorPosition(8, 4);
            Console.WriteLine("Виберіть область для якої шукаєте роботу,");
            Console.SetCursorPosition(8, 5);
            Console.WriteLine("з зарплатнею >=20000₴");
            string input = oblasts[Menu.ConsoleMenu.SelectVertical(Menu.HPosition.Center, Menu.VPosition.Center, Menu.HorizontalAlignment.Center, oblasts)];
            Console.Clear();
            XmlTextReader xml = new XmlTextReader("dczvac20221031112152551.xml");
            xml.WhitespaceHandling = WhitespaceHandling.None;
            List<Job> jobs = new();
            while (xml.Read())
            {
                if (xml.NodeType == XmlNodeType.Element && xml.Name == "job" && xml.HasAttributes)
                {
                    Job job = new Job();
                    xml.MoveToAttribute(0);
                    job.Id = Convert.ToInt64(xml.Value);
                    job.JobName = new String(GetTagValue(xml, "name").Skip(8).SkipLast(2).ToArray());
                    string region = new String(GetTagValue(xml, "region").Skip(8).SkipLast(2).ToArray()).Split(',')[0];
                    job.Salary = Convert.ToDecimal(new String(GetTagValue(xml, "salary").Skip(8).SkipLast(2).ToArray()).Split('₴')[0]);

                    if (region.Contains(input))
                    {
                        jobs.Add(job);
                    }
                }
            }
            var vacancies = from j in jobs
                            where j.Salary >= 20000
                            select j;
            Console.WriteLine("ID\t\tВакансія\t\t\t\t\t\t\tЗаробітна плата");
            foreach (var item in vacancies)
            {
                item.Print();
            }
        }
    }
}
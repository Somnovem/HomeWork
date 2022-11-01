using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Globalization;
using System.Data;

namespace smth
{
    class Currency
    {
        public static List<Currency> GetListFromXml(XmlDocument root)
        {
            Stack<string> list = new Stack<string>();
            foreach (XmlNode item in root.DocumentElement.ChildNodes)
            {
                foreach (XmlNode nocs in item.ChildNodes)
                {
                    list.Push(nocs.InnerText);
                }
            }
            List<Currency> currencies = new List<Currency>();
            {
                Stack<string> temp = new Stack<string>();
                while (list.Count !=0)
                {
                    temp.Push(list.Pop());
                }
                list = temp;
            }
            while (list.Count != 0)
            {
                Currency currency = new Currency();
                currency.r030 = Convert.ToInt32(list.Pop());
                currency.name = list.Pop();
                currency.rate = double.Parse(list.Pop(),CultureInfo.InvariantCulture);
                currency.cc = list.Pop();
                currency.exchangeDate = Convert.ToDateTime(list.Pop());
                currencies.Add(currency);
            }
            return currencies;
        }
        public static void ShowCurrenciesRatesAbove20(List<Currency> list)
        {
            var t = from c in list
                    where c.rate > 20
                    select c;
            foreach (var item in t)
            {
                Console.WriteLine(item);
                Console.WriteLine("---------------");
            }
        }
        public int r030 { get; set; }
        public string cc { get; set; }
        public string name { get; set; }
        public DateTime exchangeDate { get; set; }
        public double rate { get; set; }
        public override string ToString()
        {
            return $"r030 : {r030}\nName : {name}\nRate = {rate}\nCC : {cc}\nExchange date : {exchangeDate.ToShortDateString()}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassWork
{
    enum Gender {MALE,FEMALE,NON_BINARY}
    internal sealed class Visa
    {
        public string where { get; set; }
        public DateTime beginDate { get; set; }
        public DateTime endDate { get; set; }
        public Visa(string where, DateTime beginDate, DateTime endDate)
        {
            this.where = where;
            this.beginDate = beginDate;
            this.endDate = endDate;
        }
        public override string ToString()
        {
            return $"Where: {where}\n" + $"Begin date: {beginDate.ToShortDateString()}\n" + $"Date of expiration: {endDate.ToShortDateString()}\n";
        }
    }

    internal class Passport
    {
        public string firstname { get; set; }
        public string lastname  { get; set; }
        public string id { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender gender { get; set; }
        public DateTime ExpirationDate { get; set; }
        public Passport() { }
        public Passport(string firstname, string lastname, string id, DateTime dateOfBirth, Gender gender, DateTime expirationDate)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.id = id;
            DateOfBirth = dateOfBirth;
            this.gender = gender;
            ExpirationDate = expirationDate;
        }
        public override string ToString()
        {
            return "First name: " + firstname + '\n'+"Last name: " + lastname + '\n'+"ID:" + id + '\n'+ "Date of birth: " + DateOfBirth.ToShortDateString() +'\n'+ "Gender: " + gender.ToString() + '\n'+"Expiration date: " + ExpirationDate.ToShortDateString() + '\n';
        }
    }

    internal class ForeignPassport : Passport
    {
        List<Visa> visas = new List<Visa> { };
        public ForeignPassport(string firstname, string lastname, string id, DateTime dateOfBirth, Gender gender, DateTime expirationDate) : base(firstname,lastname,id,dateOfBirth,gender,expirationDate)
        {
        }
        public void AddVisa()
        {
            Console.Clear();
            Console.WriteLine("Where to the visa is: ");
            string where = Console.ReadLine();
            Console.WriteLine("When does the visa begin: ");
            DateTime begin = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("When does the visa end: ");
            DateTime end = DateTime.Parse(Console.ReadLine());
            Visa newVisa = new Visa(where,begin,end);
            visas.Add(newVisa);
            Console.Clear();
        }
        public void DeleteVisa()
        {
            Console.Clear();
            List<string> names = new List<string> { };
            foreach (var item in visas)
            {
                names.Add(item.where);
            }
            visas.RemoveAt(PV111_CSharp.ConsoleMenu.SelectVertical(PV111_CSharp.HPosition.Center, PV111_CSharp.VPosition.Center, PV111_CSharp.HorizontalAlignment.Left, names));
            Console.Clear();
        }
        public void showValidity()
        {
            foreach (var item in visas)
            {
                Console.WriteLine(item);
                DateTime dateTime = DateTime.Now;
                DateTime temp = item.endDate;
                if (item.endDate <= dateTime)
                {
                    Console.WriteLine("Expired");
                }
                else if (temp.AddDays(-7) <= dateTime)
                {
                    Console.WriteLine("Within a week of expiration");
                }
                else
                {
                    Console.WriteLine("Valid");
                }
            }
        }
        public bool isEmpty() { return visas.Count == 0; }
    }
    internal class UkrainianPassport : Passport
    {
        string fathersName;
        string placeOfAcquiring;
        UkrainianPassport() { }
        public UkrainianPassport(string firstname, string lastname, string id, DateTime dateOfBirth, Gender gender, DateTime expirationDate, string fathersName, string placeOfAcquiring) : base(firstname, lastname, id, dateOfBirth, gender, expirationDate)
        {
            this.fathersName = fathersName;
            this.placeOfAcquiring = placeOfAcquiring;
        }
        public override string ToString()
        {
            return base.ToString() + $"By father's name: {fathersName}\n" + $"Acquired at: {placeOfAcquiring}";
        }
    }
    internal sealed class Controller
    {
        List<Passport> passports = new List<Passport> { };
        public Controller() { }
        private void AddUkrainian()
        {
            Console.Write("First name: ");
            string firstname = Console.ReadLine();
            Console.Write("Last name: ");
            string lastname = Console.ReadLine();
            Console.Write("ID: ");
            string id = Console.ReadLine();
            Console.Write("Date of birth: ");
            DateTime birth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Type in your gender: Male/Female/Non-binary");
            string Gend = Console.ReadLine();
            Gender gender;
            switch (Gend)
            {
                case "Male":
                    gender = Gender.MALE;
                    break;
                case "Female":
                    gender = Gender.FEMALE;
                    break;
                default:
                    gender = Gender.NON_BINARY;
                    break;
            }
            Console.Write("Date of expiration: ");
            DateTime expiration = DateTime.Parse(Console.ReadLine());
            Console.Write("Fathers name: ");
            string fathers = Console.ReadLine();
            Console.Write("Place of acquiring: ");
            string placeAquire = Console.ReadLine();
            Passport temp = new UkrainianPassport(firstname,lastname,id,birth,gender,expiration,fathers,placeAquire);
            passports.Add(temp);  
        }
        private void AddForeign()
        {
            Console.Write("First name: ");
            string firstname = Console.ReadLine();
            Console.Write("Last name: ");
            string lastname = Console.ReadLine();
            Console.Write("ID: ");
            string id = Console.ReadLine();
            Console.Write("Date of birth: ");
            DateTime birth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Type in your gender: Male/Female/Non-binary");
            string Gend = Console.ReadLine();
            Gender gender;
            switch (Gend)
            {
                case "Male":
                    gender = Gender.MALE;
                    break;
                case "Female":
                    gender = Gender.FEMALE;
                    break;
                default:
                    gender = Gender.NON_BINARY;
                    break;
            }
            Console.Write("Date of expiration: ");
            DateTime expiration = DateTime.Parse(Console.ReadLine());
            Passport temp = new ForeignPassport(firstname, lastname, id, birth, gender, expiration);
            passports.Add(temp);
        }
        public void Menu()
        {
            string[] options = {"Add ukrainian passport","Add foreign passport","Add visa to a passport","Show all passports","Show all visas","Delete passport","Delete visa","Exit"};
            int c = 0;
            while (c != options.Length-1)
            {
                Console.Clear();
                c = PV111_CSharp.ConsoleMenu.SelectVertical(PV111_CSharp.HPosition.Left, PV111_CSharp.VPosition.Bottom, PV111_CSharp.HorizontalAlignment.Right, options);
                Console.Clear();
                switch (c)
                {
                    case 0:
                        this.AddUkrainian();
                        break;
                    case 1:
                        this.AddForeign();
                        break;
                    case 2:
                        {
                            List<int> indexes = new List<int>{ };
                            for (int i = 0; i < passports.Count; i++)
                            {
                                if (passports.ElementAt(i) is ForeignPassport)
                                {
                                    indexes.Add(i);
                                }
                            }
                            if (indexes.Count == 0)
                            {
                                Console.WriteLine("No entries");
                                Console.ReadKey();
                                break;
                            }
                            List<string> foreigns = new List<string> { };
                            foreach (var item in indexes)
                            {
                                foreigns.Add(passports.ElementAt(item).firstname + "  " + passports.ElementAt(item).lastname);
                            }
                            int ind = PV111_CSharp.ConsoleMenu.SelectVertical(PV111_CSharp.HPosition.Center, PV111_CSharp.VPosition.Center, PV111_CSharp.HorizontalAlignment.Center, foreigns);
                            (passports.ElementAt(ind) as ForeignPassport).AddVisa();
                        }
                        break;
                    case 3:
                        if (passports.Count != 0)
                        {
                            foreach (var item in passports)
                            {
                                Console.WriteLine(item);
                                Console.WriteLine("---------------------------------");
                            }
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("No entries");
                            Console.ReadKey();
                        }
                        break;
                    case 4:
                        bool atLeastOne = false;
                        foreach (var item in passports)
                        {
                            if (item is ForeignPassport)
                            {
                                if (!((item as ForeignPassport).isEmpty()))
                                {
                                    Console.WriteLine(item.firstname + "  " + item.lastname);
                                    (item as ForeignPassport).showValidity();
                                    Console.WriteLine("--------------------");
                                    atLeastOne = true;
                                }
                            }
                        }
                        if (!atLeastOne)
                        {
                            Console.WriteLine("No entries found");
                        }
                        Console.ReadKey();
                        break;
                    case 5:
                        if (passports.Count != 0)
                        {
                            List<string> passportView = new List<string> { };
                            foreach (var item in passports)
                            {
                                if (item is UkrainianPassport)
                                {
                                    passportView.Add("Ukrainian passport: " + item.firstname + " " + item.lastname);
                                }
                                else
                                {
                                    passportView.Add("Foreign passport: " + item.firstname + " " + item.lastname);
                                }
                            }
                            passports.RemoveAt(PV111_CSharp.ConsoleMenu.SelectVertical(PV111_CSharp.HPosition.Center, PV111_CSharp.VPosition.Center, PV111_CSharp.HorizontalAlignment.Center, passportView));

                        }
                        else
                        {
                            Console.WriteLine("No entries");
                        }
                        break;
                    case 6:
                        {
                            List<int> indexes = new List<int> { };
                            for (int i = 0; i < passports.Count; i++)
                            {
                                if (passports.ElementAt(i) is ForeignPassport)
                                {
                                    indexes.Add(i);
                                }
                            }
                            if (indexes.Count == 0)
                            {
                                Console.WriteLine("No entries");
                                Console.ReadKey();
                                break;
                            }
                            List<string> foreigns = new List<string> { };
                            foreach (var item in indexes)
                            {
                                foreigns.Add(passports.ElementAt(item).firstname + "  " + passports.ElementAt(item).lastname);
                            }
                            int ind = PV111_CSharp.ConsoleMenu.SelectVertical(PV111_CSharp.HPosition.Center, PV111_CSharp.VPosition.Center, PV111_CSharp.HorizontalAlignment.Center, foreigns);
                            (passports.ElementAt(ind) as ForeignPassport).DeleteVisa();
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

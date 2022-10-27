using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace smth
{
    class Director
    {
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public override string ToString()
        {
            return $"Lastname : {Lastname}\nFirstname : {Firstname}\n";
        }
    }
    internal class Firm
    {
        public string Name { get; set; }
        public DateTime Foundation { get; set; }
        public string Speciality { get; set; }
        public Director Director { get; set; }
        public int NumberOfEmployess { get; set; }
        public string Adress { get; set; }
        public override string ToString()
        {
            return $"Name : {Name}\nFoundation : {Foundation.ToShortDateString()}\nSpeciality : {Speciality}\n{Director}Number of employees : {NumberOfEmployess}\nAdress : {Adress}\n-----------------------------------\n"; 
        }
        static void Work()
        {
            List<Firm> firms = new List<Firm>();
            firms.Add(new Firm() {Name = "Microsoft",Foundation = new DateTime(1986,10,12),Speciality = "IT", Director = new Director() {Lastname = "White", Firstname = "Gordon"},NumberOfEmployess = 1200000, Adress = "USA,California,Silicon Valley"});
            firms.Add(new Firm() { Name = "Food Heaven", Foundation = new DateTime(2022, 6, 26), Speciality = "Food delivery", Director = new Director() { Lastname = "Ramsay", Firstname = "Gordon" }, NumberOfEmployess = 240, Adress = "62-64 Kinnerton St, London" });
            firms.Add(new Firm() { Name = "FoodDec", Foundation = new DateTime(2001, 9, 6), Speciality = "Marketing", Director = new Director() { Lastname = "Namia", Firstname = "Din" }, NumberOfEmployess = 295, Adress = "USA,California,Silicon Valley" });
            firms.Add(new Firm() { Name = "Binance", Foundation = new DateTime(2004, 6, 17), Speciality = "Stock trading", Director = new Director() { Lastname = "White", Firstname = "Robert" }, NumberOfEmployess = 150000, Adress = "USA,California,Silicon Valley" });
            firms.Add(new Firm() { Name = "Nelson & Murdock", Foundation = new DateTime(2017, 11, 9), Speciality = "Private Attorneys", Director = new Director() { Lastname = "Padge", Firstname = "Karen" }, NumberOfEmployess = 3, Adress = "USA,Pensylvania,New York, Abbington 34a" });
            firms.Add(new Firm() { Name = "Boston Dynamics", Foundation = new DateTime(1999, 5, 14), Speciality = "Robotics", Director = new Director() { Lastname = "Semuara", Firstname = "Chumpa" }, NumberOfEmployess = 120000, Adress = "London, Watton's green 56b" });
            firms.Add(new Firm() { Name = "GetGoShoes", Foundation = new DateTime(2021, 8, 8), Speciality = "Marketing", Director = new Director() { Lastname = "Martines", Firstname = "David" }, NumberOfEmployess = 1400, Adress = "France,OrlEans,11 Rue Roussy" });
            firms.Add(new Firm() { Name = "The sugar of life", Foundation = new DateTime(2022, 1, 10), Speciality = "Marketing", Director = new Director() { Lastname = "Ramirez", Firstname = "Lucy" }, NumberOfEmployess = 560, Adress = "Italy,Castelvetrano,Via del Pontiere 2" });
            firms.Add(new Firm() { Name = "Numali", Foundation = new DateTime(2006, 10, 13), Speciality = "Marketing", Director = new Director() { Lastname = "Sumak", Firstname = "Rusha" }, NumberOfEmployess = 15000, Adress = "London,54 St. John’s Road" });
            firms.Add(new Firm() { Name = "Sony", Foundation = new DateTime(1990, 5, 18), Speciality = "IT", Director = new Director() { Lastname = "Marotaka", Firstname = "Hirohika" }, NumberOfEmployess = 1300000, Adress = "Japan,Kyoto,265-1095, Ariichi, Kasagi-cho Soraku-gun" });
            firms.Add(new Firm() { Name = "From Software", Foundation = new DateTime(1982, 4, 4), Speciality = "IT", Director = new Director() { Lastname = "Miyazaki", Firstname = "Hidetaka" }, NumberOfEmployess = 5000, Adress = "London,27 George Street" });
            firms.Add(new Firm() { Name = "Rotten Tomatoes", Foundation = new DateTime(2010, 7, 27), Speciality = "Marketing", Director = new Director() { Lastname = "Riegel", Firstname = "Sam" }, NumberOfEmployess = 3400, Adress = "USA,North Carolina,Aberdeen,Washington's 45" });
            firms.Add(new Firm() { Name = "CD Project Read", Foundation = new DateTime(1992, 11, 24), Speciality = "IT", Director = new Director() { Lastname = "Badowski", Firstname = "Adam" }, NumberOfEmployess = 4800, Adress = "Poland,Warsawa,Kachinski 53" });
            firms.Add(new Firm() { Name = "White InInsecure", Foundation = new DateTime(1985, 3, 29), Speciality = "Insurance", Director = new Director() { Lastname = "Black", Firstname = "Sirius" }, NumberOfEmployess = 270, Adress = "India,Mumbai,Goragandhi Bldg 1/15" });
            firms.Add(new Firm() { Name = "Animlive", Foundation = new DateTime(2022, 6, 26), Speciality = "Marketing", Director = new Director() { Lastname = "Avdol", Firstname = "Muhammad" }, NumberOfEmployess = 345, Adress = "India,Bangalore,26, Dvg Road, Basavanagudi" });
            firms.Add(new Firm() { Name = "Arkane Studios", Foundation = new DateTime(2001, 11, 5), Speciality = "IT", Director = new Director() { Lastname = "Hanamura", Firstname = "Kiriko" }, NumberOfEmployess = 1400, Adress = "India,Hyderabad,402a Tade Arcade" });
            firms.Add(new Firm() { Name = "ParadiseTrade", Foundation = new DateTime(2022, 5, 16), Speciality = "Marketing", Director = new Director() { Lastname = "Isinius", Firstname = "Lorem" }, NumberOfEmployess = 145, Adress = "India,Mumbai,147, Fida Bldg, Agashi" });
            firms.Add(new Firm() { Name = "URGuardian", Foundation = new DateTime(1995, 9, 14), Speciality = "Insurance", Director = new Director() { Lastname = "Bandar", Firstname = "Nyaoka" }, NumberOfEmployess = 178, Adress = "India,Vadodara,105, Shreeji Avenue" });
            firms.Add(new Firm() { Name = "FoodHouse", Foundation = new DateTime(2019, 11, 24), Speciality = "Marketing", Director = new Director() { Lastname = "Hammond", Firstname = "Postal" }, NumberOfEmployess = 321, Adress = "India,Mumbai,Linkway Nur Home,Behram Baug" });
            firms.Add(new Firm() { Name = "Ubisoft", Foundation = new DateTime(1997, 10, 16), Speciality = "IT", Director = new Director() { Lastname = "Of Rivia", Firstname = "Geralt" }, NumberOfEmployess = 3700, Adress = "India,Coimbatore,Coonoor Road, Commercial Road" });
            firms.Add(new Firm() { Name = "Guidelined", Foundation = new DateTime(2022, 6, 26), Speciality = "Insurance", Director = new Director() { Lastname = "White", Firstname = "Gordon" }, NumberOfEmployess = 780, Adress = "India,Pune,55/54, Tarwadi, Nr Loni Toll Naka Solapur Rd" });

            var allFirms = from f in firms
                           select f;
            var FoodFirms = from f in firms
                            where f.Name.Contains("Food")
                            select f;
            var MarketingFirms = from f in firms
                                 where f.Speciality == "Marketing"
                                 select f;
            var MarketingOrITFirms = from f in firms
                                     where f.Speciality == "Marketing" || f.Speciality == "IT"
                                     select f;
            var Over100Employess = from f in firms
                                     where f.NumberOfEmployess > 100
                                     select f;
            var Between100And300Employess = from f in firms
                                   where f.NumberOfEmployess >= 100 && f.NumberOfEmployess <=300
                                   select f;
            var LondonFirms = from f in firms
                            where f.Adress.Contains("London")
                            select f;
            var DirectorWhiteFirms = from f in firms
                                     where f.Director.Lastname == "White"
                                     select f;
            var FoundationOver2YearsFirms = from f in firms
                                            where DateTime.Now.Year - f.Foundation.Year > 2
                                            select f;
            var Foundation123DaysFirms = from f in firms
                                            where  DateTime.Now.Year == f.Foundation.Year&&DateTime.Now.DayOfYear - f.Foundation.DayOfYear == 123
                                            select f;
            var DirectorBlackAndFirmWhiteFirms = from f in firms
                                     where f.Director.Lastname == "Black" && f.Name.Contains("White")
                                     select f;
            foreach (var item in DirectorBlackAndFirmWhiteFirms)
            {
                Console.WriteLine(item);
            }
        }
    }

}

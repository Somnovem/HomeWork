using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class Human
    {
         int id;
         string firstname;
         string lastname;
         DateTime birthday;

        public Human() { }
        public Human(int id, string firstname, string lastname, DateTime birthday)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.birthday = birthday;
        }
        //public virtual void Print()
        //{
        //    Console.WriteLine($"First name: {firstname}");
        //    Console.WriteLine($"Last name:  {lastname}");
        //    Console.WriteLine($"ID: {id}");
        //    Console.WriteLine($"Birthday: {birthday.ToShortDateString()}");
        //}
        public override string ToString()
        {
            return $"First name: {firstname}\n" + $"Last name:  {lastname}\n" + $"ID: {id}\n" + $"Birthday: {birthday.ToShortDateString()}\n";
        }
    }

    internal class /*sealed*/ Employee :Human
    {
        int salary;
        new int id;
        public Employee() { }
        public Employee(int id, string firstname, string lastname, DateTime birthday,int salary) : base(id,firstname,lastname,birthday)
        {
            this.salary = salary;
        }
        //public virtual new void Print()
        //{
        //    base.Print();
        //    Console.WriteLine($"Salary: {salary}");
        //}
        public override string ToString()
        {
            return base.ToString() + $"Salary: {salary}\n";
        }
        public virtual void Method() { }
    }

    class Economist : Employee
    {
        int bugget;
        public Economist() { }
        public Economist(int id, string firstname, string lastname, DateTime birthday, int salary, int bugget) : base(id, firstname, lastname, birthday, salary)
        {
            this.bugget = bugget;
        }
        //public override void Print()
        //{
        //    base.Print();
        //    Console.WriteLine($"Budget: {bugget}");
        //}
        public override string ToString()
        {
            return base.ToString() + $"Budget: {bugget}\n";
        }
    }

    class Specialist : Employee
    {
        int rank;
        public Specialist() { }
        public Specialist(int id, string firstname, string lastname, DateTime birthday, int salary, int rank) : base(id, firstname, lastname, birthday, salary)
        {
            this.rank = rank;
        }
        //public override void Print()
        //{
        //    base.Print();
        //    Console.WriteLine($"Rank: {rank}");
        //}
        public override string ToString()
        {
            return base.ToString() + $"Rank: {rank} \n";
        }
    }

    class CleaningManager : Employee
    {
        int areaOfCleaning;
        public CleaningManager() { }
        public CleaningManager(int id, string firstname, string lastname, DateTime birthday, int salary, int areaOfCleaning) : base(id, firstname, lastname, birthday, salary)
        {
            this.areaOfCleaning = areaOfCleaning;
        }
        //public override void Print()
        //{
        //    base.Print();
        //    Console.WriteLine($"Area Of Cleaning: {areaOfCleaning}");
        //}
        public override void Method()
        {
            base.Method();
        }
        public override string ToString()
        {
            return base.ToString() + $"Area Of Cleaning: {areaOfCleaning} \n";
        }
    }
}

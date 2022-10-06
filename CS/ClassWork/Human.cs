using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal abstract class Human 
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
        public abstract void getSalary();
        public override string ToString()
        {
            return $"First name: {firstname}\n" + $"Last name:  {lastname}\n" + $"ID: {id}\n" + $"Birthday: {birthday.ToShortDateString()}\n";
        }
    }

    internal abstract class Employee :Human
    {
       public  int salary;
        new int id;
        public Employee() { }
        public Employee(int id, string firstname, string lastname, DateTime birthday,int salary) : base(id,firstname,lastname,birthday)
        {
            this.salary = salary;
        }

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

        public override void getSalary()
        {
            Console.WriteLine($"Economist got his {salary}");
        }

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
        public override string ToString()
        {
            return base.ToString() + $"Rank: {rank} \n";
        }
        public override void getSalary()
        {
            Console.WriteLine($"Specialist got his {salary}");
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
        public override void Method()
        {
            base.Method();
        }
        public override string ToString()
        {
            return base.ToString() + $"Area Of Cleaning: {areaOfCleaning} \n";
        }
        public override void getSalary()
        {
            Console.WriteLine($"Cleaning Master got his {salary}");
        }
    }

    class MyClass
    {
    // toString() will return the string equivalent of the name of the type/class/object 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    internal class ProgrammerAttribute : Attribute
    {
        string name = "Serg";
        DateTime date = DateTime.Now;
        public ProgrammerAttribute() { }
        public ProgrammerAttribute(string name, string d)
        {
        this.name = name;
        date = Convert.ToDateTime(d);
        }
        public override string ToString()
        {
            return $"Programmer: {name}, Date of creation: {date.ToShortDateString()}"; 
        }
    }
    class AgeValidationAttribute : Attribute
    {
    public int Age { get; }
        public AgeValidationAttribute() { }
        public AgeValidationAttribute(int a) { Age = a; }
    }
}

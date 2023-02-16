using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Ado9_1EF
{
    internal class PhonesDbContext : DbContext
    {
    }
    internal class Manufacturer
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Country { get; set; }
        public decimal Capital { get; set; }
        public string Owner { get; set; }
        public virtual ICollection<Phone> Phones { get; set; }
    }
    internal class Phone
    {
    
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Ado9_2EF
{
    internal class PhonesDbContext : DbContext
    {
        public PhonesDbContext():base("PhonesDbConnection"){}
        public PhonesDbContext(string connectionString) : base(connectionString) { }
        public DbSet<Manufacturer> manufacturers { get; set; }
        public DbSet<Phone> Phones { get; set; }
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            //builder.Entity<Manufacturer>()
            //    .ToTable("Manufacturers")
            //    .HasKey(m => m.Id);
            builder.Configurations.Add(new ManufacturerConfiguration());
            builder.Configurations.Add(new PhoneConfiguration());
        }
    }
    internal class Manufacturer
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Country { get; set; }
        public decimal Capital { get; set; }
        public string Owner { get; set; }
        public virtual ICollection<Phone> Phones { get; set; }
        public string NameAndOwner
        {
            get => $"{Fullname} ({Owner})";
        }
    }
    internal class Phone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal MemorySize { get; set; }
        public string Color { get; set; }
        public string OSName { get; set; }
        public DateTime Release { get; set; }
        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
    }        

}

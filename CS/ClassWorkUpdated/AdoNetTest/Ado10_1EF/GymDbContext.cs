using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado10_1EF
{
    internal class GymDbContext : DbContext
    {
        private string connectionString;
        public DbSet<Person> People { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public GymDbContext():this(System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection1"].ConnectionString)
        {
        }
        public GymDbContext(DbContextOptions options): base(options)
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection1"].ConnectionString;
            Database.EnsureCreated();
        }
        public GymDbContext(string connectionString)
        {
            this.connectionString = connectionString;
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder) 
        {
            //builder.UseSqlServer(connectionString);
            //builder.UseLazyLoadingProxies();
            builder
                //.UseLazyLoadingProxies()
                .UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new PersonConfiguration());
            builder.ApplyConfiguration(new TrainingConfiguration());
        }
    }
    #region db entity
    internal class Person 
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public double? Weight { get; set; }
        public bool IsTrainer { get; set; }
        public string? Email { get; set; }
        public Person(int id, string firstname, string lastname, DateTime birthdate, double? weight, bool isTrainer, string? email)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Birthdate = birthdate;
            Weight = weight;
            IsTrainer = isTrainer;
            Email = email;
            TrainingDays = new HashSet<Training>();
        }
        public Person():this(0,"noname","nolastname",DateTime.Now,null,false,null){ TrainingDays = new HashSet<Training>(); }
        public virtual ICollection<Training> TrainingDays { get; set; }
    }
    internal class Training
    {
        public int Id { get; set; }
        public DateTime DateOf { get; set; }
        public bool WithTrainer { get; set; }
        public int PersonId { get; set; }
        public virtual Person? Person { get; set; }
    }
    #endregion
}

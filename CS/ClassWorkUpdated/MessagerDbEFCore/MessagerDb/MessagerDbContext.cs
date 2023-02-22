using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagerDb
{
    internal class MessagerDbContext : DbContext
    {
        private string connectionString;
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<MessageHistory> Messages { get; set; }
        public MessagerDbContext() : this(System.Configuration.ConfigurationManager.ConnectionStrings["MessagerDbConnection"].ConnectionString)
        {
        }
        public MessagerDbContext(DbContextOptions options) : base(options)
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MessagerDbConnection"].ConnectionString;
            Database.EnsureCreated();
        }
        public MessagerDbContext(string connectionString)
        {
            this.connectionString = connectionString;
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ContactConfiguration());
            builder.ApplyConfiguration(new MessageHistoryConfiguration());
        }
    }

    internal class Contact
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string? Desctiption { get; set; }

    }
    internal class MessageHistory
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public virtual Contact? Contact { get; set; }
        public string Message { get; set; }
        public DateTime DateOf { get; set; }
    }
}

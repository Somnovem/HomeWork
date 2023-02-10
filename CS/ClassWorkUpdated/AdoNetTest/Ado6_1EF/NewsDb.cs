using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Ado6_1EF
{
    internal class NewsDb : DbContext
    {
        public NewsDb():base("NewsDbConnection") { this.Configuration.LazyLoadingEnabled = true; }
        public NewsDb(string connectionString) :base(connectionString) { }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
    internal class Article
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime DatePublished { get; set; }


        public int AuthorId { get; set; }
        [Required]
        public virtual Author Author { get; set; }

        public Article()
        {
            DatePublished = DateTime.Now;
        }
        public override string ToString()
        {
            return $"{Title}({DatePublished.ToShortDateString()}): {Description}\n By {Author.Firstname} {Author.Lastname}";
        }
    }
    internal class Author
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Firstname { get; set; }
        [Required]
        [MaxLength(150)]
        public string Lastname { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public virtual ICollection<Article> Articles{ get; set;}
        public Author()
        {
            Articles = new HashSet<Article>();
        }
        public override string ToString()
        {
            return $"{Firstname} {Lastname}: born {BirthDate.ToShortDateString()}";
        }
    }
}

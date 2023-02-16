using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GamesDbEF
{
    public class GamesDb : DbContext
    {
        public GamesDb() : base("GamesDbConnection") { }
        public GamesDb(string connectionString) : base(connectionString) { }
        public DbSet<Game> Games { get; set; }
        public DbSet<Studio> Studios { get; set; }
    }
    public class Game
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        [MaxLength(300)]
        public string Description { get; set; }
        [Required]
        [MaxLength(100)]
        public string Style { get; set; }
        [Required]
        public DateTime Release { get; set; }
        [Required]
        public int CopiesSold { get; set; }
        [Required]
        public bool SinglePlayer { get; set; }
        [Required]
        public int StudioId { get; set; }
        [Required]
        public virtual Studio Studio { get; set; }
    }
    public class Studio
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Country { get; set; }
        [Required]
        [MaxLength(100)]
        public string City { get; set; }
        public virtual ICollection<Game> Games { get; set; }
        public Studio()
        {
            Games = new HashSet<Game>();
        }
    }
}

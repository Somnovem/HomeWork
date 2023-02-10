using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    public class ChampionshipDb : DbContext
    {
        public ChampionshipDb() : base("ChampionshipDbConnection") { }
        public ChampionshipDb(string connectionString) : base(connectionString) { }
        public DbSet<Team> Teams { get; set; }
    }
    public class Team
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        [Required]
        [MaxLength(200)]
        public string City { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Ties { get; set; }
        public int GoalsScored { get; set; }
        public int GoalsMissed { get; set; }
        public override string ToString()
        {
            return $"Team:{Name} City:{City} Wins: {Wins} Losses: {Losses} Ties: {Ties} GoalsScored: {GoalsScored} GoalsMissed: {GoalsMissed}";
        }
    }
}

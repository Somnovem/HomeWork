using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    public class ChampionshipDb : DbContext
    {
        public ChampionshipDb() : base("ChampionshipDbConnection") { }
        public ChampionshipDb(string connectionString) : base(connectionString) { }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Match> Matches { get; set; }
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
        [Required]
        public int Wins { get; set; }
        [Required]
        public int Losses { get; set; }
        [Required]
        public int Ties { get; set; }
        [Required]
        public int GoalsScored { get; set; }
        [Required]
        public int GoalsMissed { get; set; }
        public override string ToString()
        {
            return $"Team:{Name} City:{City} Wins: {Wins} Losses: {Losses} Ties: {Ties} GoalsScored: {GoalsScored} GoalsMissed: {GoalsMissed}";
        }
        public virtual ICollection<Player> Players { get; set; }
        public Team()
        {
            Players = new HashSet<Player>();
        }
    }
    public class Player
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Firstname { get; set; }
        [Required]
        [MaxLength(150)]
        public string Lastname { get; set; }
        [MaxLength(150)]
        public string Fathersname { get; set; }
        [Required]
        [MaxLength(30)]
        public string Country { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        [MaxLength(20)]
        public string Position { get; set; }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
    }
    public class Match
    {
        public int Id { get; set; }
        public int Team1Id { get; set; }
        public virtual Team Team1 { get; set; }
        public int Team2Id { get; set; }
        public virtual Team Team2 { get; set; }
        [Required]
        public int GoalsScoredTeam1 { get; set; }
        [Required]
        public int GoalsScoredTeam2 { get; set; }
        [Required]
        public DateTime DateOfMatch { get; set; }
        public virtual ICollection<Player> PlayersWhoScored { get; set; }
        public Match()
        {
            PlayersWhoScored = new HashSet<Player>();
        }
    }
}

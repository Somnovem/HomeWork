using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_ChessDb
{
    internal class ChessChampionshipDbContext : DbContext
    {
        public ChessChampionshipDbContext() : base("ChessChampionshipDbConnection") { }
        public ChessChampionshipDbContext(string connectionString) : base(connectionString) { }
        public DbSet<Contestant> Contestants { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<TournamentContestant> TournamentContestants { get; set; }
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Configurations.Add(new TournamentConfiguration());
            builder.Configurations.Add(new ContestantConfiguration());
            builder.Configurations.Add(new ResultConfiguration());
            builder.Configurations.Add(new TournamentContestantConfiguration());
        }
    }
    internal class Contestant
    {
        public int Id { get; set; }
        public string Firtsname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public string Country { get; set; }
        public int Rank { get; set; }
        public virtual ICollection<Tournament> Tournaments { get; set; }
    }
    internal class Tournament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Prize { get; set; }
        public virtual ICollection<Contestant> Contestants { get; set; }
    }
    internal class Result
    {
        public int Id { get; set; }
        public int TournamentId { get; set; }
        public virtual Tournament Tournament { get; set; }
        public int WinnerId { get; set; }
        public virtual Contestant Winner { get; set; }
    }
    internal class TournamentContestant
    {
        public int Id { get; set; }
        public int Tournament_Id { get; set; }
        public int Contestant_Id { get; set; }
    }
}

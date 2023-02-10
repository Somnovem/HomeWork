using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF;
namespace TestDb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Test ChampionshipDb";
            ChampionshipDb db = new ChampionshipDb();
            //ClearTeams(db);
            //CreateSomeTeams(db);
            ShowTeams(db);
            Console.WriteLine("\npress any key...");
            Console.ReadKey();
        }
        private static void CreateSomeTeams(ChampionshipDb db)
        {
            Random r = new Random();
            int count = db.Teams.Count();
            for (int i = count + 1; i < count + 6; i++)
            {
                string name = $"test {i}";
                string city = $"city {i}";
                int wins = r.Next(0, 1000);
                int losses = r.Next(0, 1000);
                int ties = r.Next(0, 1000);
                int goalsScored = r.Next(500, 1000);
                int goalsMissed = r.Next(500, 1000);
                Team team = new Team() { Name = name, City = city, Wins = wins, Losses = losses, Ties = ties,GoalsScored = goalsScored,GoalsMissed = goalsMissed };
                db.Teams.Add(team);
            }
            db.SaveChanges();
        }
        private static void ShowTeams(ChampionshipDb db)
        {
            Console.WriteLine("All teams: ");
            Console.WriteLine("------------------------------------");
            foreach (Team team in db.Teams)
            {
                Console.WriteLine(team);
            }
            Console.WriteLine("------------------------------------");
        }
        private static void ClearTeams(ChampionshipDb db)
        {
            foreach (Team team in db.Teams)
            {
                db.Teams.Remove(team);
            }
            db.SaveChanges();
        }
    }
}

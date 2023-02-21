namespace EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fixed : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Team1Id = c.Int(nullable: false),
                        Team2Id = c.Int(nullable: false),
                        GoalsScoredTeam1 = c.Int(nullable: false),
                        GoalsScoredTeam2 = c.Int(nullable: false),
                        DateOfMatch = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.Team1Id, cascadeDelete: false)
                .ForeignKey("dbo.Teams", t => t.Team2Id, cascadeDelete: false)
                .Index(t => t.Team1Id)
                .Index(t => t.Team2Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(nullable: false, maxLength: 150),
                        Lastname = c.String(nullable: false, maxLength: 150),
                        Fathersname = c.String(maxLength: 150),
                        Country = c.String(nullable: false, maxLength: 30),
                        Number = c.Int(nullable: false),
                        Position = c.String(nullable: false, maxLength: 20),
                        TeamId = c.Int(nullable: false),
                        Match_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: false)
                .ForeignKey("dbo.Matches", t => t.Match_Id)
                .Index(t => t.TeamId)
                .Index(t => t.Match_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matches", "Team2Id", "dbo.Teams");
            DropForeignKey("dbo.Matches", "Team1Id", "dbo.Teams");
            DropForeignKey("dbo.Players", "Match_Id", "dbo.Matches");
            DropForeignKey("dbo.Players", "TeamId", "dbo.Teams");
            DropIndex("dbo.Players", new[] { "Match_Id" });
            DropIndex("dbo.Players", new[] { "TeamId" });
            DropIndex("dbo.Matches", new[] { "Team2Id" });
            DropIndex("dbo.Matches", new[] { "Team1Id" });
            DropTable("dbo.Players");
            DropTable("dbo.Matches");
        }
    }
}

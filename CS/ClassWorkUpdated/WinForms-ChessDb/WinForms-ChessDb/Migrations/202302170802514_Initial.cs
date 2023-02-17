namespace WinForms_ChessDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contestants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firtsname = c.String(nullable: false, maxLength: 100),
                        Lastname = c.String(nullable: false, maxLength: 100),
                        Birthdate = c.DateTime(nullable: false, storeType: "date"),
                        Country = c.String(nullable: false, maxLength: 20),
                        Rank = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tournaments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        StartDate = c.DateTime(nullable: false, storeType: "date"),
                        EndDate = c.DateTime(nullable: false, storeType: "date"),
                        Prize = c.Decimal(nullable: false, storeType: "money"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Results",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TournamentId = c.Int(nullable: false),
                        WinnerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tournaments", t => t.TournamentId, cascadeDelete: true)
                .ForeignKey("dbo.Contestants", t => t.WinnerId, cascadeDelete: true)
                .Index(t => t.TournamentId)
                .Index(t => t.WinnerId);
            
            CreateTable(
                "dbo.TournamentContestants",
                c => new
                    {
                        Tournament_Id = c.Int(nullable: false),
                        Contestant_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tournament_Id, t.Contestant_Id })
                .ForeignKey("dbo.Tournaments", t => t.Tournament_Id, cascadeDelete: true)
                .ForeignKey("dbo.Contestants", t => t.Contestant_Id, cascadeDelete: true)
                .Index(t => t.Tournament_Id)
                .Index(t => t.Contestant_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Results", "WinnerId", "dbo.Contestants");
            DropForeignKey("dbo.Results", "TournamentId", "dbo.Tournaments");
            DropForeignKey("dbo.TournamentContestants", "Contestant_Id", "dbo.Contestants");
            DropForeignKey("dbo.TournamentContestants", "Tournament_Id", "dbo.Tournaments");
            DropIndex("dbo.TournamentContestants", new[] { "Contestant_Id" });
            DropIndex("dbo.TournamentContestants", new[] { "Tournament_Id" });
            DropIndex("dbo.Results", new[] { "WinnerId" });
            DropIndex("dbo.Results", new[] { "TournamentId" });
            DropTable("dbo.TournamentContestants");
            DropTable("dbo.Results");
            DropTable("dbo.Tournaments");
            DropTable("dbo.Contestants");
        }
    }
}

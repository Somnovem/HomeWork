namespace WinForms_ChessDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fixed : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TournamentContestants", newName: "TournamentContestant1");
            CreateTable(
                "dbo.TournamentContestants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tournament_Id = c.Int(nullable: false),
                        Contestant_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TournamentContestants");
            RenameTable(name: "dbo.TournamentContestant1", newName: "TournamentContestants");
        }
    }
}

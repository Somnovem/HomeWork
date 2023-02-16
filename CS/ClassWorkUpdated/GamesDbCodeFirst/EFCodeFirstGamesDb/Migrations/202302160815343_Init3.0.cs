namespace EFCodeFirstGamesDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init30 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        Description = c.String(maxLength: 300),
                        Style = c.String(nullable: false, maxLength: 100),
                        Release = c.DateTime(nullable: false),
                        CopiesSold = c.Int(nullable: false),
                        SinglePlayer = c.Boolean(nullable: false),
                        StudioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Studios", t => t.StudioId, cascadeDelete: true)
                .Index(t => t.StudioId);
            
            CreateTable(
                "dbo.Studios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        Country = c.String(nullable: false, maxLength: 100),
                        City = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "StudioId", "dbo.Studios");
            DropIndex("dbo.Games", new[] { "StudioId" });
            DropTable("dbo.Studios");
            DropTable("dbo.Games");
        }
    }
}

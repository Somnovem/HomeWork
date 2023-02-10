namespace Ado6_1EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAuthorTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(nullable: false, maxLength: 150),
                        Lastname = c.String(nullable: false, maxLength: 150),
                        BirthDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Articles", "AuthorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Articles", "AuthorId");
            AddForeignKey("dbo.Articles", "AuthorId", "dbo.Authors", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Articles", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Articles", new[] { "AuthorId" });
            DropColumn("dbo.Articles", "AuthorId");
            DropTable("dbo.Authors");
        }
    }
}

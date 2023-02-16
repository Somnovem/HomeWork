namespace PhonesDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 100),
                        country = c.String(nullable: false, maxLength: 100),
                        capital = c.Decimal(nullable: false, storeType: "money"),
                        owner = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        MemorySize = c.Decimal(nullable: false, precision: 14, scale: 1),
                        Color = c.String(nullable: false, maxLength: 20),
                        OSName = c.String(maxLength: 20),
                        Release = c.DateTime(nullable: false, storeType: "date"),
                        ManufacturerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerId, cascadeDelete: true)
                .Index(t => t.ManufacturerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Phones", "ManufacturerId", "dbo.Manufacturers");
            DropIndex("dbo.Phones", new[] { "ManufacturerId" });
            DropTable("dbo.Phones");
            DropTable("dbo.Manufacturers");
        }
    }
}

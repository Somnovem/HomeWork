namespace EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingGoals : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "GoalsScored", c => c.Int(nullable: false));
            AddColumn("dbo.Teams", "GoalsMissed", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "GoalsMissed");
            DropColumn("dbo.Teams", "GoalsScored");
        }
    }
}

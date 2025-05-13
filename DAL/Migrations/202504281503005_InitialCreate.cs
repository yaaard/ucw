namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Order", new[] { "executor_ID" });
            DropIndex("dbo.Order", new[] { "feedback_ID" });
            AddColumn("dbo.Order", "progress", c => c.Int(nullable: false));
            AddColumn("dbo.Order", "IsItFinished", c => c.Boolean(nullable: false));
            AddColumn("dbo.Order", "canIdoIt", c => c.Boolean(nullable: false));
            AddColumn("dbo.Order", "OrderPosition", c => c.Int(nullable: false));
            AlterColumn("dbo.Order", "executor_ID", c => c.Int());
            AlterColumn("dbo.Order", "feedback_ID", c => c.Int());
            CreateIndex("dbo.Order", "executor_ID");
            CreateIndex("dbo.Order", "feedback_ID");
            DropColumn("dbo.Order", "executionCondition");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Order", "executionCondition", c => c.Boolean(nullable: false));
            DropIndex("dbo.Order", new[] { "feedback_ID" });
            DropIndex("dbo.Order", new[] { "executor_ID" });
            AlterColumn("dbo.Order", "feedback_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Order", "executor_ID", c => c.Int(nullable: false));
            DropColumn("dbo.Order", "OrderPosition");
            DropColumn("dbo.Order", "canIdoIt");
            DropColumn("dbo.Order", "IsItFinished");
            DropColumn("dbo.Order", "progress");
            CreateIndex("dbo.Order", "feedback_ID");
            CreateIndex("dbo.Order", "executor_ID");
        }
    }
}

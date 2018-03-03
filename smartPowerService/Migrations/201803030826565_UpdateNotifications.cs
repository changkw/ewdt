namespace smartPowerService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNotifications : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Notifications", "CurrentActivityId", "dbo.CurrentActivities");
            DropIndex("dbo.Notifications", new[] { "CurrentActivityId" });
            DropColumn("dbo.Notifications", "CurrentActivityId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Notifications", "CurrentActivityId", c => c.Int(nullable: false));
            CreateIndex("dbo.Notifications", "CurrentActivityId");
            AddForeignKey("dbo.Notifications", "CurrentActivityId", "dbo.CurrentActivities", "CurrentActivityId", cascadeDelete: true);
        }
    }
}

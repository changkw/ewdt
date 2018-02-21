namespace smartPowerService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CurrentActivities",
                c => new
                    {
                        CurrentActivityId = c.Int(nullable: false, identity: true),
                        lighting = c.Int(nullable: false),
                        machine = c.Int(nullable: false),
                        alarm = c.Int(nullable: false),
                        door = c.Int(nullable: false),
                        timeDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CurrentActivityId);
            
            CreateTable(
                "dbo.Notifications",
                c => new
                    {
                        NotificationID = c.Int(nullable: false, identity: true),
                        timeDate = c.DateTime(nullable: false),
                        CurrentActivityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NotificationID)
                .ForeignKey("dbo.CurrentActivities", t => t.CurrentActivityId, cascadeDelete: true)
                .Index(t => t.CurrentActivityId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        userID = c.Int(nullable: false, identity: true),
                        username = c.String(nullable: false),
                        user = c.String(),
                        password = c.String(),
                        number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.userID);
            
            CreateTable(
                "dbo.Works",
                c => new
                    {
                        workID = c.Int(nullable: false, identity: true),
                        startTime = c.DateTime(nullable: false),
                        endTime = c.DateTime(nullable: false),
                        userID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.workID)
                .ForeignKey("dbo.Users", t => t.userID, cascadeDelete: true)
                .Index(t => t.userID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Works", "userID", "dbo.Users");
            DropForeignKey("dbo.Notifications", "CurrentActivityId", "dbo.CurrentActivities");
            DropIndex("dbo.Works", new[] { "userID" });
            DropIndex("dbo.Notifications", new[] { "CurrentActivityId" });
            DropTable("dbo.Works");
            DropTable("dbo.Users");
            DropTable("dbo.Notifications");
            DropTable("dbo.CurrentActivities");
        }
    }
}

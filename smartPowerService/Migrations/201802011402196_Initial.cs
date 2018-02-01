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
                        Id = c.Int(nullable: false, identity: true),
                        lighting = c.Int(nullable: false),
                        machine = c.Int(nullable: false),
                        alarm = c.Int(nullable: false),
                        door = c.Int(nullable: false),
                        timeDate = c.DateTime(nullable: false),
                        workID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Works", t => t.workID)
                .Index(t => t.workID);
            
            CreateTable(
                "dbo.Works",
                c => new
                    {
                        workID = c.String(nullable: false, maxLength: 128),
                        startTime = c.DateTime(nullable: false),
                        endTime = c.DateTime(nullable: false),
                        userID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.workID)
                .ForeignKey("dbo.Users", t => t.userID, cascadeDelete: true)
                .Index(t => t.userID);
            
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
                "dbo.Notifications",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        NotificationID = c.Int(nullable: false),
                        timeDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CurrentActivities", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notifications", "Id", "dbo.CurrentActivities");
            DropForeignKey("dbo.CurrentActivities", "workID", "dbo.Works");
            DropForeignKey("dbo.Works", "userID", "dbo.Users");
            DropIndex("dbo.Notifications", new[] { "Id" });
            DropIndex("dbo.Works", new[] { "userID" });
            DropIndex("dbo.CurrentActivities", new[] { "workID" });
            DropTable("dbo.Notifications");
            DropTable("dbo.Users");
            DropTable("dbo.Works");
            DropTable("dbo.CurrentActivities");
        }
    }
}

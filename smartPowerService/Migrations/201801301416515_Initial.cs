namespace smartPowerService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
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
                        workID = c.String(nullable: false, maxLength: 128),
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
            DropIndex("dbo.Works", new[] { "userID" });
            DropTable("dbo.Works");
            DropTable("dbo.Users");
        }
    }
}

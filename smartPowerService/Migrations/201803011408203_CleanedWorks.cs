namespace smartPowerService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CleanedWorks : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Works", "userID", "dbo.Users");
            DropIndex("dbo.Works", new[] { "userID" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Works", "userID");
            AddForeignKey("dbo.Works", "userID", "dbo.Users", "userID", cascadeDelete: true);
        }
    }
}

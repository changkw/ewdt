namespace smartPowerService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedRequiredStartTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Works", "startTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Works", "startTime", c => c.DateTime(nullable: false));
        }
    }
}

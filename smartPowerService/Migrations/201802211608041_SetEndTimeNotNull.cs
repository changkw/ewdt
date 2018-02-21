namespace smartPowerService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetEndTimeNotNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Works", "endTime", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Works", "endTime", c => c.DateTime(nullable: false));
        }
    }
}

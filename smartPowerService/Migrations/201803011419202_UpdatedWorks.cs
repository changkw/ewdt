namespace smartPowerService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedWorks : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Works", "startTime", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Works", "startTime", c => c.DateTime(nullable: false));
        }
    }
}

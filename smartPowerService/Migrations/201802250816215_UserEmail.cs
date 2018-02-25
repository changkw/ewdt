namespace smartPowerService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserEmail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "email", c => c.String(nullable: false));
            DropColumn("dbo.Users", "username");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "username", c => c.String(nullable: false));
            DropColumn("dbo.Users", "email");
        }
    }
}

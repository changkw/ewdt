namespace smartPowerService.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using smartPowerService.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<smartPowerService.Models.smartPowerServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(smartPowerService.Models.smartPowerServiceContext context)
        {
            context.Users.AddOrUpdate(x => x.userID,
                new User() { userID = 1, user = "Jaaziah Chan", username = "jaazc", number = 1357 },
                new User() { userID = 2, user = "Sean Kow", username = "seank", number = 2468}

            );
            context.Works.AddOrUpdate(x => x.workID,
                new Work() { workID = "PrintDocs001", startTime = new DateTime(2017, 07, 23, 19, 30, 0), endTime = new DateTime(2017, 07, 23, 20, 30, 0), userID = 1},
                new Work() { workID = "ScanDocs001", startTime = new DateTime(2017, 07, 28, 19, 15, 0), endTime = new DateTime(2017, 07, 28, 20, 15, 0), userID = 2}
            );
        }
    }
}

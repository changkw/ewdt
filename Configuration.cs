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
                new User() { userID = 1, user = "Jaaziah Chan", username = "jaazc", number = 96470725, password = "jaaz2212" },
                new User() { userID = 2, user = "Sean Kow", username = "seank", number = 81777468, password = "sean0105" },
                new User() { userID = 2, user = "Tom Tan", username = "tommy", number = 81747468, password = "tom1234" },
                new User() { userID = 2, user = "Julianne Scot", username = "tommy", number = 81747468, password = "tom1234" },
                new User() { userID = 2, user = "Phoebe Kevin", username = "phekevin", number = 81747468, password = "phebe3124" },
                new User() { userID = 2, user = "Elijah Jennifer", username = "elijennifer", number = 81232168, password = "elijah9712" },
                new User() { userID = 2, user = "Kelsey Knox", username = "kelsknox", number = 81787538, password = "kelsey5253" },
                new User() { userID = 2, user = "Piers Martin", username = "piermartin", number = 81168768, password = "piers9178" },
                new User() { userID = 2, user = "Kiera Hubert", username = "kierhubert", number = 81258648, password = "kiera9742" },
                new User() { userID = 2, user = "Kendrick Ralph", username = "kenralph", number = 88612358, password = "ken9871" },
                new User() { userID = 2, user = "Tara Arthur", username = "taraarthur", number = 812356754, password = "tera7584" },
                new User() { userID = 2, user = "Tobin Theodora", username = "tobindora", number = 81234251, password = "tobin9172" }
                );

            context.Works.AddOrUpdate(x => x.workID,
                new Work() { workID = "PrintDocs001", startTime = new DateTime(2017, 07, 23, 19, 30, 0), endTime = new DateTime(2017, 07, 23, 20, 30, 0), userID = 1},
                new Work() { workID = "ScanDocs001", startTime = new DateTime(2017, 07, 28, 19, 15, 0), endTime = new DateTime(2017, 07, 28, 20, 15, 0), userID = 2}
            );
        }
    }
}

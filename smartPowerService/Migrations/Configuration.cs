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
                new User() { userID = 3, user = "Tom Tan", username = "tommy", number = 81747468, password = "tom1234" },
                new User() { userID = 4, user = "Julianne Scot", username = "tommy", number = 81747468, password = "tom1234" },
                new User() { userID = 5, user = "Phoebe Kevin", username = "phekevin", number = 81747468, password = "phebe3124" },
                new User() { userID = 6, user = "Elijah Jennifer", username = "elijennifer", number = 81232168, password = "elijah9712" },
                new User() { userID = 7, user = "Kelsey Knox", username = "kelsknox", number = 81787538, password = "kelsey5253" },
                new User() { userID = 8, user = "Piers Martin", username = "piermartin", number = 81168768, password = "piers9178" },
                new User() { userID = 9, user = "Kiera Hubert", username = "kierhubert", number = 81258648, password = "kiera9742" },
                new User() { userID = 10, user = "Kendrick Ralph", username = "kenralph", number = 88612358, password = "ken9871" },
                new User() { userID = 11, user = "Tara Arthur", username = "taraarthur", number = 812356754, password = "tera7584" },
                new User() { userID = 12, user = "Tobin Theodora", username = "tobindora", number = 81234251, password = "tobin9172" }
                );

            context.Works.AddOrUpdate(x => x.workID,
                new Work() { workID = "PrintDocs001", startTime = new DateTime(2017, 07, 23, 19, 30, 0), endTime = new DateTime(2017, 07, 23, 20, 30, 0), userID = 1},
                new Work() { workID = "ScanDocs001", startTime = new DateTime(2017, 07, 28, 19, 15, 0), endTime = new DateTime(2017, 07, 28, 20, 15, 0), userID = 2},
                new Work() { workID = "PrintDocs002", startTime = new DateTime(2017, 08, 03, 19, 45, 0), endTime = new DateTime(2017, 08, 03, 20, 45, 0), userID = 2},
                new Work() { workID = "PrintDocs003", startTime = new DateTime(2017, 08, 08, 19, 30, 0), endTime = new DateTime(2017, 08, 08, 20, 30, 0), userID = 3},
                new Work() { workID = "ScanDocs002", startTime = new DateTime(2017, 08, 08, 20, 45, 0), endTime = new DateTime(2017, 08, 08, 21, 45, 0), userID = 4},
                new Work() { workID = "ScanDocs004", startTime = new DateTime(2017, 08, 15, 19, 50, 0), endTime = new DateTime(2017, 08, 14, 20, 50, 0), userID = 5},
                new Work() { workID = "PrintDocs004", startTime = new DateTime(2017, 08, 15, 21, 0, 0), endTime = new DateTime(2017, 08, 15, 22, 0, 0), userID = 5},
                new Work() { workID = "PrintDocs005", startTime = new DateTime(2017, 08, 20, 20, 0, 0), endTime = new DateTime(2017, 08, 20, 21, 0, 0), userID = 6},
                new Work() { workID = "ScanDocs005", startTime = new DateTime(2017, 08, 22, 20, 0, 0), endTime = new DateTime(2017, 08, 22, 21, 0, 0), userID = 6},
                new Work() { workID = "ScanDocs006", startTime = new DateTime(2017, 08, 24, 19, 50, 0), endTime = new DateTime(2017, 08, 24, 20, 50, 0), userID = 7},
                new Work() { workID = "PrintDocs006", startTime  =new DateTime(2017, 08, 26, 20, 0, 0), endTime = new DateTime(2017, 08, 26, 21, 0, 0), userID = 8},
                new Work() { workID = "ScanDocs007", startTime = new DateTime(2017, 08, 29, 22, 0, 0), endTime = new DateTime(2017, 08, 29, 23, 0, 0), userID = 9},
                new Work() { workID = "PrintDocs007", startTime = new DateTime(2017, 08, 31, 21, 30, 0), endTime = new DateTime(2017, 08, 31, 22, 30, 0), userID = 10},
                new Work() { workID = "PrintDocs008", startTime = new DateTime(2017, 09, 02, 19, 15, 0), endTime = new DateTime(2017, 09, 02, 20, 15, 0), userID = 11},
                new Work() { workID = "ScanDocs008", startTime = new DateTime(2017, 09, 03, 19, 15, 0), endTime = new DateTime(2017, 09, 03, 20, 15, 0), userID = 11},
                new Work() { workID = "PrintDocs009", startTime = new DateTime(2017, 09, 09, 20, 30, 0), endTime = new DateTime(2017, 09, 09, 21, 30, 0), userID = 12}
            );
        }
    }
}

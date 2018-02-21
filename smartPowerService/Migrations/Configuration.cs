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
                new User() { userID = 4, user = "Julianne Scot", username = "juliscot", number = 81747468, password = "julie4567" },
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
                new Work() { workID = 1, startTime = new DateTime(2017, 07, 23, 19, 30, 0), endTime = new DateTime(2017, 07, 23, 20, 30, 0), userID = 1 },
                new Work() { workID = 2, startTime = new DateTime(2017, 07, 23, 21, 30, 0), endTime = new DateTime(2017, 07, 23, 22, 30, 0), userID = 2 },
                new Work() { workID = 3, startTime = new DateTime(2017, 07, 23, 23, 30, 0), endTime = new DateTime(2017, 07, 24, 0, 30, 0), userID = 3 }
            );

            context.CurrentActivities.AddOrUpdate(x => x.CurrentActivityId,
                new CurrentActivity() { CurrentActivityId = 1, lighting = 77, machine = 50, alarm = 5, door = 20, timeDate = new DateTime(2017, 07, 23, 20, 29, 0) },
                new CurrentActivity() { CurrentActivityId = 2, lighting = 17, machine = 76, alarm = 5, door = 0, timeDate = new DateTime(2017, 07, 23, 20, 29, 10) },
                new CurrentActivity() { CurrentActivityId = 3, lighting = 52, machine = 13, alarm = 5, door = 20, timeDate = new DateTime(2017, 07, 23, 20, 29, 20) },
                new CurrentActivity() { CurrentActivityId = 4, lighting = 30, machine = 74, alarm = 5, door = 20, timeDate = new DateTime(2017, 07, 23, 20, 29, 30) },
                new CurrentActivity() { CurrentActivityId = 5, lighting = 75, machine = 26, alarm = 5, door = 20, timeDate = new DateTime(2017, 07, 23, 20, 29, 40) },
                new CurrentActivity() { CurrentActivityId = 6, lighting = 95, machine = 31, alarm = 5, door = 20, timeDate = new DateTime(2017, 07, 23, 20, 29, 50) },
                new CurrentActivity() { CurrentActivityId = 7, lighting = 39, machine = 15, alarm = 5, door = 20, timeDate = new DateTime(2017, 07, 23, 20, 30, 0) }

            );

            context.Notifications.AddOrUpdate(x => x.NotificationID,
            new Notification() { NotificationID = 1, timeDate = new DateTime(2017, 07, 23, 19, 30, 0), CurrentActivityId = 1 }
        );
        }
    }
}

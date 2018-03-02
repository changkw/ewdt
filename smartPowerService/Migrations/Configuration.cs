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
                new User() { userID = 1, user = "Jaaziah Chan", email = "jaazc@gmail.com", number = 96470725, password = "jaaz2212" },
                new User() { userID = 2, user = "Sean Kow", email = "seank@gmail.com", number = 81777468, password = "sean0105" },
                new User() { userID = 3, user = "Tom Tan", email = "tommy@gmail.com", number = 81747468, password = "tom1234" },
                new User() { userID = 4, user = "Julianne Scot", email = "juliscot@gmail.com", number = 81747468, password = "julie4567" },
                new User() { userID = 5, user = "Phoebe Kevin", email = "phekevin@gmail.com", number = 81747468, password = "phebe3124" },
                new User() { userID = 6, user = "Elijah Jennifer", email = "elijennifer@gmail.com", number = 81232168, password = "elijah9712" },
                new User() { userID = 7, user = "Kelsey Knox", email = "kelsknox@gmail.com", number = 81787538, password = "kelsey5253" },
                new User() { userID = 8, user = "Piers Martin", email = "piermartin@gmail.com", number = 81168768, password = "piers9178" },
                new User() { userID = 9, user = "Kiera Hubert", email = "kierhubert@gmail.com", number = 81258648, password = "kiera9742" },
                new User() { userID = 10, user = "Kendrick Ralph", email = "kenralph@gmail.com", number = 88612358, password = "ken9871" },
                new User() { userID = 11, user = "Tara Arthur", email = "taraarthur@gmail.com", number = 812356754, password = "tera7584" },
                new User() { userID = 12, user = "Tobin Theodora", email = "tobindora@gmail.com", number = 81234251, password = "tobin9172" }
                );

            context.Works.AddOrUpdate(x => x.workID,
                new Work() { workID = 1, startTime = new DateTime(2017, 07, 23, 19, 30, 0), endTime = new DateTime(2017, 07, 23, 20, 30, 0), userID = 1 },
                new Work() { workID = 2, startTime = new DateTime(2017, 07, 23, 21, 30, 0), endTime = new DateTime(2017, 07, 23, 22, 30, 0), userID = 2 },
                new Work() { workID = 3, startTime = new DateTime(2017, 07, 23, 23, 30, 0), endTime = new DateTime(2017, 07, 24, 0, 30, 0), userID = 3 }
            );

            context.CurrentActivities.AddOrUpdate(x => x.CurrentActivityId,
                new CurrentActivity() { CurrentActivityId = 1, Lighting = 77, Machine = 50, Alarm = 5, Door = 20, Timedate = new DateTime(2017, 07, 23, 20, 29, 0) },
                new CurrentActivity() { CurrentActivityId = 2, Lighting = 17, Machine = 76, Alarm = 5, Door = 0, Timedate = new DateTime(2017, 07, 23, 20, 29, 10) },
                new CurrentActivity() { CurrentActivityId = 3, Lighting = 52, Machine = 13, Alarm = 5, Door = 20, Timedate = new DateTime(2017, 07, 23, 20, 29, 20) },
                new CurrentActivity() { CurrentActivityId = 4, Lighting = 30, Machine = 74, Alarm = 5, Door = 20, Timedate = new DateTime(2017, 07, 23, 20, 29, 30) },
                new CurrentActivity() { CurrentActivityId = 5, Lighting = 75, Machine = 26, Alarm = 5, Door = 20, Timedate = new DateTime(2017, 07, 23, 20, 29, 40) },
                new CurrentActivity() { CurrentActivityId = 6, Lighting = 95, Machine = 31, Alarm = 5, Door = 20, Timedate = new DateTime(2017, 07, 23, 20, 29, 50) },
                new CurrentActivity() { CurrentActivityId = 7, Lighting = 39, Machine = 15, Alarm = 5, Door = 20, Timedate = new DateTime(2017, 07, 23, 20, 30, 0) }

            );

            context.Notifications.AddOrUpdate(x => x.NotificationID,
            new Notification() { NotificationID = 1, timeDate = new DateTime(2017, 07, 23, 19, 30, 0), CurrentActivityId = 1 }
        );
        }
    }
}

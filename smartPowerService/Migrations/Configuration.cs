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
                new Work() { workID = "PrintDocs001", startTime = new DateTime(2017, 07, 23, 19, 30, 0), endTime = new DateTime(2017, 07, 23, 20, 30, 0), userID = 1 },
                new Work() { workID = "ScanDocs001", startTime = new DateTime(2017, 07, 28, 19, 15, 0), endTime = new DateTime(2017, 07, 28, 20, 15, 0), userID = 2 },
                new Work() { workID = "PrintDocs002", startTime = new DateTime(2017, 08, 03, 19, 45, 0), endTime = new DateTime(2017, 08, 03, 20, 45, 0), userID = 2 },
                new Work() { workID = "PrintDocs003", startTime = new DateTime(2017, 08, 08, 19, 30, 0), endTime = new DateTime(2017, 08, 08, 20, 30, 0), userID = 3 },
                new Work() { workID = "ScanDocs002", startTime = new DateTime(2017, 08, 08, 20, 45, 0), endTime = new DateTime(2017, 08, 08, 21, 45, 0), userID = 4 },
                new Work() { workID = "ScanDocs004", startTime = new DateTime(2017, 08, 15, 19, 50, 0), endTime = new DateTime(2017, 08, 14, 20, 50, 0), userID = 5 },
                new Work() { workID = "PrintDocs004", startTime = new DateTime(2017, 08, 15, 21, 0, 0), endTime = new DateTime(2017, 08, 15, 22, 0, 0), userID = 5 },
                new Work() { workID = "PrintDocs005", startTime = new DateTime(2017, 08, 20, 20, 0, 0), endTime = new DateTime(2017, 08, 20, 21, 0, 0), userID = 6 },
                new Work() { workID = "ScanDocs005", startTime = new DateTime(2017, 08, 22, 20, 0, 0), endTime = new DateTime(2017, 08, 22, 21, 0, 0), userID = 6 },
                new Work() { workID = "ScanDocs006", startTime = new DateTime(2017, 08, 24, 19, 50, 0), endTime = new DateTime(2017, 08, 24, 20, 50, 0), userID = 7 },
                new Work() { workID = "PrintDocs006", startTime = new DateTime(2017, 08, 26, 20, 0, 0), endTime = new DateTime(2017, 08, 26, 21, 0, 0), userID = 8 },
                new Work() { workID = "ScanDocs007", startTime = new DateTime(2017, 08, 29, 22, 0, 0), endTime = new DateTime(2017, 08, 29, 23, 0, 0), userID = 9 },
                new Work() { workID = "PrintDocs007", startTime = new DateTime(2017, 08, 31, 21, 30, 0), endTime = new DateTime(2017, 08, 31, 22, 30, 0), userID = 10 },
                new Work() { workID = "PrintDocs008", startTime = new DateTime(2017, 09, 02, 19, 15, 0), endTime = new DateTime(2017, 09, 02, 20, 15, 0), userID = 11 },
                new Work() { workID = "ScanDocs008", startTime = new DateTime(2017, 09, 03, 19, 15, 0), endTime = new DateTime(2017, 09, 03, 20, 15, 0), userID = 11 },
                new Work() { workID = "PrintDocs009", startTime = new DateTime(2017, 09, 09, 20, 30, 0), endTime = new DateTime(2017, 09, 09, 21, 30, 0), userID = 12 }
            );

            context.CurrentActivities.AddOrUpdate(x => x.Id,
                new CurrentActivity() { Id = 1, lighting = 77, machine = 50, alarm = 5, door = 20, timeDate = new DateTime(2017, 07, 23, 19, 30, 0), workID = "PrintDocs001" },
                new CurrentActivity() { Id = 2, lighting = 17, machine = 76, alarm = 5, door = 0, timeDate = new DateTime(2017, 07, 28, 19, 15, 0), workID = "ScanDocs001" },
                new CurrentActivity() { Id = 3, lighting = 52, machine = 13, alarm = 5, door = 20, timeDate = new DateTime(2017, 08, 03, 19, 45, 0), workID = "PrintDocs002" },
                new CurrentActivity() { Id = 4, lighting = 30, machine = 74, alarm = 5, door = 20, timeDate = new DateTime(2017, 08, 08, 19, 30, 0), workID = "PrintDocs003" },
                new CurrentActivity() { Id = 5, lighting = 75, machine = 26, alarm = 5, door = 20, timeDate = new DateTime(2017, 08, 08, 20, 45, 0), workID = "ScanDocs002" },
                new CurrentActivity() { Id = 6, lighting = 95, machine = 31, alarm = 5, door = 20, timeDate = new DateTime(2017, 08, 15, 19, 50, 0), workID = "ScanDocs004" },
                new CurrentActivity() { Id = 7, lighting = 39, machine = 15, alarm = 5, door = 20, timeDate = new DateTime(2017, 08, 15, 21, 0, 0), workID = "PrintDocs004" },
                new CurrentActivity() { Id = 8, lighting = 45, machine = 19, alarm = 5, door = 20, timeDate = new DateTime(2017, 08, 20, 20, 0, 0), workID = "PrintDocs005" },
                new CurrentActivity() { Id = 9, lighting = 33, machine = 14, alarm = 5, door = 20, timeDate = new DateTime(2017, 08, 24, 19, 50, 0), workID = "ScanDocs005" },
                new CurrentActivity() { Id = 10, lighting = 31, machine = 84, alarm = 5, door = 20, timeDate = new DateTime(2017, 08, 26, 20, 0, 0), workID = "ScanDocs006" },
                new CurrentActivity() { Id = 11, lighting = 51, machine = 90, alarm = 5, door = 20, timeDate = new DateTime(2017, 08, 29, 22, 0, 0), workID = "PrintDocs006" },
                new CurrentActivity() { Id = 12, lighting = 72, machine = 40, alarm = 5, door = 20, timeDate = new DateTime(2017, 09, 02, 19, 15, 0), workID = "ScanDocs007" },
                new CurrentActivity() { Id = 13, lighting = 39, machine = 21, alarm = 5, door = 20, timeDate = new DateTime(2017, 09, 03, 19, 15, 0), workID = "PrintDocs007" },
                new CurrentActivity() { Id = 14, lighting = 88, machine = 75, alarm = 5, door = 20, timeDate = new DateTime(2017, 09, 09, 20, 30, 0), workID = "PrintDocs008" },
                new CurrentActivity() { Id = 15, lighting = 65, machine = 27, alarm = 5, door = 20, timeDate = new DateTime(2017, 07, 23, 19, 30, 0), workID = "ScanDocs008" },
                new CurrentActivity() { Id = 16, lighting = 91, machine = 47, alarm = 5, door = 20, timeDate = new DateTime(2017, 07, 23, 19, 30, 0), workID = "PrintDocs009" }
            );

            context.Notifications.AddOrUpdate(x => x.NotificationID,
            new Notification() { NotificationID = 1, timeDate = new DateTime(2017, 07, 23, 19, 30, 0), Id = 1 },
            new Notification() { NotificationID = 2, timeDate = new DateTime(2017, 07, 24, 19, 30, 0), Id = 2 },
            new Notification() { NotificationID = 3, timeDate = new DateTime(2017, 07, 25, 19, 30, 0), Id = 3 },
            new Notification() { NotificationID = 4, timeDate = new DateTime(2017, 07, 26, 19, 30, 0), Id = 4 },
            new Notification() { NotificationID = 5, timeDate = new DateTime(2017, 07, 27, 19, 30, 0), Id = 5 },
            new Notification() { NotificationID = 6, timeDate = new DateTime(2017, 07, 28, 19, 30, 0), Id = 6 },
            new Notification() { NotificationID = 7, timeDate = new DateTime(2017, 07, 29, 19, 30, 0), Id = 7 },
            new Notification() { NotificationID = 8, timeDate = new DateTime(2017, 07, 30, 19, 30, 0), Id = 8 },
            new Notification() { NotificationID = 9, timeDate = new DateTime(2017, 07, 31, 19, 30, 0), Id = 9 },
            new Notification() { NotificationID = 10, timeDate = new DateTime(2017, 08, 3, 19, 30, 0), Id = 10 },
            new Notification() { NotificationID = 11, timeDate = new DateTime(2017, 08, 4, 19, 30, 0), Id = 11 },
            new Notification() { NotificationID = 12, timeDate = new DateTime(2017, 08, 7, 19, 30, 0), Id = 12 },
            new Notification() { NotificationID = 13, timeDate = new DateTime(2017, 08, 9, 19, 30, 0), Id = 13 },
            new Notification() { NotificationID = 14, timeDate = new DateTime(2017, 09, 4, 19, 30, 0), Id = 14 },
            new Notification() { NotificationID = 15, timeDate = new DateTime(2017, 09, 7, 19, 30, 0), Id = 15 },
            new Notification() { NotificationID = 16, timeDate = new DateTime(2017, 09, 15, 19, 30, 0), Id = 16 }
        );
        }
    }
}

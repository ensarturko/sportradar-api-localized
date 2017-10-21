using System.Security.Claims;
using Oregon.Data.Model.TeamProfile;

namespace Oregon.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Oregon.Data.DataContext.SportContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Oregon.Data.DataContext.SportContext context)
        {
            //context.TeamProfiles.AddOrUpdate(
            //    c => c.Statistics.Seasons.FirstOrDefault().Tournament.Category.Category2Id,
            //        new Category2
            //        {
            //            Category2Id = 1
            //        }
            //    );

            //context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}

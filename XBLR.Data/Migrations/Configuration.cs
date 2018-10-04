namespace XBLR.Data.Migrations
{
    using DataModel;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.categories.AddOrUpdate(c => c.name,
                      new Category { id = 1, name = "Main Cat1", pid = null },
                      new Category { id = 2, name = "Sub Main Cat1", pid = 1 },
                      new Category { id = 3, name = "Sub Sub", pid = 2 },
                      new Category { id = 4, name = "Main Cat2", pid = null },
                      new Category { id = 5, name = "Main Cat3", pid = null },
                      new Category { id = 6, name = "Sub Main Cat3", pid = null }
                );
        }
    }
}

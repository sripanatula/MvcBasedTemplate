namespace MvcBasedTemplate.Migrations
{
    using MvcBasedTemplate.Models;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcBasedTemplate.Models.MVCDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MvcBasedTemplate.Models.MVCDBContext";
        }

        protected override void Seed(MvcBasedTemplate.Models.MVCDBContext context)
        {
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
            context.Associations.AddOrUpdate(i => i.Name,
                new Association
                {
                    Name = "QuickJoin",
                    Address = "2528 Larchmount DR NE, Issaquah,WA,98029",
                    CreatedOn = DateTime.Now
                },
                new Association 
                { 
                    Name = "FromWithinAcademy",
                    Address = "Issaquah,WA,98029",
                    CreatedOn = DateTime.Now
                },
                new Association 
                {
                    Name = "GanaSaraswati",
                    Address = "Issaquah,WA,98029",
                    CreatedOn = DateTime.Now
                }
            );
        }
    }
}

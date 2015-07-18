namespace MvcPeople.Migrations
{
    using MvcPeople.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcPeople.Models.PeopleDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcPeople.Models.PeopleDBContext context)
        {
            context.People.AddOrUpdate(a => a.ID,
                new Person
                {
                    firstName = "Will",
                    lastName = "Cogguillo",
                    age = 23
                },
                new Person
                {
                    firstName = "Hi?",
                    lastName = "Hello",
                    age = 99
                }
            );

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

using Microsoft.AspNet.Identity;

namespace GreenHouseBulgaria.Data.Migrations
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<GreenHouseBulgaria.Data.GreenHouseBulgariaDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            
        }

        protected override void Seed(GreenHouseBulgaria.Data.GreenHouseBulgariaDbContext context)
        {
            const string defaultRole = "admin";
            const string defaultUser = "JinoIvanov";

            // This check for the role before attempting to add it.
            if (!context.Roles.Any(r => r.Name == defaultRole))
            {
                context.Roles.Add(new IdentityRole(defaultRole));
                context.SaveChanges();
            }

            // This check for the user before adding them.
            if (!context.Users.Any(u => u.UserName == defaultUser))
            {
                var store = new UserStore<User>(context);
                var manager = new UserManager<User>(store);
                var user = new User { UserName = defaultUser };
                manager.Create(user, "sotajiq");

                manager.AddToRole(user.Id, defaultRole);
            }
            else
            {
                // Just for good measure, this adds the user to the role if they already
                // existed and just weren't in the role.
                var user = context.Users.Single(u => u.UserName.Equals(defaultUser, StringComparison.CurrentCultureIgnoreCase));
                var store = new UserStore<User>(context);
                var manager = new UserManager<User>(store);
                manager.AddToRole(user.Id, defaultRole);
            }
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

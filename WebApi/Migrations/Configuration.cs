namespace WebApi.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApi.Models.Identity;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApi.Models.Identity.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApi.Models.Identity.ApplicationDbContext context)
        {
            //  Este metodo va a ser llamado despues de haber migrado a la ultima version.

            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));

            var user = new ApplicationUser()
            {
                UserName = "rex2002xp",
                Email = "rex2002xp@gmail.com",
                EmailConfirmed = true,
                FirstName = "Victor",
                LastName = "Cornejo",
                Level = 1,
                JoinDate = DateTime.Now.AddYears(-3)
            };

            manager.Create(user, "MySuperP@ssword!");
        }
    }
}

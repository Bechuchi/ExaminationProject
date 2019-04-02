using Examensarbete.Data.Identity;
using Examensarbete.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examensarbete.DataLayer
{
    public class Seeder
    {
        public static void SeedData(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager,
                                    ApplicationDbContext context)
        {
            SeedRoles(roleManager);
            SeedTopic(context);
        }

        public static void SeedTopic(ApplicationDbContext context)
        {
            var topic = new Topic();
            topic.NameContent = new Content();

            var languageContent = new LanguageContent();
            languageContent.LanguageCode = "sv";
            languageContent.Content = "Variabler";
            topic.NameContent.LanguageContent.Add(languageContent);

            languageContent = new LanguageContent();
            languageContent.LanguageCode = "fr";
            languageContent.Content = "Variabler fr";
            topic.NameContent.LanguageContent.Add(languageContent);

            context.Topic.Add(topic);
            context.SaveChanges();
        }

        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Teacher").Result)
            {
                IdentityRole newRole = new IdentityRole();
                newRole.Name = "Teacher";

                IdentityResult roleResult = roleManager.CreateAsync(newRole).Result;
            }

            if (!roleManager.RoleExistsAsync("Student").Result)
            {
                IdentityRole newRole = new IdentityRole();
                newRole.Name = "Student";

                IdentityResult roleResult = roleManager.CreateAsync(newRole).Result;
            }

            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                IdentityRole newRole = new IdentityRole();
                newRole.Name = "Admin";

                IdentityResult roleResult = roleManager.CreateAsync(newRole).Result;
            }
        }

        public static void SeedAdminRoleToUser(UserManager<ApplicationUser> userManager)
        {
            ApplicationUser user = userManager.FindByEmailAsync("denbuw@gmail.com").Result;

            if (user != null)
            {
                userManager.AddToRoleAsync(user, "Admin").Wait();
            }
        }
    }
}

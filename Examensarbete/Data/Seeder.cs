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
        public static void SeedData(UserManager<ApplicationUser> userManager,
                                    RoleManager<IdentityRole> roleManager,
                                    ApplicationDbContext context)
        {
            SeedRoles(roleManager);
            SeedTopic(context);
        }

        public static void SeedTopic(ApplicationDbContext context)
        {
            if (context.Topic.Count() > 0)
            {
                return;
            }

            var topic = new Topic();
            topic.NameContent = new Content();

            var languageContent = new LanguageContent();
            languageContent.LanguageCode = "sv";
            languageContent.Content = "Loops";
            topic.NameContent.LanguageContent.Add(languageContent);

            languageContent = new LanguageContent();
            languageContent.LanguageCode = "fr";
            languageContent.Content = "Loops fr";
            topic.NameContent.LanguageContent.Add(languageContent);

            var fact1 = new Facts();
            topic.Facts.Add(fact1);
            fact1.HeaderContent = new Content();
            fact1.BodyContent = new Content();

            languageContent = new LanguageContent();
            languageContent.LanguageCode = "sv";
            languageContent.Content = "If loop";
            fact1.HeaderContent.LanguageContent.Add(languageContent);

            languageContent = new LanguageContent();
            languageContent.LanguageCode = "fr";
            languageContent.Content = "If loop fr";
            fact1.HeaderContent.LanguageContent.Add(languageContent);

            languageContent = new LanguageContent();
            languageContent.LanguageCode = "sv";
            languageContent.Content = "Här ska if loop body vara";
            fact1.BodyContent.LanguageContent.Add(languageContent);

            languageContent = new LanguageContent();
            languageContent.LanguageCode = "fr";
            languageContent.Content = "Ici ce le if loop body";
            fact1.BodyContent.LanguageContent.Add(languageContent);

            //WHILE
            var fact2 = new Facts();
            topic.Facts.Add(fact2);
            fact2.HeaderContent = new Content();
            fact2.BodyContent = new Content();

            languageContent = new LanguageContent();
            languageContent.LanguageCode = "sv";
            languageContent.Content = "While loop";
            fact2.HeaderContent.LanguageContent.Add(languageContent);

            languageContent = new LanguageContent();
            languageContent.LanguageCode = "fr";
            languageContent.Content = "While loop fr";
            fact2.HeaderContent.LanguageContent.Add(languageContent);

            languageContent = new LanguageContent();
            languageContent.LanguageCode = "sv";
            languageContent.Content = "Här ska While loop body vara";
            fact2.BodyContent.LanguageContent.Add(languageContent);

            languageContent = new LanguageContent();
            languageContent.LanguageCode = "fr";
            languageContent.Content = "Ici ce le While loop body";
            fact2.BodyContent.LanguageContent.Add(languageContent);

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

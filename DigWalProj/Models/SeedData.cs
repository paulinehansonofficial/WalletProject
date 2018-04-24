using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using DigWalProj.Data;

namespace DigWalProj.Models
{
    public static class SeedData
    {
        public async static void Initialize(IServiceProvider serviceProvider)
        {
            
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            var user = new ApplicationUser { userID= "1", UserName = "testemail@test.com", Email = "testemail@test.com" };
            var result = await userManager.CreateAsync(user, "$69Password");

            using (var context = new DatabaseContext(
                serviceProvider.GetRequiredService<DbContextOptions<DatabaseContext>>()))
            {
                // Look for any accounts.
                if (context.ApplicationUser.Any())
                {
                    return;   // DB has been seeded
                }

                context.ApplicationUser.AddRange(
                     new ApplicationUser
                     {
                         userID = "101664287",
                         FirstName = "Michelle",
                         LastName = "Hughes",
                         PasswordHash = "AQAAAAEAACcQAAAAEOUZFC8zXn5MN8TJWbnPBIzAxFa12w9/bhV7jMgEYeeWWEPA4ycaMzqgoUSGUAS8Og=="
                     },

                    new ApplicationUser
                    {
                        userID = "109064287",
                        FirstName = "Mikaela",
                        LastName = "Howarth",
                        Email = "Mikaela@Howarth.com",
                        PasswordHash = "AQAAAAEAACcQAAAAEOUZFC8zXn5MN8TJWbnPBIzAxFa12w9/bhV7jMgEYeeWWEPA4ycaMzqgoUSGUAS8Og=="
                    },

                    new ApplicationUser
                    {
                        userID = "101622287",
                        FirstName = "Peter",
                        LastName = "Pan",
                        Email = "Peter@pan.com",
                        PasswordHash = "AQAAAAEAACcQAAAAEOUZFC8zXn5MN8TJWbnPBIzAxFa12w9/bhV7jMgEYeeWWEPA4ycaMzqgoUSGUAS8Og=="                     
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
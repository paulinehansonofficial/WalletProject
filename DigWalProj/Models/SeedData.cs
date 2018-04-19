﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace DigWalProj.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AccountContext(
                serviceProvider.GetRequiredService<DbContextOptions<AccountContext>>()))
            {
                // Look for any movies.
                if (context.Account.Any())
                {
                    return;   // DB has been seeded
                }

                context.Account.AddRange(
                     new Accounts
                     {
                         ID = 101664287,
                         FirstName = "Michelle",
                         LastName = "Hughes",
                         AccountCreated = DateTime.Now,
                         Balance = 0,
                     },

                    new Accounts
                    {
                        ID = 101664288,
                        FirstName = "Macy",
                        LastName = "Huggins",
                        AccountCreated = DateTime.Now,
                        Balance = 0,
                    },

                    new Accounts
                    {
                        ID = 109064287,
                        FirstName = "Mikaela",
                        LastName = "Howarth",
                        AccountCreated = DateTime.Now,
                        Balance = 0,
                    },

                    new Accounts
                    {
                        ID = 101754287,
                        FirstName = "Jessica",
                        LastName = "Wilson",
                        AccountCreated = DateTime.Now,
                        Balance = 0,
                    },
                    new Accounts
                    {
                        ID = 146664287,
                        FirstName = "Alison",
                        LastName = "Jeffries",
                        AccountCreated = DateTime.Now,
                        Balance = 0,
                    },
                    new Accounts
                    {
                        ID = 101677287,
                        FirstName = "Nicholas",
                        LastName = "Smith",
                        AccountCreated = DateTime.Now,
                        Balance = 0,
                    },
                    new Accounts
                    {
                        ID = 101667657,
                        FirstName = "Myles",
                        LastName = "Homo",
                        AccountCreated = DateTime.Now,
                        Balance = 0,
                    },
                    new Accounts
                    {
                        ID = 101622287,
                        FirstName = "Peter",
                        LastName = "Pan",
                        AccountCreated = DateTime.Now,
                        Balance = 0,
                    },
                    new Accounts
                    {
                        ID = 105554287,
                        FirstName = "Patrick",
                        LastName = "Stewart",
                        AccountCreated = DateTime.Now,
                        Balance = 0,
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
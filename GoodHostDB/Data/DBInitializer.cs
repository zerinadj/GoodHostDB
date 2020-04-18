using System;
using System.Linq;
using FluentAssertions.Common;
using Microsoft.Extensions.Logging;
using Projekat_1.Models;

namespace Projekat_1.Data
{
    public class DBInitializer
    {

        public static void Seed(Projekat_1Context context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var user = new User[]
            {
            new User{FirstName="Senida",LastName="Smajlovic",Username="senida567",Password="1234",Email="senida567@gmail.com",
                Created=DateTime.Parse("2020-09-01"),LastUpdate=DateTime.Parse("2020-09-01"),LastLog = DateTime.Parse("2020-09-01") } };

            
            foreach (User s in user)
            {
                
                context.Users.Add(s);
            }
            context.SaveChanges();

            
        }
    }
}
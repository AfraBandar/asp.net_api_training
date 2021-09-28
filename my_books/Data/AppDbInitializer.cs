using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using my_books.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data
{   //seeder class 
    public class AppDbInitializer
    {
        public static void Seed (IApplicationBuilder applecationBuilder)
        {   //using services scope
            using (var serviceScope = applecationBuilder.ApplicationServices.CreateScope())
            { //refrence to the context
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                //checking if there isnt any values in the db; add new values
                if (!context.Books.Any())
                {   //definging the values for the Book proprties
                    context.Books.AddRange(new Book()
                    {
                        Title = "The Alchamist",
                        Description = "text text text text",
                        IsRead = true,
                        DateRead = DateTime.Now.AddMonths(-3),
                        Rate = 4,
                        Genre = "novel",
                        Author = "Paulo Coelho",
                        CoverUrl = "https.....",
                        DateAdded = DateTime.Now
                    },
                     new Book()
                     {
                         Title = "The Stranger",
                         Description = "text text text text",
                         IsRead = false,
                         Genre = "novel",
                         Author = "albert camus ",
                         CoverUrl = "https.....",
                         DateAdded = DateTime.Now

                     });
                    context.SaveChanges();

                }
            }
        }
    }
}

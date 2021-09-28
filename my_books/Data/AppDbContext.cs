using Microsoft.EntityFrameworkCore;//important to add so we can use DbContext base class
using my_books.Data.Models;// used by Book class parameter 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data
{
    public class AppDbContext : DbContext // bridge file btween c# models and sql db tables
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Book> Books { get; set; } //<book> is the c# model and variabl Book is the name of the tabel
    }
}

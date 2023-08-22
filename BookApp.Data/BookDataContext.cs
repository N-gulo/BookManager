using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Data
{
    public class BookDataContext : DbContext
    {

        public BookDataContext(DbContextOptions<BookDataContext> options):base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();

            modelBuilder.Entity<Author>().HasData(
                    new Author
                    {
                        AuthorId = 1,
                        FullName = "William",
                        Country = "england",
                        Age = 60,
                    }
            );
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Author { get; set; }
    }
}

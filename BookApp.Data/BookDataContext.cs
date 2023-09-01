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
                        Age = 60
                    }
            );
            modelBuilder.Entity<Book>().HasData(
                    new Book
                    {
                        Id = 1,
                        ISBN = "123-456-789",
                        Title = "Grave of fireflies",
                        ShortDescription = "A very sad book like the name implies",
                        PublicationYear =   new DateTime(2010, 1, 1, 4, 0, 15).ToUniversalTime(),
                        Language = "English",
                        AuthorId = 1
                    }
            );
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Author { get; set; }
    }
}

using BookApp.Data;
using BookManager.DTOs;
using Microsoft.EntityFrameworkCore;

namespace BookManager.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookDataContext bookDataContext;

        public BookRepository(BookDataContext bookDataContext)
        {
            this.bookDataContext=bookDataContext;
        }


        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            return await bookDataContext.Books.Include(x => x.Author).ToListAsync();

        }

        public async Task<Book?> GetByIdAsync(int id)
        {
            var temp = await bookDataContext.Books.Include(x => x.Author).FirstOrDefaultAsync(x => x.Id == id);
            return  temp;
        }
        public async Task<Book> AddBook(Book book)
        {
            var result = bookDataContext.Books.Add(book);
             await bookDataContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<int> UpdateBook(Book book)
        {
            bookDataContext.Books.Update(book);
            return await bookDataContext.SaveChangesAsync();
            
        }
        public async Task<int> DeleteBook(int id)
        {
            var book = bookDataContext.Books.FirstOrDefault(x => x.Id == id);
            bookDataContext.Books.Remove(book);
            return await bookDataContext.SaveChangesAsync();

        }
        public async Task<IEnumerable<Book>> SearchTitle(string Title)
        {
            return await bookDataContext.Books.Where(s => s.Title.Contains(Title)).Include(x => x.Author).ToListAsync();
        }

    }
}

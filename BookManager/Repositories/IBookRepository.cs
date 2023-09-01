using BookApp.Data;

namespace BookManager.Repositories
{
    public interface IBookRepository
    {
        Task<Book> AddBook(Book book);
        Task<int> DeleteBook(int id);
        Task<IEnumerable<Book>> GetAllAsync();
        Task<Book?> GetByIdAsync(int id);
        Task<IEnumerable<Book>> SearchTitle(string title);
        Task<int> UpdateBook(Book book);
    }
}

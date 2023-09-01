using BookApp.Data;
using BookManager.Commands;
using BookManager.DTOs;
using BookManager.Repositories;
using MediatR;

namespace BookManager.Handlers
{
    public class InsertBookHandler : IRequestHandler<InsertBookCommand, Book>
    {
        private readonly IBookRepository bookRepository;

        public InsertBookHandler(IBookRepository bookRepository)
        {
            this.bookRepository=bookRepository;
        }

        public async Task<Book> Handle(InsertBookCommand request, CancellationToken cancellationToken)
        {
            Book bookManager = new Book
            {
                Id= request.Id,
                ISBN = request.ISBN,
                Title = request.Title,
                ShortDescription = request.ShortDescription,
                PublicationYear = DateTime.UtcNow,
                Language =  request.Language,
                AuthorId = request.AuthorId
            };

            return await bookRepository.AddBook(bookManager);
        }
    }
}

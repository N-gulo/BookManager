using BookApp.Data.Queries;
using MediatR;
using BookManager.Repositories;
using BookApp.Data;
using BookManager.Queries;
using BookManager.DTOs;
using MediatR.Wrappers;

namespace BookManager.Handlers
{
    public class GetBookByIdHandler : IRequestHandler<GetBookByIdQuery, BookDTO>
    {
        private readonly IBookRepository bookRepository;


        public GetBookByIdHandler(IBookRepository bookRepository)
        {
            this.bookRepository=bookRepository;
        }

        public async Task<BookDTO> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            var returner = await bookRepository.GetByIdAsync(request.id);
            BookDTO bookManager = new BookDTO
            {
                Id= returner.Id,
                ISBN = returner.ISBN,
                Title = returner.Title,
                ShortDescription = returner.ShortDescription,
                PublicationYear = returner.PublicationYear,
                Language =  returner.Language,
                AuthorId = returner.AuthorId,
                Author = new AuthorDTO
                {
                    FullName = returner.Author.FullName,
                    Country = returner.Author.Country,
                    Age = returner.Author.Age,
                    //Books = returner.Author.Books
                }
            };

            return bookManager;
        }
    }
}

using BookApp.Data;
using BookManager.DTOs;
using BookManager.Queries;
using BookManager.Repositories;
using MediatR;

namespace BookManager.Handlers
{
    public class SeachBookByTitleHandler : IRequestHandler<SearchBookByTitleQuery, IEnumerable<BookDTO>>
    {
        private readonly IBookRepository bookRepository;

        public SeachBookByTitleHandler(IBookRepository bookRepository)
        {
            this.bookRepository=bookRepository;
        }

        public async Task<IEnumerable<BookDTO>> Handle(SearchBookByTitleQuery request, CancellationToken cancellationToken)
        {
            var returner = await bookRepository.SearchTitle(request.Title);
            List<BookDTO> result = new List<BookDTO>();

            foreach (var item in returner)
            {
                BookDTO bookManager = new BookDTO
                {
                    Id= item.Id,
                    ISBN = item.ISBN,
                    Title = item.Title,
                    ShortDescription = item.ShortDescription,
                    PublicationYear = item.PublicationYear,
                    Language =  item.Language,
                    AuthorId = item.AuthorId,
                    Author = new AuthorDTO
                    {
                        FullName = item.Author.FullName,
                        Country = item.Author.Country,
                        Age = item.Author.Age,
                        //Books = item.Title
                    }
                };
                result.Add(bookManager);



            }
            return result;
        }
    }
}

using BookApp.Data.Queries;
using MediatR;
using BookManager.Repositories;
using Microsoft.EntityFrameworkCore;
using BookManager.DTOs;

namespace BookApp.Data.Handlers
{
    public class GetBookListHandler : IRequestHandler<GetBookListQuery, IEnumerable<BookDTO>>
    {
        private readonly IBookRepository bookRepository;

        public GetBookListHandler(IBookRepository bookRepository)
        {
            this.bookRepository=bookRepository;
        }


        public async Task<IEnumerable<BookDTO>> Handle(GetBookListQuery request, CancellationToken cancellationToken)
        {
            string keyword = "fly";
            var returner = await bookRepository.GetAllAsync();
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

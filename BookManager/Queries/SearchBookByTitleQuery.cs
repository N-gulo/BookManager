using BookApp.Data;
using BookManager.DTOs;
using MediatR;

namespace BookManager.Queries
{
    public record SearchBookByTitleQuery() : IRequest<IEnumerable<BookDTO>>
    {
        public string Title { get; set; }
    }

}

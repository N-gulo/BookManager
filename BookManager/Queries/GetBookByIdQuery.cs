using BookApp.Data;
using BookManager.DTOs;
using MediatR;

namespace BookManager.Queries
{
    public record GetBookByIdQuery() : IRequest<BookDTO>
    {
        public int id { get; set; }
    }

}

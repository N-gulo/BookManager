using BookApp.Data;
using MediatR;

namespace BookManager.Commands
{
    public record UpdateBookCommand(int Id, string ISBN, string Title, string ShortDescription, DateTime PubliccationYear, string Language, int AuthorId) : IRequest<int>;

}

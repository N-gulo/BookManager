using MediatR;

namespace BookManager.Commands
{
    public class DeleteBookCommand: IRequest<int>
    {
        public int Id { get; set; }
    }
}

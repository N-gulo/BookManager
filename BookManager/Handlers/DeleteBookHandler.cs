using BookManager.Commands;
using BookManager.Repositories;
using MediatR;

namespace BookManager.Handlers
{
    public class DeleteBookHandler : IRequestHandler<DeleteBookCommand, int>
    {
        private readonly IBookRepository bookRepository;

        public DeleteBookHandler(IBookRepository bookRepository)
        {
            this.bookRepository=bookRepository;
        }


        public async Task<int> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            var book = await bookRepository.GetByIdAsync(request.Id);
            if (book == null)
            {
                return default;
            }
             return await bookRepository.DeleteBook(request.Id);
        }
    }
}

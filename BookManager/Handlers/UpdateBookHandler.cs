using BookApp.Data;
using BookManager.Commands;
using BookManager.DTOs;
using BookManager.Repositories;
using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;


namespace BookManager.Handlers
{
    public class UpdateBookHandler : IRequestHandler<UpdateBookCommand, int>
    {
        private readonly IBookRepository bookRepository;

        public UpdateBookHandler(IBookRepository bookRepository)
        {
            this.bookRepository=bookRepository;
        }

        public async Task<int> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {

            var returner = await bookRepository.GetByIdAsync(request.Id);
            if  (returner == null)
            {
                cancellationToken.ThrowIfCancellationRequested();
            }
            returner.ISBN = request.ISBN;
            returner.Title = request.Title;
            returner.ShortDescription = request.ShortDescription;
            returner.PublicationYear = DateTime.UtcNow;
            returner.Language =  request.Language;

            return await bookRepository.UpdateBook(returner);
        }


    }
}

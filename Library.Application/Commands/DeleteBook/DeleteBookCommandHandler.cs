using Library.Infrastructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Commands.DeleteBook
{
    public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand, Unit>
    {
        private readonly LibraryDBContext _dbContext;
        public DeleteBookCommandHandler(LibraryDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            var book = _dbContext.Books.FirstOrDefault(p => p.Id == request.Id);

            if (book != null)
            {
                _dbContext.Books.Remove(book);
                await _dbContext.SaveChangesAsync(cancellationToken);
            }

            await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}

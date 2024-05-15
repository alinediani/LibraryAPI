using Library.Core.Entities;
using Library.Infrastructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Commands.CreateBook
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, int>
    {
        private readonly LibraryDBContext _dbContext;
        public CreateBookCommandHandler(LibraryDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var book = new Book(request.Title, request.Author, request.ISBN, request.YearPublication);

            await _dbContext.Books.AddAsync(book);
            await _dbContext.SaveChangesAsync();

            return book.Id;
        }
    }
}

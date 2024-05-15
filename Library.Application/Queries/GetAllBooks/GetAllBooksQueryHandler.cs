using Library.Application.ViewModels;
using Library.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Application.Queries.GetAllBooks
{
    public class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQuery, List<BooksViewModel>>
    {
        private readonly LibraryDBContext _dbContext;
        public GetAllBooksQueryHandler(LibraryDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<BooksViewModel>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            var books = _dbContext.Books;

            var booksViewModel = await books
                .Select(b => new BooksViewModel(b.Id,b.Title))
                .ToListAsync();

            return booksViewModel;
        }
    }
}

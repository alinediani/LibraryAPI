using Library.Application.ViewModels;
using Library.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Application.Queries.GetBookById
{
    public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQuery, BooksDetailsViewModel>
    {
        private readonly LibraryDBContext _dbContext;
        public GetBookByIdQueryHandler(LibraryDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<BooksDetailsViewModel> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            var book = await _dbContext.Books
                .Include(p => p.Loans)
                .SingleOrDefaultAsync(p => p.Id == request.Id);

            if (book == null) return null;

            var bookDetailsViewModel = new BooksDetailsViewModel(
                book.Id,
                book.Title,
                book.Author,
                book.ISBN,
                book.YearPublication,
                book.Status
                );

            return bookDetailsViewModel;
        }
    }
}

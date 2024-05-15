using Library.Application.ViewModels;
using Library.Core.Repositories;
using Library.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Application.Queries.GetBookById
{
    public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQuery, BooksDetailsViewModel>
    {
        private readonly IBookRepository _bookRepository;
        public GetBookByIdQueryHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<BooksDetailsViewModel> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            var book = await _bookRepository.GetDetailsByIdAsync(request.Id);

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

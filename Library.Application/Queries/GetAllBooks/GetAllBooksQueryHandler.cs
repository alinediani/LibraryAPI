using Library.Application.ViewModels;
using Library.Core.Repositories;
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
        private readonly IBookRepository _bookRepository;
        public GetAllBooksQueryHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<List<BooksViewModel>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            var books = await _bookRepository.GetAllAsync();

            var booksViewModel = books
                .Select(p => new BooksViewModel(p.Id, p.Title))
                .ToList();

            return booksViewModel;
        }
    }
}

using Library.Application.ViewModels;
using MediatR;
using System.Collections.Generic;

namespace Library.Application.Queries.GetAllBooks
{
    public class GetAllBooksQuery : IRequest<List<BooksViewModel>>
    {
        public GetAllBooksQuery(string query)
        {
            Query = query;
        }

        public string Query { get; private set; }
    }
}

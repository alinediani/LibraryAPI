using Library.Application.ViewModels;
using MediatR;

namespace Library.Application.Queries.GetBookById
{
    public class GetBookByIdQuery : IRequest<BooksDetailsViewModel>
    {
        public GetBookByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}

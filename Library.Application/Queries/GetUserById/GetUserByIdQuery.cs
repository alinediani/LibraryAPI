using Library.Application.ViewModels;
using MediatR;

namespace Library.Application.Queries.GetUserById
{
    public class GetUserByIdQuery : IRequest<UsersDetailsViewModel>
    {
        public GetUserByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}

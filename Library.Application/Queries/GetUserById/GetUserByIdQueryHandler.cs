using Library.Application.ViewModels;
using Library.Core.Repositories;
using Library.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Application.Queries.GetUserById
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UsersDetailsViewModel>
    {
        private readonly IUserRepository _userRepository;
        public GetUserByIdQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UsersDetailsViewModel> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.Id);

            if (user == null) return null;


            var userDetailsViewModel = new UsersDetailsViewModel(
                user.Id,
                user.Name,
                user.Email
                );

            return userDetailsViewModel;
        }
    }
}

using Library.Application.ViewModels;
using Library.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Application.Queries.GetUserById
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UsersDetailsViewModel>
    {
        private readonly LibraryDBContext _dbContext;
        public GetUserByIdQueryHandler(LibraryDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<UsersDetailsViewModel> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _dbContext.Users
                .Include(x => x.Loans)
                .SingleOrDefaultAsync(p => p.Id == request.Id);

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

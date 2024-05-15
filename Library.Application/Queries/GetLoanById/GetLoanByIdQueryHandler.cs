using Library.Application.ViewModels;
using Library.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Application.Queries.GetLoanById
{
    public class GetLoanByIdQueryHandler : IRequestHandler<GetLoanByIdQuery, LoansDetailsViewModel>
    {
        private readonly LibraryDBContext _dbContext;
        public GetLoanByIdQueryHandler(LibraryDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<LoansDetailsViewModel> Handle(GetLoanByIdQuery request, CancellationToken cancellationToken)
        {
            var loan = await _dbContext.Loans
                .Include(p => p.Book)
                .Include(p => p.User)
                .SingleOrDefaultAsync(p => p.Id == request.Id);

            if (loan == null) return null;

            var loanDetailsViewModel = new LoansDetailsViewModel(
                loan.Id,
                loan.IdBook,
                loan.IdUser,
                loan.Date,
                loan.Email
                );

            return loanDetailsViewModel;
        }
    }
}

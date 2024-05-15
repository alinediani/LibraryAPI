using Library.Application.ViewModels;
using Library.Core.Repositories;
using Library.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Application.Queries.GetLoanById
{
    public class GetLoanByIdQueryHandler : IRequestHandler<GetLoanByIdQuery, LoansDetailsViewModel>
    {
        private readonly ILoanRepository _loanRepository;
        public GetLoanByIdQueryHandler(ILoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }

        public async Task<LoansDetailsViewModel> Handle(GetLoanByIdQuery request, CancellationToken cancellationToken)
        {
            var loan = await _loanRepository.GetByIdAsync(request.Id);

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

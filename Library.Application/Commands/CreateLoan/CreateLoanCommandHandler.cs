using Library.Application.Commands.CreateLoan;
using Library.Core.Entities;
using Library.Infrastructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Commands.CreateLoan
{
    public class CreateLoanCommandHandler : IRequestHandler<CreateLoanCommand, int>
    {
        private readonly LibraryDBContext _dbContext;
        public CreateLoanCommandHandler(LibraryDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Handle(CreateLoanCommand request, CancellationToken cancellationToken)
        {
            var loan = new Loan(request.IdUser,request.IdBook,request.Date,request.Email);

            await _dbContext.Loans.AddAsync(loan);
            await _dbContext.SaveChangesAsync();

            return loan.Id;
        }
    }
}

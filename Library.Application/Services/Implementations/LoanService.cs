using Library.Application.InputModels;
using Library.Application.Services.Interfaces;
using Library.Core.Entities;
using Library.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Services.Implementations
{
    public class LoanService : ILoanService
    {
        public LibraryDBContext _dbContext;
        public LoanService(LibraryDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int AddLoan(NewLoanInputModel loanInputModel)
        {
            var loan = new Loan(loanInputModel.IdUser, loanInputModel.IdBook, loanInputModel.Date,loanInputModel.Email);
            _dbContext.Loans.Add(loan);
            return loan.Id;
        }
    }
}

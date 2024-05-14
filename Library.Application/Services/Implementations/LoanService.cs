using Library.Application.InputModels;
using Library.Application.Services.Interfaces;
using Library.Application.ViewModels;
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
        public IBookService _bookService;
        public LoanService(LibraryDBContext dbContext, IBookService bookService)
        {
            _dbContext = dbContext;
            _bookService = bookService;
        }
        public int AddLoan(NewLoanInputModel loanInputModel)
        {
            BooksDetailsViewModel bookViewModel = _bookService.GetABook(loanInputModel.IdBook);
            var loan = new Loan(loanInputModel.IdUser, loanInputModel.IdBook, loanInputModel.Date,loanInputModel.Email);
            _dbContext.Loans.Add(loan);
            _dbContext.SaveChanges();
            return loan.Id;
        }
    }
}

using Library.Core.Entities;
using Library.Core.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Persistence.Repositories
{
    public class LoanRepository : ILoanRepository
    {
        private readonly LibraryDBContext _dbContext;
        private readonly string _connectionString;
        public LoanRepository(LibraryDBContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _connectionString = configuration.GetConnectionString("LibraryCs");
        }

        public async Task AddAsync(Loan loan)
        {
            await _dbContext.Loans.AddAsync(loan);
            await _dbContext.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Loan> GetByIdAsync(int id)
        {
            return await _dbContext.Loans.SingleOrDefaultAsync(p => p.Id == id);
        }

    }
}

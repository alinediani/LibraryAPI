using Library.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.Core.Repositories
{
    public interface ILoanRepository
    {
        Task<Loan> GetByIdAsync(int id);
        Task AddAsync(Loan loan);
        Task SaveChangesAsync();
    }
}

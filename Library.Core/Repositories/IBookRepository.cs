using Library.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.Core.Repositories
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAllAsync();
        Task<Book> GetByIdAsync(int id);
        Task<Book> GetDetailsByIdAsync(int id);
        Task AddAsync(Book book);
        Task SaveChangesAsync();
    }
}

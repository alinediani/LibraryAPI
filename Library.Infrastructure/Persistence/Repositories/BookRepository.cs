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
    public class BookRepository : IBookRepository
    {
        private readonly LibraryDBContext _dbContext;
        private readonly string _connectionString;
        public BookRepository(LibraryDBContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _connectionString = configuration.GetConnectionString("LibraryCs");
        }

        public async Task<List<Book>> GetAllAsync()
        {
            return await _dbContext.Books.ToListAsync();
        }

        public async Task AddAsync(Book book)
        {
            await _dbContext.Books.AddAsync(book);
            await _dbContext.SaveChangesAsync();
        }


        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            return await _dbContext.Books.FirstOrDefaultAsync(p => p.Id == id);
        }
        public async Task<Book> GetDetailsByIdAsync(int id)
        {
            return await _dbContext.Books
                .Include(p => p.Loans)
                .SingleOrDefaultAsync(p => p.Id == id);
        }
    }
}

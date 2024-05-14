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
    public class BookService : IBookService
    {
        public LibraryDBContext _dbContext;
        public BookService(LibraryDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int AddBook(NewBookInputModel bookInputModel)
        {
            var book = new Book(bookInputModel.Title, bookInputModel.Author, bookInputModel.ISBN, bookInputModel.YearPublication);
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
            return book.Id;
        }
        public BooksDetailsViewModel GetABook(int id)
        {
            var book = _dbContext.Books.FirstOrDefault(x => x.Id == id);
            var booksDetailsViewsModel = new BooksDetailsViewModel(
                book.Id,
                book.Title,
                book.Author,
                book.ISBN,
                book.YearPublication,
                book.Status
                );
            return booksDetailsViewsModel;
        }
        public List<BooksViewModel> GetAllBooks(string query)
        {
            var books = _dbContext.Books;
            var booksViewModel = books.Select(s => new BooksViewModel(s.Id, s.Title)).ToList();
            return booksViewModel;
        }
        public int Delete(int id)
        {
            var book = _dbContext.Books.SingleOrDefault(p => p.Id == id);
            _dbContext.SaveChanges();
            return book.Id;
        }
    }  
}

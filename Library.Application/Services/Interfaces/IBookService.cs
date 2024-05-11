using Library.Application.InputModels;
using Library.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Services.Interfaces
{
    public interface IBookService
    {
        public int AddBook(NewBookInputModel bookInputModel);
        public BooksDetailsViewModel GetABook(int id);
        public List<BooksViewModel> GetAllBooks(string query);
        public int Delete(int id);
    }
}

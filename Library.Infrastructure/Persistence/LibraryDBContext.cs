using Library.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Persistence
{
    public class LibraryDBContext : DbContext
    {
        public LibraryDBContext()
        {
            Books = new List<Book>
            {
                new Book("Código Limpo","Robert Cecil","978-3-16-148410-0",2008)
            };
            Users = new List<User>
            {
                new User(1,"Aline","alinediani@gmail.com")
            };
            Loans = new List<Loan>
            {
                new Loan(1,1,"12/05/2024","alinediani@gmail.com")
            };
        }
        public List<Book> Books { get; set; }
        public List<User> Users { get; set; }
        public List<Loan> Loans  { get; set; }

    }
}

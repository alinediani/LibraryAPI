using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Entities
{
    public class Loan : BaseEntity
    {
        public Loan(int idUser, int idBook, string date, string email)
        {
            IdUser = idUser;
            IdBook = idBook;
            Date = date;
            Email = email;
        }

        public int IdUser { get; set; }
        public int IdBook { get; set; }
        public string Date { get; set; }
        public string Email { get; set; }
    }
}

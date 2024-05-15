using Library.Core.Entities;
using Library.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.ViewModels
{
    public class LoansDetailsViewModel
    {
        public LoansDetailsViewModel(int id, int idUser, int idBook, string date, string email)
        {
            Id = id;
            IdUser = idUser;
            IdBook = idBook;
            Date = date;
            Email = email;
            
        }

        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdBook { get; set; }
        public string Date { get; set; }
        public string Email { get; set; }

    }
}

using Library.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.ViewModels
{
    public class BooksDetailsViewModel
    {
        public BooksDetailsViewModel(int id, string title, string author, string iSBN, int yearPublication, BookStatusEnum status)
        {
            Id = id;
            Title = title;
            Author = author;
            ISBN = iSBN;
            YearPublication = yearPublication;
            Status = status;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int YearPublication { get; set; }
        public BookStatusEnum Status {  get; set; }
    }
}

using Library.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Entities
{
    public class Book : BaseEntity
    {
        

        public Book(string title, string author, string iSBN, int yearPublication)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            YearPublication = yearPublication;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int YearPublication { get; set; }
        public BookStatusEnum Status { get; private set; }
        public List<Loan> Loans { get; set; }
    }
}

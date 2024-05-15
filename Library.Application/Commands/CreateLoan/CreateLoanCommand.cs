using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Commands.CreateLoan
{
    public class CreateLoanCommand : IRequest<int>
    {
        public int IdUser { get; set; }
        public int IdBook { get; set; }
        public string Date { get; set; }
        public string Email { get; set; }
    }
}

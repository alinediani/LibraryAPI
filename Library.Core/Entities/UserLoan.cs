using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Entities
{
    public class UserLoan : BaseEntity
    {
        public UserLoan(int idUser, int idLoan)
        {
            IdUser = idUser;
            IdLoan = idLoan;
        }
        public int IdUser { get; private set; }
        public int IdLoan { get; private set; }
        public Loan Loan { get; private set; }
        public User User { get; private set; }
    }
}

﻿using Library.Application.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Services.Interfaces
{
    public interface ILoanService
    {
        public int AddLoan(NewLoanInputModel loanInputModel);
    }
}

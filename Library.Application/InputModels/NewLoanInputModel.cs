using Library.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.InputModels
{
    public class NewLoanInputModel
    {
        public int IdUser { get; set; }
        public int IdBook { get; set; }
        public string Date = DateTime.Now.ToString();
        public string Email { get; set; }
    }
}

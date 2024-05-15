using Library.Core.Entities;
using Library.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.ViewModels
{
    public class UsersDetailsViewModel
    {
        public UsersDetailsViewModel(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

    }
}

using Library.Application.InputModels;
using Library.Application.Services.Interfaces;
using Library.Core.Entities;
using Library.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        public LibraryDBContext _dbContext;
        public UserService(LibraryDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int AddUser(NewUserInputModel userInputModel)
        {
            var user = new User(userInputModel.Id, userInputModel.Name,userInputModel.Email);
            _dbContext.Users.Add(user);
            return user.Id;
        }
    }
}

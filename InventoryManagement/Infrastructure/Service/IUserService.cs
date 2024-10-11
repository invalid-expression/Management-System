using Application.Entity.Model;
using Application.Interface;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class IUserService : IUsers
    {
        private readonly ApplicationContext _applicationContext; 
        public IUserService(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public async Task<Users> CreateUser(Users users)
        { 
            var User = await _applicationContext.Users.AddAsync(users);
                       await _applicationContext.SaveChangesAsync();
            return User.Entity;
        }

        public async Task<IEnumerable<Users>> GetUserByID(int ID)
        {
            var UserData = await _applicationContext.Users.Where(x => x.Id == ID).ToListAsync();
            return UserData;
        }
    }
}

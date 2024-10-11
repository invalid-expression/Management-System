using Application.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IUsers
    {
        public Task<Users> CreateUser(Users users);
        public Task<IEnumerable<Users>> GetUserByID(int ID);
    }
}

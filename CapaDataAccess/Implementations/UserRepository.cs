using CapaDataAccess.Context;
using CapaDataAccess.Contracts;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDataAccess.Implementations
{
    public class UserRepository : GenericRepository<AplicacionDBContext, User>, IUserRepository
    {
        public User FindUser(string userName, string password)
        {
                return Context.User.SingleOrDefault(u => u.username.Equals(userName) && u.password.Equals(password));
        }
    }
}

using LibraryWebApplication.Core.Entities;
using LibraryWebApplication.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWebApplication.Infrastructure.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public Task<User> GetUserByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetUsersByUsernNameAsync(string username)
        {
            throw new NotImplementedException();
        }
    }
}

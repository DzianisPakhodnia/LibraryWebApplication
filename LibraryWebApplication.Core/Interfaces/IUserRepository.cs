using LibraryWebApplication.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWebApplication.Core.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {

        Task<User> GetUserByEmailAsync(string email);
        Task<IEnumerable<User>> GetUsersByUsernNameAsync(string username);



    }
}

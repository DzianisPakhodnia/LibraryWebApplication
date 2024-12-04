using LibraryWebApplication.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWebApplication.Core.Interfaces
{
    public class IUserRepository : IRepository<User>
    {
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task IRepository<User>.CreateAsync(User entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<User>> IRepository<User>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<User> IRepository<User>.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task IRepository<User>.UpdateAsync(User entity)
        {
            throw new NotImplementedException();
        }
    }
}

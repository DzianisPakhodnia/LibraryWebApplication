using LibraryWebApplication.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWebApplication.Core.Interfaces
{
    public class IAuthorRepository : IRepository<Author>
    {
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task IRepository<Author>.CreateAsync(Author entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Author>> IRepository<Author>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<Author> IRepository<Author>.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task IRepository<Author>.UpdateAsync(Author entity)
        {
            throw new NotImplementedException();
        }
    }
}

using LibraryWebApplication.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWebApplication.Core.Interfaces
{
    public class IBookRepository : IRepository<Book>
    {
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task IRepository<Book>.CreateAsync(Book entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Book>> IRepository<Book>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<Book> IRepository<Book>.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task IRepository<Book>.UpdateAsync(Book entity)
        {
            throw new NotImplementedException();
        }


    }
}

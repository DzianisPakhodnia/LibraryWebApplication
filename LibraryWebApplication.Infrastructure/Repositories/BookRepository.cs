using LibraryWebApplication.Core.Entities;
using LibraryWebApplication.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWebApplication.Infrastructure.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public Task<Book> GetBookByIsbnAsync(string isbn)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> GetBooksByAuthorAsync(string author)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> GetBooksByTitleAsync(string title)
        {
            throw new NotImplementedException();
        }
    }
}

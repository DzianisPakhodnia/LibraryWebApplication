using LibraryWebApplication.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWebApplication.Core.Interfaces.Repositories
{
    public interface IBookRepository : IRepository<Book>
    {

        Task<IEnumerable<Book>> GetBooksByAuthorAsync(string author);
        Task<IEnumerable<Book>> GetBooksByTitleAsync(string title);
        Task<Book> GetBookByIsbnAsync(string isbn);

    }
}

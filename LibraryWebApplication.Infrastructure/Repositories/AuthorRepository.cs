using LibraryWebApplication.Core.Entities;
using LibraryWebApplication.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWebApplication.Infrastructure.Repositories
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public Task<IEnumerable<Author>> GetAuthorsByBookTitleAsync(string bookTitle)
        {
            throw new NotImplementedException();
        }
    }
}

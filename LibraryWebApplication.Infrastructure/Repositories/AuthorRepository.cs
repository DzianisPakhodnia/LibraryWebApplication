using LibraryWebApplication.Core.Entities;
using LibraryWebApplication.Core.Interfaces.Repositories;
using LibraryWebApplication.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWebApplication.Infrastructure.Repositories
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {

        private readonly ApplicationDbContext _context;
        //public async Task<IEnumerable<Author>> GetAuthorsByBookTitleAsync(string bookTitle)
        //{
            
        //}
    }
}

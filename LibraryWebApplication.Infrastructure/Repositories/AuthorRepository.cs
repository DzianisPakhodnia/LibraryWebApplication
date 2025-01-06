using LibraryWebApplication.Core.Entities;
using LibraryWebApplication.Core.Repositories;
using LibraryWebApplication.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryWebApplication.Infrastructure.Repositories
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        private readonly ApplicationDbContext _context;

        public AuthorRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Author>> GetAuthorsByBookTitleAsync(string bookTitle)
        {
            return await _context.Authors
                                 .Where(a => a.Books.Any(b => b.Title.Contains(bookTitle)))
                                 .ToListAsync();
        }
    }
}

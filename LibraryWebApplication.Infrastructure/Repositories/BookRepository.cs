using LibraryWebApplication.Core.Entities;
using LibraryWebApplication.Core.Repositories;
using LibraryWebApplication.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWebApplication.Infrastructure.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        private readonly ApplicationDbContext _context;
        public BookRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<Book> GetBookByIsbnAsync(string isbn)
        {
            return await _context.Books.FirstOrDefaultAsync(b => b.ISBN == isbn);
        }


        public async Task<IEnumerable<Book>> GetBooksByTitleAsync(string title)
        {
            return await _context.Books.Where(b => b.Title.Contains(title)).ToListAsync();
        }

        public async Task<IEnumerable<Book>> GetBooksByAuthorAsync(string author)
        {
            return await _context.Books
                .Where(book => book.Author.Name == author)
                .ToListAsync();
        }

    }
}

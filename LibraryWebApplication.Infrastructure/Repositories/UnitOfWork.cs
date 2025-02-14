using LibraryWebApplication.Core.Repositories;
using LibraryWebApplication.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWebApplication.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
            Authors = new AuthorRepository(_context);
            Books = new BookRepository(_context);
        }
        public IUserRepository Users { get; set; }

        public IAuthorRepository Authors { get; set; }

        public IBookRepository Books { get; set; }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

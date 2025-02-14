using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWebApplication.Core.Repositories
{
    public interface IUnitOfWork
    {
        public IUserRepository Users { get; }
        public IAuthorRepository Authors { get; }
        public IBookRepository Books { get; }

        public Task SaveChangesAsync();


    }
}

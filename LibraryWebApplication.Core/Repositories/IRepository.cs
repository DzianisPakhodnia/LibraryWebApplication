using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWebApplication.Core.Repositories
{
    public interface IRepository<T>
    {
        public Task CreateAsync(T entity);
        public Task DeleteAsync(int id);
        public Task UpdateAsync(T entity);

        public Task<T> GetByIdAsync(int id);
        public Task<IEnumerable<T>> GetAllAsync();

    }
}

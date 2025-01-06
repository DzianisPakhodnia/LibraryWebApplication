using System.Collections.Generic;
using System.Threading.Tasks;
using LibraryWebApplication.Application.DTO.Author;
using LibraryWebApplication.Application.DTO.Book;
using LibraryWebApplication.Core.Entities;

namespace LibraryWebApplication.Application.Interfaces
{
    public interface IAuthorService
    {
        Task<IEnumerable<AuthorDTO>> GetAllAuthorsAsync();
        Task<AuthorDTO> GetAuthorByIdAsync(int id);

        Task AddAuthorAsync(AuthorDTO author);
        Task UpdateAuthorAsync(AuthorUpdateDTO author);
        Task DeleteAuthorAsync(int id);

        Task<IEnumerable<Book>> GetBooksByAuthorAsync(string author);
    }
}

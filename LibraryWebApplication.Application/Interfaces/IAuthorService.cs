using System.Collections.Generic;
using System.Threading.Tasks;
using LibraryWebApplication.Application.DTO.Author;
using LibraryWebApplication.Application.DTO.Book;

namespace LibraryWebApplication.Application.Interfaces
{
    public interface IAuthorService
    {
        Task<IEnumerable<AuthorDTO>> GetAllAuthorsAsync();
        Task GetAuthorByIdAsync(int id);

        Task AddAuthorAsync(AuthorDTO author);
        Task UpdateAuthorAsync(AuthorUpdateDTO author);
        Task DeleteAuthorAsync(int id);

        Task<IEnumerable<BookDTO>> GetBooksByAuthorIdAsync(int authorId);
    }
}

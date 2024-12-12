using LibraryWebApplication.Application.DTO.Book;
using LibraryWebApplication.Core.Entities;
using LibraryWebApplication.Core.Repositories;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWebApplication.Core.Interfaces.Services
{
    public interface IBookService
    {

        Task<BookDTO> GetBookByISBNAsync(int ISBN);
        
        Task<IEnumerable<BookDTO>> GetAllBooksAsync();


        Task<BookDTO> GetBookByIdAsync(int bookId);


        Task<IEnumerable<BookDTO>> SearchBooksAsync(string isbn);

        
        Task AddBookAsync(BookCreateDTO newBook);

        
        Task UpdateBookAsync(BookUpdateDTO updatedBook);

        
        Task DeleteBookAsync(int bookId);

        
        //Task LendBookAsync(LendBookDto lendBook);

        
        Task AddImageAsync(int bookId, IFormFile image);

        
        Task<bool> NotifyUserAsync(Guid bookId);
    }
}

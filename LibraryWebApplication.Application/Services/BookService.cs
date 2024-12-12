using LibraryWebApplication.Application.DTO.Book;
using LibraryWebApplication.Application.DTO.User;
using LibraryWebApplication.Application.Interfaces;
using LibraryWebApplication.Core.Entities;
using LibraryWebApplication.Core.Interfaces.Services;
using LibraryWebApplication.Core.Repositories;
using Microsoft.AspNetCore.Http;

namespace LibraryWebApplication.Application.Services
{
    public class BookService : IBookService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapperClass _mapper;
        public BookService(IUnitOfWork unitOfWork, IMapperClass mapper) 
        { 
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        
        
        }
        public async Task AddBookAsync(BookCreateDTO newBook)
        {
            var bookEntity = await _mapper.Map<BookCreateDTO, Book>(newBook);
            await _unitOfWork.Books.
                AddBookAsync(bookEntity);
            await _unitOfWork.SaveChangesAsync();
        }

        public Task AddImageAsync(int bookId, IFormFile image)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteBookAsync(int bookId)
        {
            var book = await _unitOfWork.Books.GetByIdAsync(bookId);
            if (book == null) throw new KeyNotFoundException();
            await _unitOfWork.Books.DeleteAsync(bookId);
            await _unitOfWork.SaveChangesAsync();

        }

        public async Task<IEnumerable<BookDTO>> GetAllBooksAsync()
        {
            var books = await _unitOfWork.Books.GetAllAsync();
            return await _mapper.Map<IEnumerable<Book>, IEnumerable<BookDTO>>(books);

        }

        public async Task<BookDTO> GetBookByIdAsync(int bookId)
        {
            var book = await _unitOfWork.Books.GetByIdAsync(bookId);
            if (book == null)
            {
                throw new KeyNotFoundException();
            }
            return await _mapper.Map<Book, BookDTO>(book);
        }

        public async Task<BookDTO> GetBookByISBNAsync(int ISBN)
        {
            var book = await _unitOfWork.Books.GetByIdAsync(ISBN);
            if (book == null)
            {
                throw new KeyNotFoundException();
            }
            return await _mapper.Map<Book, BookDTO>(book);
        }

        public Task<bool> NotifyUserAsync(int bookId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> NotifyUserAsync(Guid bookId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BookDTO>> SearchBooksAsync(string isbn)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBookAsync(BookUpdateDTO updatedBook)
        {
            throw new NotImplementedException();
        }
    }
}

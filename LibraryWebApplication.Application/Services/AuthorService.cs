using LibraryWebApplication.Application.DTO;
using LibraryWebApplication.Application.DTO.Author;
using LibraryWebApplication.Application.DTO.Book;
using LibraryWebApplication.Application.Interfaces;
using LibraryWebApplication.Core.Entities;
using LibraryWebApplication.Core.Repositories;
using System.Data.SqlTypes;
using System.Net;

namespace LibraryWebApplication.Application.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapperClass _mapper;
        public AuthorService(IUnitOfWork unitOfWork, IMapperClass mapper) 
        { 
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        
        }

        public async Task AddAuthorAsync(AuthorDTO author)
        {
            //var author = await _mapper.Map<AuthorCreateDTO, Author>(authorCreateDTO);
            //await _unitOfWork.Authors.CreateAsync(author);
            throw new NotImplementedException();
        }

        public async Task DeleteAuthorAsync(int id)
        {
            var author = await _unitOfWork.Authors.GetByIdAsync(id);
            if (author == null) throw new KeyNotFoundException();
            await _unitOfWork.Books.DeleteAsync(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<AuthorDTO>> GetAllAuthorsAsync()
        {
            var authors = await _unitOfWork.Authors.GetAllAsync();

            if (authors == null || !authors.Any())
            {
                return Enumerable.Empty<AuthorDTO>();
            }

            return _mapper.Map<IEnumerable<AuthorDTO>>(authors);
        }


        public async Task GetAuthorByIdAsync(int id)
        {
            var author = await _unitOfWork.Authors.GetByIdAsync(id);
            return await _mapper.Map(Author, AuthorDTO)(author);

        }
        public async Task<IEnumerable<BookDTO>> GetBooksByAuthorIdAsync(int authorId)
        {

            var ans = await _unitOfWork.Authors.GetByIdAsync(authorId);
            return await _mapper.Map(Author, AuthorDTO)(ans);
        }

        public async Task UpdateAuthorAsync(AuthorUpdateDTO authorUpdateDTO)
        {
            var ans = await _mapper.Map<AuthorUpdateDTO, Author>(authorUpdateDTO);
            await _unitOfWork.Authors.UpdateAsync(ans);
        }

       
    }
}

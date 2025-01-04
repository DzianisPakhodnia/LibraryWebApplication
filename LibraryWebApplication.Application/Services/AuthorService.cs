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
        public async Task AddAuthorAsync(AuthorDTO authorDTO)
        {
            //var author = await _mapper.Map<Author, AuthorCreateDTO>(authorDTO);
            //await _unitOfWork.Authors.CreateAsync(author);
            //throw new NotImplementedException();
        }

        public async Task DeleteAuthorAsync(int id)
        {
            var author = await _unitOfWork.Authors.GetByIdAsync(id);
            if (author == null) throw new KeyNotFoundException();
            await _unitOfWork.Authors.DeleteAsync(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<AuthorDTO>> GetAllAuthorsAsync()
        {
            var authors = await _unitOfWork.Authors.GetAllAsync();

            if (authors == null || !authors.Any())
            {
                return Enumerable.Empty<AuthorDTO>();
            }
            return await _mapper.Map<IEnumerable<Author>, IEnumerable<AuthorDTO>>(authors);
        }




        public async Task<AuthorDTO> GetAuthorByIdAsync(int id)
        {
            var author = await _unitOfWork.Authors.GetByIdAsync(id);

            if (author == null)
            {
                return null; 
            }

            return await _mapper.Map<Author, AuthorDTO>(author);
        }



        public async Task<IEnumerable<BookDTO>> GetBooksByAuthorIdAsync(int authorId)
        {

            //var author = await _unitOfWork.Authors.GetByIdAsync(authorId);


            //if (author == null)
            //{
            //    return Enumerable.Empty<BookDTO>();
            //}


            //return _mapper.Map<IEnumerable<BookDTO>>(author.Books);
            throw new NotImplementedException();
        }


        public async Task UpdateAuthorAsync(AuthorUpdateDTO authorUpdateDTO)
        {
            var ans = await _mapper.Map<AuthorUpdateDTO, Author>(authorUpdateDTO);
            await _unitOfWork.Authors.UpdateAsync(ans);
        }

        Task IAuthorService.GetAuthorByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

using LibraryWebApplication.Application.DTO;
using LibraryWebApplication.Application.Interfaces;
using LibraryWebApplication.Core.Entities;
using LibraryWebApplication.Core.Interfaces.Services;
using LibraryWebApplication.Core.Repositories;
using Microsoft.AspNetCore.Http;
using System.Security.Principal;

namespace LibraryWebApplication.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapperClass _mapper;

        public UserService(IUnitOfWork unitOfWork, IMapperClass mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task DeleteUserAsync(int id)
        {
            var user = await _unitOfWork.Users.GetByIdAsync(id);
            if (user == null) throw new KeyNotFoundException();
            await _unitOfWork.Users.DeleteAsync(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<UserDTO>> GetAllUsersAsync()
        {
            var users = await _unitOfWork.Users.GetAllAsync();
            if (users == null) throw new InvalidOperationException("No users found in the database.");
            return await _mapper.Map<IEnumerable<User>, IEnumerable<UserDTO>>(users);
        }

        public Task<UserDTO> GetUserByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<UserDTO> GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task TryAddUserAsync(UserCreateDTO userCreateDTO)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserAsync(UserUpdateDTO userUpdateDTO, IFormFile photo)
        {
            throw new NotImplementedException();
        }



    }
}

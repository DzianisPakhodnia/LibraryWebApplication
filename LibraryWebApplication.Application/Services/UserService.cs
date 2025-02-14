using LibraryWebApplication.Application.DTO.User;
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

        public async Task<UserDTO> GetUserByEmailAsync(string email)
        {
            var user = await _unitOfWork.Users.GetUserByEmailAsync(email);
            return await _mapper.Map<User, UserDTO>(user);
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _unitOfWork.Users.GetByIdAsync(id);
        }

        public async Task TryAddUserAsync(UserCreateDTO userCreateDTO)
        {
            var user = await _mapper.Map<UserCreateDTO, User>(userCreateDTO);
            await _unitOfWork.Users.CreateAsync(user);
        }

        public async Task UpdateUserAsync(UserUpdateDTO userUpdateDTO)
        {
            User user = await _unitOfWork.Users.GetByIdAsync(userUpdateDTO.Id);
            var ans = await _mapper.Update(userUpdateDTO, user);
            string id = user.Id.ToString();
            await _unitOfWork.Users.UpdateAsync(ans);
            await _unitOfWork.SaveChangesAsync();
        }



    }
}

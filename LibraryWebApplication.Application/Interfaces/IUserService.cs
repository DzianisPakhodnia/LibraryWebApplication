using LibraryWebApplication.Application.DTO.User;
using LibraryWebApplication.Core.Entities;
using Microsoft.AspNetCore.Http;

namespace LibraryWebApplication.Core.Interfaces.Services
{
    public interface IUserService
    {
        public Task<UserDTO> GetUserByEmailAsync(string email);
        public Task<User> GetUserByIdAsync(int id);
        public Task<IEnumerable<UserDTO>> GetAllUsersAsync();
        public Task TryAddUserAsync(UserCreateDTO userCreateDTO);
        public Task UpdateUserAsync(UserUpdateDTO userUpdateDTO);
        public Task DeleteUserAsync(int id);


    }
}

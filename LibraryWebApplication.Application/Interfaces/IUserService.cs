using LibraryWebApplication.Application.DTO;
using Microsoft.AspNetCore.Http;

namespace LibraryWebApplication.Core.Interfaces.Services
{
    public interface IUserService
    {
        public Task<UserDTO> GetUserByEmailAsync(string email);
        public Task<UserDTO> GetUserByIdAsync(int id);
        public Task<IEnumerable<UserDTO>> GetAllUsersAsync();


        public Task TryAddUserAsync(UserCreateDTO userCreateDTO);
        public Task UpdateUserAsync(UserUpdateDTO userUpdateDTO, IFormFile photo);
        public Task DeleteUserAsync(int id);


    }
}


using LibraryWebApplication.Application.DTO.User;
using LibraryWebApplication.Core.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace LibraryWebApplication.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserByIdAsync(int id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            return Ok(user);
        }


        [HttpGet("getByEmail/{email}")]
        public async Task<IActionResult> GetUserByEmailAsync(string email)
        {
            var user = await _userService.GetUserByEmailAsync(email);
            return Ok(user);
        }


        //[Authorize]
        [HttpGet("getAll")]
        public async Task<IActionResult> GetAllUsersAsync()
        {
            var users = await _userService.GetAllUsersAsync();
            return Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> TryAddUserAsync(UserCreateDTO userCreateDTO)
        {

            await _userService.TryAddUserAsync(userCreateDTO);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUserAsync([FromForm] UserUpdateDTO userUpdate, IFormFile photo = null)
        {
            await _userService.UpdateUserAsync(userUpdate, photo);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUserAsync(int id)
        {
            await _userService.DeleteUserAsync(id);
            return NoContent();
        }


    }

}

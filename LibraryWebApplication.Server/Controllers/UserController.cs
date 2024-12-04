
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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }


        [HttpGet("getByEmail/{email}")]
        public async Task<IActionResult> GetUserByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }


        [Authorize]
        [HttpGet("getAll")]
        public async Task<IActionResult> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> TryAddUserAsync()
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser()
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUser(int id)
        {
            throw new NotImplementedException();
        }


    }

}

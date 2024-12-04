
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace LibraryWebApplication.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost("")]
        public async Task<IActionResult> Register()
        {
            

            throw new NotImplementedException();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login()
        {
            throw new NotImplementedException();

        }

        
    }

}

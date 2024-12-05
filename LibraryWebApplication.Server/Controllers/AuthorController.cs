using Microsoft.AspNetCore.Mvc;

namespace LibraryWebApplication.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {

        // Получение списка всех авторов
        [HttpGet("getAll")]
        public async Task<IActionResult> GetAllAuthors()
        {
            throw new NotImplementedException();
        }


        // Получение автора по его Id
        [HttpGet("{id}")]

        public async Task<IActionResult> GetAuthorById(int id)
        {
            throw new NotImplementedException();
        }


        // Добавление нового автора
        [HttpPost]
        public async Task<IActionResult> AddAuthor()
        {
            throw new NotImplementedException();
        }

        // Изменение информации о существующем авторе
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAuthor()
        {
            throw new NotImplementedException();
        }

        // Удаление автора
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthor()
        {
            throw new NotImplementedException();
        }

        // Получение всех книг по автору
        [HttpGet("{id}/books")]
        public async Task<IActionResult> GetBooksByAuthor(int id)
        {
            throw new NotImplementedException();
        }








    }
}

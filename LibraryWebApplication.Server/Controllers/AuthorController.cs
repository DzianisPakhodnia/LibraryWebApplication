using LibraryWebApplication.Application.DTO.Author;
using LibraryWebApplication.Application.Interfaces;
using LibraryWebApplication.Application.Services;
using LibraryWebApplication.Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace LibraryWebApplication.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;
        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;

        }


        // Получение списка всех авторов
        [HttpGet("getAll")]
        public async Task<IActionResult> GetAllAuthors()
        {
            var authors = await _authorService.GetAllAuthorsAsync();
            return Ok(authors);
        }


        // Получение автора по его Id
        [HttpGet("{id}")]

        public async Task<IActionResult> GetAuthorById(int id)
        {
            var book = await _authorService.GetAuthorByIdAsync(id);
            return Ok(book);
        }


        // Добавление нового автора
        [HttpPost]
        public async Task<IActionResult> AddAuthor(AuthorCreateDTO AuthorCreateDTO)
        {
            await _authorService.AddAuthorAsync(AuthorCreateDTO);
            return Ok();
        }

        // Изменение информации о существующем авторе
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAuthor()
        {
            throw new NotImplementedException();
        }

        // Удаление автора
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthor(int id)
        {
            await _authorService.DeleteAuthorAsync(id);
            return NoContent();
        }

        // Получение всех книг по автору
        [HttpGet("{id}/books")]
        public async Task<IActionResult> GetBooksByAuthor(int id)
        {
            throw new NotImplementedException();
        }








    }
}

using LibraryWebApplication.Application.DTO.Author;
using LibraryWebApplication.Application.Interfaces;
using LibraryWebApplication.Application.Services;
using LibraryWebApplication.Core.Entities;
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
            var author = await _authorService.GetAuthorByIdAsync(id);

            return Ok(author);

        }

        // Добавление нового автора
        [HttpPost]
        public async Task<IActionResult> AddAuthorAsync(Author author)
        {
            await _authorService.AddAuthorAsync(author);
            return Ok(author);
        }

        // Изменение информации о существующем авторе
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAuthor(Author author)
        {
            await _authorService.UpdateAuthorAsync(author);
            return Ok(author);
        }

        // Удаление автора
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthor(int id)
        {
            await _authorService.DeleteAuthorAsync(id);
            return NoContent();
        }

        // Получение всех книг по автору
        [HttpGet("books")]
        public async Task<IActionResult> GetBooksByAuthor(string author)
        {
            var books = await _authorService.GetBooksByAuthorAsync(author);

            if (books == null || !books.Any())
            {
                return NotFound($"No books found for author with name {author}.");
            }
            return Ok(books);

        }
    }
}

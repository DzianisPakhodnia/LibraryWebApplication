using LibraryWebApplication.Application.Services;
using LibraryWebApplication.Core.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace LibraryWebApplication.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        // Получение списка всех книг
        [HttpGet("getAll")]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _bookService.GetAllBooksAsync();
            return Ok(books);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById(int id)
        {
            var book = await _bookService.GetBookByIdAsync(id);
            return Ok(book);
        }


        // Получение книги по её ISBN
        [HttpGet("isbn/{isbn}")]
        public async Task<IActionResult> GetBookByISBNAsync(int ISBN)
        {
            var book = await _bookService.GetBookByISBNAsync(ISBN);
            return Ok(book);
        }


        // Добавление новой книги
        [HttpPost]
        public async Task<IActionResult> AddBook()
        {
            throw new NotImplementedException();
        }


        // Изменение информации о существующей книге
        [HttpPut("{id}")]
        public async Task<IActionResult> ChangeInformationBook()
        {
            throw new NotImplementedException();
        }


        //Удаление книги
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook()
        {
            throw new NotImplementedException();
        }


        //Выдача книг на руки пользователю
        [HttpPost("lend")]
        public async Task<IActionResult> GiveBook()
        {
            throw new NotImplementedException();
        }


        //Добавление изображения к книге и его хранение
        [HttpPost("{id}/image")]
        public async Task<IActionResult> AddImageBook()
        {
            throw new NotImplementedException();
        }


        [HttpGet("{id}/notify")]
        public async Task<IActionResult> SendNotification()
        {
            throw new NotImplementedException();
        }




    }
}

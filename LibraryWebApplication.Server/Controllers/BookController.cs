using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryWebApplication.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {

        // Получение списка всех книг
        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            throw new NotImplementedException();
        }


        // Получение определённой книги по её Id
        [HttpGet]
        public async Task<IActionResult> GetBookById()
        {
            throw new NotImplementedException();
        }


        // Получение книги по её ISBN
        [HttpGet]
        public async Task<IActionResult> GetBookByISBN()
        {
            throw new NotImplementedException();
        }



        // Добавление новой книги
        [HttpPost]
        public async Task<IActionResult> AddBook()
        {
            throw new NotImplementedException();
        }


        // Изменение информации о существующей книге
        [HttpPut]
        public async Task<IActionResult> ChangeInformationBook()
        {
            throw new NotImplementedException();
        }


        //Удаление книги
        [HttpDelete]
        public async Task<IActionResult> DeleteBook()
        {
            throw new NotImplementedException();
        }


        //Выдача книг на руки пользователю
        [HttpPost]
        public async Task<IActionResult> GiveBook()
        {
            throw new NotImplementedException();
        }


        //Добавление изображения к книге и его хранение
        [HttpPost]
        public async Task<IActionResult> AddImageBook()
        {
            throw new NotImplementedException();
        }


        [HttpGet]
        public async Task<IActionResult> SendNotification()
        {
            throw new NotImplementedException();
        }




    }
}

using ManageLibrary.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManageLibrary.Controllers.Books
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly Library _library;

        public BookController()
        {
            _library = new Library();
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            _library.AddBook(book);
            return Ok("Book added successfully.");
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            return Ok(_library.Books);
        }
    }
}

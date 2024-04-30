using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [ApiController]
    [Route("books")]
    public class BooksController : Controller
    {
        [HttpGet("/getAllBooks")]
        public IActionResult GetAllBooks()
        {
            return View();
        }

        [HttpGet("/getABook")]
        public IActionResult GetABook()
        {
            return View();
        }

        [HttpPost("/add")]
        public IActionResult AddBook()
        {
            return View();
        }
        [HttpPut("/alter")]
        public IActionResult PutBook()
        {
            return View();
        }
        [HttpDelete("/delete")]
        public IActionResult DeleteBook()
        {
            return View();
        }
    }
}

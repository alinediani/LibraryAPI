using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [ApiController]
    [Route("books")]
    public class BooksController : Controller
    {
        [HttpGet("/get")]
        public IActionResult GetBook()
        {
            return View();
        }

        [HttpPost("/add")]
        public IActionResult PostBook()
        {
            return View();
        }
        [HttpPut("/alter")]
        public IActionResult PutBook()
        {
            return View();
        }
        [HttpDelete("/delete")]
        public IActionResult Delete()
        {
            return View();
        }
    }
}

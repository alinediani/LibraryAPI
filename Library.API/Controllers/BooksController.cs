using Library.Application.InputModels;
using Library.Application.Services.Implementations;
using Library.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : Controller
    {
        private readonly IBookService _bookService;
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] NewBookInputModel model)
        {
            if (model.Title.Length > 50)
            {
                return BadRequest(model.Title);
            }
            var id = _bookService.AddBook(model);
            return CreatedAtAction(nameof(GetById), new { id = id }, model);
        }
        [HttpGet("/get")]
        public IActionResult Get(string query)
        {
            var books = _bookService.GetAllBooks(query);
            return Ok(books);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            _bookService.GetABook(id);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _bookService.Delete(id);
            return NoContent();
        }
    }
}

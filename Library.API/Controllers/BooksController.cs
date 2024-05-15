using Library.Application.InputModels;
using Library.Application.Queries;
using Library.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Library.Application.Queries.GetAllBooks;
using Library.Application.Queries.GetBookById;
using Library.Application.Commands.CreateBook;
using Library.Application.Commands.DeleteBook;

namespace Library.API.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : Controller
    {
        private readonly IMediator _mediator;
        public BooksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string query)
        {
            var getAllBooksQuery = new GetAllBooksQuery(query);

            var books = await _mediator.Send(getAllBooksQuery);

            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetBookByIdQuery(id);

            var book = await _mediator.Send(query);

            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateBookCommand command)
        {
            if (command.Title.Length > 50)
            {
                return BadRequest();
            }

            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteBookCommand(id);

            await _mediator.Send(command);

            return NoContent();
        }
    }
}

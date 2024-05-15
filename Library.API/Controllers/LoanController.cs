using Library.Application.Commands.CreateBook;
using Library.Application.InputModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Library.Application.Commands.CreateLoan;
using Library.Application.Queries.GetLoanById;

namespace Library.API.Controllers
{
    [ApiController]
    [Route("api/loans")]
    public class LoanController : Controller
    {
        private readonly IMediator _mediator;
        public LoanController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateLoanCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetLoanByIdQuery(id);

            var loan = await _mediator.Send(query);

            if (loan == null)
            {
                return NotFound();
            }

            return Ok(loan);
        }

    }
}

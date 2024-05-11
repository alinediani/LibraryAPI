using Library.Application.InputModels;
using Library.Application.Services.Implementations;
using Library.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [ApiController]
    [Route("api/loans")]
    public class LoanController : Controller
    {
        private readonly ILoanService _loanService;
        public LoanController(ILoanService loanService)
        {
            _loanService = loanService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] NewLoanInputModel model)
        {
            var id = _loanService.AddLoan(model);
            return CreatedAtAction(nameof(model.IdBook), new { id = id }, model);
        }
       

    }
}

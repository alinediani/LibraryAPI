using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    public class LoanController : Controller
    {
        [HttpPost("/addLoan")]
        public IActionResult AddLoan()
        {
            return View();
        }

        [HttpPost("/returnBook")]
        public IActionResult ReturnBook()
        {
            return View();
        }

    }
}

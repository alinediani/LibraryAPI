using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    public class UserController : Controller
    {
        [HttpPost("/addUser")]
        public IActionResult AddUser()
        {
            return View();
        }
    }
}

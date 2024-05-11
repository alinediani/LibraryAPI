using Library.Application.InputModels;
using Library.Application.Services.Implementations;
using Library.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] NewUserInputModel model)
        {
            var id = _userService.AddUser(model);
            return CreatedAtAction(nameof(model.Id), new { id = id }, model);
        }
    }
}

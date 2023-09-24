using CursoNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace CursoNet.Controllers
{
    [Route("users")]
    public class UsersController : Controller
    {
        [Route("getList")]
        public IActionResult GetList() 
        {
            var user = new UserModel
            {
                Name = "user",
                Email = "user@gmail.com",
            };
            return View("Index", user); 
        }
    }
}

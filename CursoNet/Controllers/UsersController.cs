using CursoNet.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceCurso;

namespace CursoNet.Controllers
{
    [Route("users")]
    public class UsersController : Controller
    {
        [Route("getList")]
        public async Task<IActionResult> GetList() 
        {
            var service = new ServiceClient();
            var userFromService = await service.GetUserAsync(3);
            var user = new UserModel
            {
                Name = userFromService.Name,
                Email = userFromService.Email
            };

            return View("Index", user); 
        }
    }
}

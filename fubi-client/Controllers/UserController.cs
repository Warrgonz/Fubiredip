using Microsoft.AspNetCore.Mvc;

namespace fubi_client.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateUser()
        {
            return View();
        }
    }
}

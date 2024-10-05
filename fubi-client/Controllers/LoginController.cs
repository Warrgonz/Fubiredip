using Microsoft.AspNetCore.Mvc;

namespace fubi_client.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        
    }
}

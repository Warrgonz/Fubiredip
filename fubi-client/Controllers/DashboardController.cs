using Microsoft.AspNetCore.Mvc;

namespace fubi_client.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

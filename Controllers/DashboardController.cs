
using Microsoft.AspNetCore.Mvc;


namespace security_demo.Controllers
{

    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
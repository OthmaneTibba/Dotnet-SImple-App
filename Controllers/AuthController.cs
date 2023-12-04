using Microsoft.AspNetCore.Mvc;
using security_demo.ViewModel;

namespace security_demo.Controllers
{
    public class AuthController : Controller
    {


        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)
        {

            if (ModelState.IsValid)
            {
                return Ok();
            }

            return View(loginViewModel);

        }

    }
}
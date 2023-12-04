using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using security_demo.Models;

namespace security_demo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return RedirectToAction(controllerName: "Auth", actionName: "Login");
    }
}

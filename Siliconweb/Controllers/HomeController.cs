using Microsoft.AspNetCore.Mvc;

namespace Siliconweb.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
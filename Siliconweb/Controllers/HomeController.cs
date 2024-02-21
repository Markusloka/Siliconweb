using Microsoft.AspNetCore.Mvc;

namespace Siliconweb.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}
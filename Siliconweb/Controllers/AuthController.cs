using Microsoft.AspNetCore.Mvc;

namespace Siliconweb.Controllers;

public class AuthController : Controller
{
    // GET
    [Route("/signup")]
    public IActionResult SignUp()
    {
        return View();
    }
    

}
using Microsoft.AspNetCore.Mvc;
using Siliconweb.Models.Views;

namespace Siliconweb.Controllers;

public class AuthController : Controller
{
    // GET
    [Route("/signup")]
    [HttpGet]
    public IActionResult SignUp()
    {
        var viewModel = new SignUpViewModel();
        return View(viewModel);
    }
    
    
    [Route("/signup")]
    [HttpPost]
    public IActionResult SignUp(SignUpViewModel model)
    {
        return View();
    }
    

}
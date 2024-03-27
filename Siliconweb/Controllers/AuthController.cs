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
    public IActionResult SignUp(SignUpViewModel viewModel)
    {
        if(!ModelState.IsValid)
            return View(viewModel);

        return RedirectToAction("SignIn", "Auth");
    }
    
    
    [Route("/signin")]
    [HttpGet]
    public IActionResult SignIn()
    {
        var viewModel = new SignInViewModel();
        return View(viewModel);
    }

    [Route("/signin")]
    [HttpPost]
    public IActionResult SignIn(SignInViewModel viewModel)
    {
        if (!ModelState.IsValid)
        {
            return View(viewModel);
        }

        // var result = _authService.SignIn(viewModel.Form);
        // if (result)
            //return RedirectToAction("Account", "Index");

        viewModel.ErrorMessage = "Incorrect email or password";
        return View(viewModel);

       
    }

}
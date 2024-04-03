using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using Siliconweb.ViewModels;

namespace Siliconweb.Controllers;

public class AuthController(UserService userService) : Controller
{

    private readonly UserService _userService = userService;

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
    public async Task<IActionResult> SignUp(SignUpViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            var result = await _userService.CreateUserAsync(viewModel.Form);
            if (result.StatusCode == Infrastructure.Models.StatusCode.OK)
                return RedirectToAction("SignIn", "Auth");
        }

        return View(viewModel);
    }
    
    
    [Route("/signin")]
    [HttpGet]
    public IActionResult SignIn()
    {
        var viewModel = new SignInViewModel();
        return View(viewModel);
    }
    

}
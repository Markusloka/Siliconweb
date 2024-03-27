using Microsoft.AspNetCore.Mvc;
using Siliconweb.ViewModels;

namespace Siliconweb.Controllers;

public class AccountController : Controller
{
    //private readonly AccountService _accountService;

    // public AccountController(AccountService accountService)
    // {
    //    _accountService = accountService;
    // }

[Route("/account")]
public IActionResult Details ()
{
   var viewModel = new AccountDetailsViewModel();
    return View(viewModel);
}


    [HttpPost]
    public IActionResult BasicInfo(AccountDetailsViewModel viewModel)
    {

        return RedirectToAction(nameof(Details));
    }
}
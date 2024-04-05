using Microsoft.AspNetCore.Mvc;
using Siliconweb.Models.Sections;
using Siliconweb.ViewModels;

namespace Siliconweb.Controllers;

public class HomeController : Controller
{
    public IActionResult Home()
    {

        var viewModel = new HomeIndexViewModel
        {
            Title = "Ultimate Task Management Assistant",
            Showcase = new ShowcaseViewModel
            {
                Id = "Showcase",
                ShowcaseImage = new() { ImageUrl = "./images/hometop/hometopbkimage.svg", AltText = "Showcase image"},
                Title = "Task Management Assistant you gonna love",
                Text = "We offer you a new generation of task management system. Plan, manage & track all your tasks in one flexible tool",
                Link = new() { ControllerName = "Downloads", ActionName = "Index", Text = "Get started for free" },
                LargestBrandText = "Largest companies use our tool to work efficently",
                
               
            }
        };
        

        ViewData["Title"] = viewModel.Title;

        return View(viewModel);
    }
}
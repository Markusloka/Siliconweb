using Siliconweb.Models.Sections;

namespace Siliconweb.ViewModels;

public class HomeIndexViewModel
{
    public string Title { get; set; } = "";

    public ShowcaseViewModel Showcase { get; set; } = null!;
}

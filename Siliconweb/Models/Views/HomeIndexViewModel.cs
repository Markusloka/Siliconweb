using Siliconweb.Models.Sections;

namespace Siliconweb.Models.Views;

public class HomeIndexViewModel
{
    public string Title { get; set; } = "";

    public ShowcaseViewModel Showcase { get; set; } = null!;
}

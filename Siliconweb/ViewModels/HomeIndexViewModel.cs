using Infrastructure.Entities;
using Infrastructure.Services;
using Siliconweb.Models.Sections;

namespace Siliconweb.ViewModels;

public class HomeIndexViewModel
{
    private readonly FeatureService _featureService;

    public HomeIndexViewModel(FeatureService featureService)
    {
        _featureService = featureService;
        
        Task.Run(async () =>
        {
            var result = await _featureService.GetAllFeaturesAsync();
            var content = (FeatureEntity)result.ContentResult!;

            Features.Title = content.Title;
            Features.Ingress = content.Ingress;

            foreach (var item in content.FeatureItems)
                Features.FeatureItems.Add(item);
        });
    }

    public FeaturesViewModel Features { get; set; } = new FeaturesViewModel();
    public string Title { get; set; } = "";
    public ShowcaseViewModel Showcase { get; set; } = null!;
}



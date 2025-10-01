using JadooTravel.Services.FeatureServices;
using Microsoft.AspNetCore.Mvc;

namespace JadooTravel.ViewComponents
{
    public class _DefaultFeatureComponentPartial:ViewComponent
    {
        private readonly IFeatureService _featureService;

        public _DefaultFeatureComponentPartial(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _featureService.GetAllFeatureAsync();
            var firstFeature = values.FirstOrDefault(); // ilk kaydı al
            if (firstFeature != null && firstFeature.VideoUrl.Contains("watch?v="))
            {
                firstFeature.VideoUrl = firstFeature.VideoUrl.Replace("watch?v=", "embed/");
            }

            return View(firstFeature);
        }
    }
}

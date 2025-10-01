using JadooTravel.Services.TestPlanServices;
using Microsoft.AspNetCore.Mvc;

namespace JadooTravel.ViewComponents
{
    public class _DefaultCategoryComponentPartial:ViewComponent
    {
        private readonly ITripPlanService _tripPlanService;

        public _DefaultCategoryComponentPartial(ITripPlanService tripPlanService)
        {
            _tripPlanService = tripPlanService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _tripPlanService.GetAllTripPlanAsync();
            return View(values);
        }
    }
}

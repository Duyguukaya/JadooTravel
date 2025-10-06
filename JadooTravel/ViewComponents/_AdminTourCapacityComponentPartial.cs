using Microsoft.AspNetCore.Mvc;

namespace JadooTravel.ViewComponents
{
    public class _AdminTourCapacityComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

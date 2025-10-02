using JadooTravel.Dtos.RezervationDtos;
using Microsoft.AspNetCore.Mvc;

namespace JadooTravel.ViewComponents
{
    public class _DefaultBookingStepsComponentPartial:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            var model = new CreateRezervationDto(); // boş model oluştur
            return View(model); // View'e gönder
        }
    }
}

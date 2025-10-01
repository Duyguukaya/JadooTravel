using JadooTravel.Dtos.RezervationDtos;
using JadooTravel.Services.RezervationServices;
using Microsoft.AspNetCore.Mvc;

namespace JadooTravel.Controllers
{

        public class RezervationController : Controller
        {
            private readonly IRezervationService _rezervationService;

            public RezervationController(IRezervationService rezervationService)
            {
                _rezervationService = rezervationService;
            }

            public async Task<IActionResult> RezervationList()
            {
                var values = await _rezervationService.GetAllRezervationAsync();
                return View(values); // Listeyi View’e gönder
            }

            [HttpPost]
            public async Task<IActionResult> CreateRezervation(CreateRezervationDto model)
            {
                if (!ModelState.IsValid)
                {
                    return RedirectToAction("RezervationList");
                }

                await _rezervationService.CreateRezervationAsync(model);
                return RedirectToAction("RezervationList"); // Kaydet sonra listeye dön
            }
        }

    }


using JadooTravel.Services.DestinationServices;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using JadooTravel.Services.TestimonialServices;

namespace JadooTravelCore.Controllers
{
    public class AdminController : Controller
    {
        private readonly IDestinationService _destinationService;
        private readonly ITestimonialService _testimonialService;

        public AdminController(IDestinationService destinationService, ITestimonialService testimonialService)
        {
            _destinationService = destinationService;
            _testimonialService = testimonialService;
        }


        public async Task<IActionResult> AdminDashboard()
        {
            var destinations = await _destinationService.GetAllDestinationAsync();
            var testimonials = await _testimonialService.GetAllTestimonialsAsync();

            ViewBag.LastFiveTours = destinations.OrderByDescending(x => x.DestinationId).Take(5).ToList();

            ViewBag.LastFourTestimonials = testimonials
       .OrderByDescending(x => x.TestimonialId) // veya eklenme tarihine göre
       .Take(4)
       .ToList();

            // Chart için JSON verisi (kapasite ve fiyat)
            var chartData = new
            {
                names = destinations.Select(x => x.CityCountry).ToList(),
                capacities = destinations.Select(x => x.Capacity).ToList(),
                prices = destinations.Select(x => x.Price).ToList()
            };
            ViewBag.ChartData = JsonConvert.SerializeObject(chartData);

            // Toplam kazanılan para
            var totalMoney = destinations.Sum(x => x.Price * x.Capacity);
            ViewBag.TotalMoney = totalMoney;

            // Turlara göre para dağılımı
            var moneyByTour = destinations.Select(x => new {
                Name = x.CityCountry,
                Value = x.Price * x.Capacity
            }).ToList();
            ViewBag.MoneyByTour = JsonConvert.SerializeObject(moneyByTour);

            // -------------------------------
            // En yüksek ve en düşük fiyatlı tur
            // -------------------------------
            if (destinations.Any())
            {
                var highestTour = destinations.OrderByDescending(x => x.Price).First();
                var lowestTour = destinations.OrderBy(x => x.Price).First();

                ViewBag.HighestTour = new
                {
                    Name = highestTour.CityCountry,
                    Price = highestTour.Price
                };

                ViewBag.LowestTour = new
                {
                    Name = lowestTour.CityCountry,
                    Price = lowestTour.Price
                };
            }
            else
            {
                ViewBag.HighestTour = new { Name = "-", Price = 0 };
                ViewBag.LowestTour = new { Name = "-", Price = 0 };
            }

            return View(destinations);
        }

    }
}

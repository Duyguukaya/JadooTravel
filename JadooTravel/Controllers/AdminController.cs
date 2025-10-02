using Microsoft.AspNetCore.Mvc;

namespace JadooTravel.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AdminDashboard()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace AppProductBooking.Areas.Home.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

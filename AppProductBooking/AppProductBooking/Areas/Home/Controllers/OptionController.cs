using Microsoft.AspNetCore.Mvc;

namespace AppProductBooking.Areas.Home.Controllers
{
    public class OptionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

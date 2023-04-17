using Microsoft.AspNetCore.Mvc;

namespace AppProductBooking.Areas.Requesting.Controllers
{
    [Area("Requesting")]
    public class RequestingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

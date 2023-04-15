using Microsoft.AspNetCore.Mvc;

namespace AppProductBooking.Areas.Manager.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

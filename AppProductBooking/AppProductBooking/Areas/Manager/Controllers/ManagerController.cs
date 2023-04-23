using AppProductBooking.Areas.Manager.Service;
using Microsoft.AspNetCore.Mvc;

namespace AppProductBooking.Areas.Manager.Controllers
{
    [Area("Manager")]
    public class ManagerController : Controller
    {
        #region [Properties]

        #endregion

        #region [Construtor]
        public ManagerController()
        {

        }
        #endregion

        #region [ActionResult]
        public IActionResult Index()
        {
            this.ExistsEmail("sistemas.celis@gmail.com");
            return View();
        }
        #endregion

        #region [ActionResult]
        [HttpGet]
        public JsonResult ExistsEmail(string email)
        {
            var response = ManagerService.ExistsEmail(email);
            return Json(response);
        }
        #endregion
    }
}

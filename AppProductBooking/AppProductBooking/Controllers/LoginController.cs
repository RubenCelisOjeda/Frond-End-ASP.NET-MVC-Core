using Microsoft.AspNetCore.Mvc;

namespace AppProductBooking.Controllers
{
    public class LoginController : Controller
    {
        #region [Properties]

        #endregion

        #region [Constructor]
        public LoginController()
        {

        }

        #endregion

        #region [ActionResult]
        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region [JsonResult]
        [HttpPost]
        public JsonResult Login([FromBody] string pEntidad)
        {
            return Json("");
        }
        #endregion
    }
}

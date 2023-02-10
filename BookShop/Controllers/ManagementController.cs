using Microsoft.AspNetCore.Mvc;

namespace BookShop.Controllers
{
    public class ManagementController : Controller
    {
        public IActionResult Statistic()
        {
            return View("~/Views/Statistic/Statistic.cshtml");
        }

        public IActionResult SupperAdmin()
        {
            return View("~/Views/SupperAdmin/Index.cshtml");
        }
    }
}

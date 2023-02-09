using Microsoft.AspNetCore.Mvc;

namespace BookShop.Controllers
{
    public class SupplierController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

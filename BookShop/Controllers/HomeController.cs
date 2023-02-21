using BookShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Book()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string a)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

    }
}
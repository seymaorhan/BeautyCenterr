using BeautyCenter.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BeautyCenter.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

<<<<<<< HEAD

=======
        public IActionResult Hakkimizda()
        {
            return View();
        }
>>>>>>> c91b211720e667e2ac71a17b46f0a82de2989d01

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

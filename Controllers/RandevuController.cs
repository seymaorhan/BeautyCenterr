using Microsoft.AspNetCore.Mvc;

namespace BeautyCenter.Controllers
{
    public class RandevuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

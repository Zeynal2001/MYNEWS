using Microsoft.AspNetCore.Mvc;

namespace MYNEWS.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Single()
        {
            return View();
        }
    }
}
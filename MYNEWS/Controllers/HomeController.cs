using Microsoft.AspNetCore.Mvc;
using MYNEWS.Models;
using System.Diagnostics;

namespace MYNEWS.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            ViewData["title"] = "Home";
            return View();
        }


        public IActionResult Contact()
        {
            ViewData["title"] = "Contact";
            return View();
            //return RedirectToAction("Index");
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}

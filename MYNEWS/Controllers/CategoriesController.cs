using Microsoft.AspNetCore.Mvc;

namespace MYNEWS.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            ViewData["title"] = "Categories";
            return View();
        }



        //public IActionResult Pagination() 
        //{
        //    return View();
        //}
    }
}

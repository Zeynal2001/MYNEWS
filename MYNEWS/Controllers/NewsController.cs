﻿using Microsoft.AspNetCore.Mvc;

namespace MYNEWS.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            ViewData["title"] = "News";
            return View();
        }

        public IActionResult Single(string newsId)
        {
            ViewData["title"] = "Single";
            return View();
        }
    }
}
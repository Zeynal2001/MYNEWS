﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MYNEWS.Data;
using MYNEWS.Entities;
using MYNEWS.Models;
using MYNEWS.ViewModels;
using System.Diagnostics;

namespace MYNEWS.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        private readonly AppDbContext _context;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        
        //private readonly ILogger<HomeController> _logger;

        public IActionResult Index()
        {
            ViewData["title"] = "Home";

            //var news = _context.News.Select(n =>  new { n.Title, n.Content });
            // trending news
            // ViewsCount


            List<SliderItem> trendingnNews = _context.News.Where(n => !string.IsNullOrWhiteSpace(n.PhotoPathForTrending))
                .OrderByDescending(n => n.ViewsCount)
                .Take(4)
                .Select(n => new SliderItem()
                {
                    NewsId = n.Id,
                    Title = n.Title,
                    PhotoPathForTrending = n.PhotoPathForTrending,
                    CreatedAt = n.CreatedAt
                })
                .ToList();

            /*
            var news = _context.News.Include(n => n.Category).ToList();
            var sliderItemsList = new List<SliderItem>();

            foreach (var dnews in news)
            {
                var sliderItem = new SliderItem()
                {
                    NewsId = dnews.Id,
                    Title = dnews.Title,
                    CreatedAt = dnews.CreatedAt,
                    PhotoPathSingleBig = dnews.PhotoPathSingleBig,
                    Categories = dnews.Category.CategoryName
                };
            }
            */


            List<SliderItem> recentNews = _context.News.Where(n => !string.IsNullOrWhiteSpace(n.PhotoPathSingleBig))
                .OrderByDescending (n => n.CreatedAt)
                .Take(2)
                .Select(n => new SliderItem()
                {
                    NewsId= n.Id,
                    Title = n.Title,
                    PhotoPathSingleBig = n.PhotoPathSingleBig,
                    Categories = n.Category.CategoryName,
                    CreatedAt = n.CreatedAt
                })
                .ToList();


            List<CategoryModel> categories = _context.Categories.Where(c => !string.IsNullOrWhiteSpace(c.LongPhotoPathForCategories))
                .Take(4)
                .Select(c => new CategoryModel()
                {
                    Id = c.Id,
                    Name = c.CategoryName,
                    LongPhotoPathForCategories = c.LongPhotoPathForCategories
                })
                .ToList();


            HomeIndexVm vm = new HomeIndexVm()
            {
                TrendingNews = trendingnNews,
                RecentNews = recentNews,
                Categories = categories,
            };

            return View(vm);
            /*
            var trendingnNews = _context.News.PhotoPathForTrending.OrderByDescending(n => n.ViewsCount)
                .Take(4)
                .Select(n =>  new SliderItem()
                {
                    NewsId = n.Id,
                    Title = n.Title,
                    PhotoPathForTrending = n.PhotoPathForTrending,
                    //PhotoPathSingleBig = n.PhotoPathSingleBig,
                    //LongPhotoPathForCategories = n.LongPhotoPathForCategories,
                    //PhotoPathForFeatured = n.PhotoPathForFeatured,
                    //PhotoPathForCategories = n.PhotoPathForCategories,
                    //Categories = n.Category.CategoryName,
                    CreatedAt = n.CreatedAt
                })
            .ToList();
            */

            /*
            public string? PhotoPathForTrending { get; set; }
            public string? PhotoPathSingleBig { get; set; }
            public string? LongPhotoPathForCategories { get; set; }
            public string? PhotoPathForFeatured { get; set; }
            public string? PhotoPathForCategories { get; set; }
            */
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

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MYNEWS.Data;
using MYNEWS.Entities;
using MYNEWS.Models;
using MYNEWS.ViewModels;
using System.Diagnostics;
using System.Linq;

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

        public async Task<IActionResult> Index()
        {
            ViewData["title"] = "Home";

            //var news = _context.News.Select(n =>  new { n.Title, n.Content });
            // trending news
            // ViewsCount


            List<SliderItem> trendingnNews = await _context.News.Where(n => !string.IsNullOrWhiteSpace(n.PhotoPathForTrending))
                .OrderByDescending(n => n.ViewsCount)
                .Take(4)
                .Select(n => new SliderItem()
                {
                    NewsId = n.Id,
                    Title = n.Title,
                    PhotoPathForTrending = n.PhotoPathForTrending,
                    CreatedAt = n.CreatedAt
                })
                .ToListAsync();

            ViewData["trending"] = trendingnNews;

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

            List<SliderItem> recentNews = await _context.News.Where(n => !string.IsNullOrWhiteSpace(n.PhotoPathSingleBig))
                .OrderByDescending (n => n.CreatedAt)
                .Take(2)
                .Select(n => new SliderItem()
                {
                    NewsId= n.Id,
                    Title = n.Title,
                    PhotoPathSingleBig = n.PhotoPathSingleBig,
                    Category = n.Category.CategoryName,
                    CategoryId = n.Category.Id.ToString(),
                    CreatedAt = n.CreatedAt
                })
                .ToListAsync();


            List<CategoryModel> categories = await _context.Categories.Where(c => !string.IsNullOrWhiteSpace(c.LongPhotoPathForCategories))
                .Take(4)
                .Select(c => new CategoryModel()
                {
                    Id = c.Id,
                    Name = c.CategoryName,
                    LongPhotoPathForCategories = c.LongPhotoPathForCategories
                })
                .ToListAsync();

            //var categoriescount = categories.Count;
            //categories.Take(categoriescount);

            List<SliderItem> featuredNews = await _context.News.Where(n => !string.IsNullOrWhiteSpace (n.PhotoPathForFeatured))
                .OrderByDescending(n => n.CreatedAt)
                .OrderByDescending(n => n.ViewsCount)
                .Take(8)
                .Select(n => new SliderItem()
                {
                    NewsId = n.Id,
                    Title = n.Title,
                    PhotoPathForFeatured = n.PhotoPathForFeatured,
                    Category = n.Category.CategoryName,
                    CategoryId = n.Category.Id.ToString(),
                    CreatedAt = n.CreatedAt
                })
                .ToListAsync();

            /*Union un musbet ceheti odur ki, databaza ya sadece bir sorgu gedir.
            var categoryNews =  await _context.News.
                Union(_context.News.Where(x => x.Category.CategoryName == "Business").OrderByDescending(n => n.CreatedAt).Take(5).ToList())
                .Union(_context.News.Where(n => n.Category.CategoryName == "Entertainment").OrderByDescending(n => n.CreatedAt).Take(5).ToList()
                .Union(_context.News.Where(n => n.Category.CategoryName == "Sports").OrderByDescending(n => n.CreatedAt).Take(5).ToList())
                .Union(_context.News.Where(n => n.Category.CategoryName == "Technology").OrderByDescending(n => n.CreatedAt).Take(5).ToList()))
                .Select(n => new SliderItem()
                {
                    NewsId = n.Id,
                    Title = n.Title,
                    PhotoPathForCategories = n.PhotoPathForCategories,
                    Categories = n.Category.CategoryName,
                    CreatedAt = n.CreatedAt
                })
                .ToListAsync();
            */

            HomeIndexVm vm = new HomeIndexVm()
            {
                TrendingNews = trendingnNews,
                RecentNews = recentNews,
                Categories = categories,
                FeaturedNews = featuredNews,
                //CategoryNews = categoryNews
            };

            return View(vm);
        }


        public IActionResult Contact()
        {
            ViewData["title"] = "Contact";
            return View();
            //return RedirectToAction("Index");
        }


        public IActionResult Search(string query, int page = 1)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                ViewData["msg"] = "Query can't be empity";
                return View("Error");
            }


            int size = 5;

            var news = _context.News
                .Skip((page - 1) * size)
                .Take(size)
                .Where(n => n.Title.ToLower().Contains(query.ToLower()) ||
                                                n.Content.ToLower().Contains(query.ToLower()) ||
                                                n.Category.CategoryName.ToLower().Contains(query.ToLower()) ||
                                                n.Subcategory.SubcategoryName.ToLower().Contains(query.ToLower()) ||
                                                n.NewsTags.Any(tags => tags.TagName.ToLower().Contains(query.ToLower()))
                                                )
                .Select(n => new SliderItem()
                {
                    NewsId = n.Id,
                    Title = n.Title,
                    PhotoPathSingleBig = n.PhotoPathSingleBig,
                    PhotoPathForCategories = n.PhotoPathForCategories,
                    PhotoPathForTrending = n.PhotoPathForTrending,
                    PhotoPathForFeatured = n.PhotoPathForFeatured,
                    Category = n.Category.CategoryName,
                    CategoryId = n.Category.Id.ToString(),
                    CreatedAt = n.CreatedAt
                }).ToList();

            var totalNews = _context.News.Where(n => n.Title.ToLower().Contains(query.ToLower()) ||
                                                n.Content.ToLower().Contains(query.ToLower()) ||
                                                n.Category.CategoryName.ToLower().Contains(query.ToLower()) ||
                                                n.Subcategory.SubcategoryName.ToLower().Contains(query.ToLower()) ||
                                                n.NewsTags.Any(tags => tags.TagName.ToLower().Contains(query.ToLower()))
                                                ).Count();



            var sm = new SearchModel()
            {
                CurrentPage = page,
                PageCount = (int)Math.Ceiling(totalNews / (double)size),
                FoundNews = news,
                Query = query
            };
            
            return View(sm);
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}

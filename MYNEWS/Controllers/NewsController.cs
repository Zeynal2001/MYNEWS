using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MYNEWS.Data;
using MYNEWS.Entities;
using MYNEWS.Models;
using MYNEWS.ViewModels;
using System;

namespace MYNEWS.Controllers
{
    public class NewsController : Controller
    {
        public NewsController(AppDbContext context)
        {
            _context = context;
        }

        private readonly AppDbContext _context;


        public IActionResult Index()
        {
            ViewData["title"] = "News";
            return View();
        }

        public IActionResult Single(string newsId)
        {
            ViewData["title"] = "Single";

            Guid id;
            if (string.IsNullOrWhiteSpace(newsId) || !Guid.TryParse(newsId, out id))
            {
                ViewData["msg"] = "There aren't such news";
                return View("Error");
            }

            //var news = _context.News.Find(id); // ancaq id deyeri ucun isleyir
            //var news = _context.News.Where(g => g.Id == id).FirstOrDefault();
            //var news = _context.News.FirstOrDefault(n => n.Id == id);
            Entities.News? news = _context.News
                .Include(n => n.Category)
                .Include(n => n.NewsTags)
                .Include(n => n.Authors)
                .FirstOrDefault(n => n.Id == id);


            if (news == null)
            {
                ViewData["msg"] = "There aren't such news";
                return View("Error");
            }

            news.ViewsCount++;
            _context.SaveChanges();

            NewsSingle details = new NewsSingle()
            {
                Id = news.Id.ToString(),
                Title = news.Title,
                PhotoPathSingleBig = news.PhotoPathSingleBig,
                PhotoPathForTrending = news.PhotoPathForTrending,
                PhotoPathForCategories = news.PhotoPathForCategories,
                PhotoPathForFeatured = news.PhotoPathForFeatured,
                Content = news.Content,
                Category = news.Category.CategoryName,
                CreatedAt = news.CreatedAt,
                Tags = news.NewsTags.Select(t => t.TagName).ToString(),
                ViewsCount = news.ViewsCount,
                AuthorFirstName = news.Authors.Select(a => a.AuthorFirstName).ToString(),
                AuthorLastName =  news.Authors.Select(a => a.AuthorLastName).ToString()
            };
            

            var relatedNews = new List<RelatedNews>();

            //Bu bizə seçilən xəbərin kateqoriyası ilə eyni kateqoriyada olan xəbərləri RelatedNews dən bir obyekt'ə qoyub/təyin edib, List kimi verəcək
            var related = _context.News.Include(n => n.Category)
                .Where(n => n.Category.CategoryName == news.Category.CategoryName && news.Id != n.Id)
                .Take(5)
                .Select(n => new RelatedNews()
                {
                    Id = n.Id.ToString(),
                    PhotoPathLikeForTrending = n.PhotoPathForTrending,
                    Title = n.Title,
                    Category = n.Category.CategoryName,
                    CreatedAt = n.CreatedAt,
                })
                .ToList();

            relatedNews.AddRange(related);

            var vm = new NewsSingleVm()
            {
                NewsDetails = details,
                RelatedNews = relatedNews
            };

            //Any(n => category.CategoryName == news.Category.CategoryName) (&& != ) )
            return View(vm);
        }
    }
}
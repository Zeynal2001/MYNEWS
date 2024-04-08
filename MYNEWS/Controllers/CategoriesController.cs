using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MYNEWS.Data;
using MYNEWS.Entities;
using MYNEWS.Models;
using MYNEWS.ViewModels;

namespace MYNEWS.Controllers
{
    public class CategoriesController : Controller
    {
        public CategoriesController(AppDbContext context)
        {
            _context = context;
        }

        private readonly AppDbContext _context;

        public IActionResult Index()
        {
            ViewData["title"] = "Categories";

            var categories = _context.Categories
                .Include(c => c.Subcategories)
                .ToList();

            var categoryCount = categories.Count;

            if (categories == null && categoryCount == 0)
            {
                ViewData["msg"] = "Unexpected error occurred";
                return View("Error");
            }

            var categoryIndexList = categories
                .Take(categoryCount)
                .Select(c => new CategoryIndex()
                {
                    Id = c.Id,
                    Name = c.CategoryName,
                    Subcategories = c.Subcategories.Select(sc => new SubcategoryIndex()
                    {
                        Id = sc.Id,
                        Name = sc.SubcategoryName
                    }).ToList()
                }).ToList();

            if (categoryIndexList == null)
            {
                ViewData["msg"] = "Unexpected error occurred";
                return View("Error");
                //return NotFound();
            }

            return View(categoryIndexList);
        }


        public async Task<IActionResult> CategoryNews(Guid categoryId)
        {
            ViewData["title"] = "Category News";

            var category = await _context.Categories.Include(c => c.Subcategories).FirstOrDefaultAsync(x => x.Id == categoryId);

            var categoriesCount = _context.Categories.Count();

            if (category == null || categoriesCount == 0)
            {
                ViewData["msg"] = "Unexpected error occurred";
                return View("Error");
            }

            var news = _context.News.Where(x => x.Category.Id == category.Id).Include(x => x.Category).Include(x => x.Subcategory).ToList();

            var categoryModel = new CategorySingleVm()
            {
                Id = category.Id,
                CategoryName = category.CategoryName,
                Subcategories = category.Subcategories?.Select(sc => new SubcategoriesForThisVm()
                {
                    Id = sc.Id,
                    SubcategoryName = sc.SubcategoryName
                }).ToList() ?? Enumerable.Empty<SubcategoriesForThisVm>().ToList(),
                News = news.Select(n => new NewsForThisVm()
                {
                    Id = n.Id,
                    Title = n.Title,
                    PhotoPathSingleBig = n.PhotoPathSingleBig,
                    PhotoPathForTrending = n.PhotoPathForTrending,
                    PhotoPathForCategories = n.PhotoPathForCategories,
                    PhotoPathForFeatured = n.PhotoPathForFeatured,
                    Category = n.Category.CategoryName,
                    SubCategory = n.Subcategory?.SubcategoryName,
                    CreatedAt = n.CreatedAt
                }).ToList()
            };


            if (categoryModel == null)
            {
                ViewData["msg"] = "Unexpected error occurred";
                return View("Error");
            }

            return View(categoryModel);
        }

        //public IActionResult Pagination() 
        //{
        //    return View();
        //}

        public IActionResult SubcategoryNews(string subCategoryId)
        {
            return View();
        }


    }
}

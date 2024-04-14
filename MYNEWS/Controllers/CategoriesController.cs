using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MYNEWS.Data;
using MYNEWS.Entities;
using MYNEWS.Models;
using MYNEWS.ViewModels;
using System.Drawing;

namespace MYNEWS.Controllers
{
    public class CategoriesController : Controller
    {
        public CategoriesController(AppDbContext context)
        {
            _context = context;
        }

        private readonly AppDbContext _context;

        public IActionResult Index(int page = 1)
        {
            ViewData["title"] = "Categories";

            int size = 4;

            var categories = _context.Categories
                .Include(c => c.Subcategories)
                .ToList();


            var totalcategoies = categories.Count;

            if (categories == null && totalcategoies == 0)
            {
                ViewData["msg"] = "Unexpected error occurred";
                return View("Error");
            }
            var categoryList = categories
                .Skip((page - 1) * size)
                .Take(size)
                .Select(c => new CategoryIndex()
                {
                    Id = c.Id,
                    Name = c.CategoryName,
                    Subcategories = c.Subcategories.Select(sc => new SubcategoryIndex()
                    {
                        Id = sc.Id,
                        Name = sc.SubcategoryName
                    }).ToList(),
                }).ToList();

            if (categoryList == null)
            {
                ViewData["msg"] = "Unexpected error occurred";
                return View("Error");
                //return NotFound();
            }

            var vm = new CategoryVm()
            {
                Categories = categoryList,
                CurrentPage = page,
                PageCount = (int)Math.Ceiling((double)totalcategoies / size)
            };

            return View(vm);
        }

        public IActionResult Filter(int page = 1)
        {


            return View();
        }

        public async Task<IActionResult> CategoryNews(Guid categoryId, int page = 1)
        {
            ViewData["title"] = "Category News";

            var category = await _context.Categories.Include(c => c.Subcategories).FirstOrDefaultAsync(x => x.Id == categoryId);

            var categoriesCount = _context.Categories.Count();

            if (category == null || categoriesCount == 0)
            {
                ViewData["msg"] = "Unexpected error occurred";
                return View("Error");
            }

            int size = 1; // Hər səhifəyə düşən xəbər sayı

            // Seçilən səhifədəki xəbərləri gətiririk
            var news = _context.News
                .Where(x => x.Category.Id == category.Id)
                .OrderByDescending(x => x.CreatedAt) // Xəbərləri ən yeni tarixə görə sıralamaq üçün
                .Include(x => x.Category)
                .Include(x => x.Subcategory)
                .ToList();

            // Total xəbər sayını alırıq
            var totalNews = _context.News
                .Count(x => x.Category.Id == category.Id);

            var categoryModel = new CategorySingleVm()
            {
                Id = category.Id,
                CategoryName = category.CategoryName,
                Subcategories = category.Subcategories?.Select(sc => new SubcategoriesForThisVm()
                {
                    Id = sc.Id,
                    SubcategoryName = sc.SubcategoryName
                }).ToList() ?? new List<SubcategoriesForThisVm>(),
                News = news
                .Skip((page - 1) * size)
                .Take(size)
                .Select(n => new NewsForThisVm()
                {
                    Id = n.Id,
                    Title = n.Title,
                    PhotoPathSingleBig = n.PhotoPathSingleBig,
                    PhotoPathForTrending = n.PhotoPathForTrending,
                    PhotoPathForCategories = n.PhotoPathForCategories,
                    PhotoPathForFeatured = n.PhotoPathForFeatured,
                    Category = n.Category.CategoryName,
                    CategoryId = n.Category.Id.ToString(),
                    SubCategory = n.Subcategory?.SubcategoryName,
                    CreatedAt = n.CreatedAt,
                }).ToList(),
                CurrentPage = page,
                PageCount = (int)Math.Ceiling(totalNews / (double)size)
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

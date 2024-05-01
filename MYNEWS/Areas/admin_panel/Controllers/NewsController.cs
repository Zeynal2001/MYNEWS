using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MYNEWS.Abstractions;
using MYNEWS.Areas.admin_panel.Models;
using MYNEWS.Data;
using MYNEWS.Entities;
using MYNEWS.Enums;
using MYNEWS.Services;

namespace MYNEWS.Areas.admin_panel.Controllers
{
    [Area("admin_panel")]
    [Authorize(Roles = nameof(RoleTypes.Admin), AuthenticationSchemes = "AdminAuth")]
    public class NewsController : Controller
    {
        public NewsController(IStorageService storageService, AppDbContext context)
        {
            _storageService = storageService;
            _context = context;
        }

        private readonly IStorageService _storageService;
        private readonly AppDbContext _context;

        public IActionResult GetAllNews()
        {
            return View();
        }

        public IActionResult GetDeletedNews()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateNewsModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);

                //return BadRequest(ModelState);
            }

            var uploadedForTrending = await _storageService.UploadFileAsync("news-images", model.ForTrending);
            var forTrending = uploadedForTrending.FullPath;

            var uploadedForFeatured = await _storageService.UploadFileAsync("news-images", model.ForFeatured);
            var forFeatured = uploadedForFeatured.FullPath;

            var uploadedForCategoriesAndSub = await _storageService.UploadFileAsync("news-images", model.ForCategoriesAndSub);
            var forCategoriesAndSub = uploadedForCategoriesAndSub.FullPath;
            
            var uploadedForSingleBig = await _storageService.UploadFileAsync("news-images", model.SingleBig);
            var forSingleBig = uploadedForSingleBig.FullPath;

            if (_storageService is LocalStorageService)
            {
                forTrending = $"uploads/{forTrending}";
                forFeatured = $"uploads/{forFeatured}";
                forCategoriesAndSub = $"uploads/{forCategoriesAndSub}";
                forSingleBig = $"uploads/{forSingleBig}";
            }

            var news = new News()
            {
                Id = Guid.NewGuid(),
                Title = model.Title,
                Content = model.Content,
                ViewsCount = 0,
                IsDeleted = false,
                CreatedAt = DateTime.UtcNow,
                PhotoPathForTrending = forTrending,
                PhotoPathForFeatured = forFeatured,
                PhotoPathForCategories = forCategoriesAndSub,
                PhotoPathSingleBig = forSingleBig,
                

            };

            // _context.Remove(news);
            // _context.Remove<News>(news); //yuxardaki ile eyni seydir.
            // Amma bunu etmek yerine IsDeleted prop unu true elesen yaxsi olar

            await _context.News.AddAsync(news);
            await _context.SaveChangesAsync();

            return RedirectToAction("GetAllNews");
        }
    }
}

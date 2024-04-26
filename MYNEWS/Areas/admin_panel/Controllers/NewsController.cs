using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MYNEWS.Abstractions;
using MYNEWS.Areas.admin_panel.Models;
using MYNEWS.Entities;
using MYNEWS.Enums;

namespace MYNEWS.Areas.admin_panel.Controllers
{
    [Area("admin_panel")]
    [Authorize(Roles = nameof(RoleTypes.Admin), AuthenticationSchemes = "AdminAuth")]
    public class NewsController : Controller
    {
        public NewsController(IStorageService storageService)
        {
            _storageService = storageService;
        }

        private readonly IStorageService _storageService;

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
        public IActionResult Create(CreateNewsModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);

                //return BadRequest(ModelState);
            }

            var news = new News()
            {
                Id = Guid.NewGuid(),
                Title = model.Title,
                Content = model.Content,
                ViewsCount = 0,
                IsDeleted = false,
                CreatedAt = DateTime.UtcNow,

            };

            return View();
        }
    }
}

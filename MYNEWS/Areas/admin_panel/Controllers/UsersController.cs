using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MYNEWS.Enums;

namespace MYNEWS.Areas.admin_panel.Controllers
{
    [Area("admin_panel")]
    [Authorize(Roles = nameof(RoleTypes.Admin), AuthenticationSchemes = "AdminAuth")]
    public class UsersController : Controller
    {
        public IActionResult GetAllUsers()
        {
            return View();
        }
        
        public IActionResult GetDeletedUsers()
        {
            return View();
        }
        
        public IActionResult Create()
        {
            return View();
        }
    }
}

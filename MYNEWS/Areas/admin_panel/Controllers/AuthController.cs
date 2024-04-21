using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MYNEWS.Areas.admin_panel.Models;
using MYNEWS.Entities;
using MYNEWS.Enums;
using System.Security.Claims;

namespace MYNEWS.Areas.admin_panel.Controllers
{
    [Area("admin_panel")]
    public class AuthController : Controller
    {

        public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            AppUser user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                ModelState.AddModelError("adminAuthError", "There isn't such admin");
                return View(model);
            }

            //var userResult = await _signInManager.PasswordSignInAsync(user, model.Password, true, false);
            var userResult = await _signInManager.CheckPasswordSignInAsync(user, model.Password, false);

            if (!userResult.Succeeded)
            {
                ModelState.AddModelError("adminLoginError", "Password or Email is wrong!");
                return View(model);
            }

            var userClaimsPrinc = await _signInManager.CreateUserPrincipalAsync(user);

            await HttpContext.SignInAsync("AdminAuth", userClaimsPrinc);

            return RedirectToActionPermanent("Index", "Home");
        }
    }
}

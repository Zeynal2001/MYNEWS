using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MYNEWS.Entities;
using MYNEWS.Models;

namespace MYNEWS.Controllers
{
    public class AuthController : Controller
    {
        public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        private readonly UserManager<AppUser> _userManager; //Cox vaxti register ucun istifade edilir
        private readonly SignInManager<AppUser> _signInManager; //Cox vaxti login ucun istifade edilir

        public IActionResult Login(string? returnUrl)
        {
            ViewData["hasError"] = false;
            return View();
        }

        public IActionResult Register()
        {
            ViewData["hasError"] = false;
            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model, string? returnUrl)
        {
            ViewData["hasError"] = false;

            if (!ModelState.IsValid)
            {
                ViewData["hasError"] = true;
                return View(model);
            }
            
            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                ViewData["hasError"] = true;
                ModelState.AddModelError("loginErors", "Email or password is incorrect");
                return View(model);
            }

            var res = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);

            if (!res.Succeeded)
            {
                ViewData["hasError"] = true;
                ModelState.AddModelError("loginErors", "Email or password is incorrect");
                return View(model);
            }

            if (returnUrl != null)
            {
                return Redirect(returnUrl);
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            ViewData["hasError"] = false;

            if (!ModelState.IsValid)
            {
                ViewData["hasError"] = true;
                return View(model);
            }

            var user = new AppUser()
            {
                UserFName = model.FirstName,
                UserLName = model.LastName,
                Email = model.Email,
                Age = model.BirthDate,
                UserName = model.FirstName + model.LastName,
                ProfilePhotoPath = "img/user-solid2.png"
            };

            var res = await _userManager.CreateAsync(user, model.Password);

            if (!res.Succeeded)
            {
                //string registerError = res.Errors.ErrorsToString();
                var regErross = string.Join("\n", res.Errors.Select(er => er.Description).ToList());
                ModelState.AddModelError("registerErrors", regErross);
                ViewData["hasError"] = true;
            }

            if (res.Succeeded)
            {
                TempData["successMsg"] = "Registered!";
                return RedirectToAction("Login");
            }

            //await _userManager.AddToRoleAsync(user, "User");
            return View(model);
        }
    }
}

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MYNEWS.Abstractions;
using MYNEWS.Entities;
using MYNEWS.Enums;
using MYNEWS.Extensions;
using MYNEWS.Models;
using MYNEWS.Services;

namespace MYNEWS.Controllers
{
    public class AuthController : Controller
    {
        public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IStorageService storageService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _storageService = storageService;
        }

        private readonly UserManager<AppUser> _userManager; //Cox vaxti register ucun istifade edilir
        private readonly SignInManager<AppUser> _signInManager; //Cox vaxti login ucun istifade edilir
        private readonly IStorageService _storageService;

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

            var uploaded = await _storageService.UploadFileAsync("profile-photos", model.ProfilePhoto);
            var profilePhoto = uploaded.FullPath;

            if (_storageService is LocalStorageService)
            {
                profilePhoto = $"uploads/{profilePhoto}";
            }

            var user = new AppUser()
            {
                UserFName = model.FirstName,
                UserLName = model.LastName,
                Email = model.Email,
                BirthDate = model.BirthDate,
                UserName = model.FirstName + model.LastName,
                ProfilePhotoPath = profilePhoto
            };


            var res = await _userManager.CreateAsync(user, model.Password);

            if (!res.Succeeded)
            {
                ViewData["hasError"] = true;
                var regErrors = res.Errors.ErrorsToString();
                ModelState.AddModelError("registerErrors", regErrors);
                return View(model);
            }

            var roleRes = await _userManager.AddToRoleAsync(user, nameof(RoleTypes.Client));

            if (roleRes.Succeeded)
            {
                TempData["successMsg"] = "Registered!";
                return RedirectToAction("Login");
            }

            var errors = roleRes.Errors.ErrorsToString();
            ModelState.AddModelError("roleErrors", errors);
            ViewData["hasError"] = true;

            return View(model);
        }
    }
}

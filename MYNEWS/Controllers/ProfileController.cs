using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MYNEWS.Abstractions;
using MYNEWS.Entities;
using MYNEWS.Models;
using MYNEWS.Services;
using MYNEWS.ViewModels;
using SessionMapper;
using System.Security.Claims;

namespace MYNEWS.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        public ProfileController(UserManager<AppUser> userManager, IStorageService storageService)
        {
            _userManager = userManager;
            _storageService = storageService;
        }

        private readonly UserManager<AppUser> _userManager;
        private readonly IStorageService _storageService;

        public async Task<IActionResult> Index()
        {
            var id = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);

            if (id == null)
            {
                ViewData["msg"] = "You aren't logged in";
                return View("Error");
            }

            var user = await _userManager.FindByIdAsync(id.Value);

            if (user == null)
            {
                ViewData["msg"] = "You aren't logged in";
                return View("Error");
            }

            var profileEdit = new ProfileEdit()
            {
                Id = user.Id,
                FirstName = user.UserFName,
                LastName = user.UserLName,
                NickName = user.UserName,
                BirthDate = user.BirthDate,
                Email = user.Email,
                ProfilePhotoUrl = user.ProfilePhotoPath
                
            };

            var profileModel = new ProfileIndex
            {
                FullName = user.UserFName + " " + user.UserLName,
                DateOfBirth = user.BirthDate,
                Email = user.Email,
                ProfilPhoto = user.ProfilePhotoPath
            };

            /*
            // Calculate the time difference between the user's date of birth and the current date
            var ageInDays = (DateTime.Now - user.Age).TotalDays;

            // Convert the age in days to years
            var ageInYears = (int)Math.Floor(ageInDays / 365.25); // Considering leap years

            profileModel.Age = ageInYears;
            */

            HttpContext.Session.SetAsJson<ProfileEdit>("userDetails", profileEdit);

            return View(profileModel);
        }

        public IActionResult Edit()
        {
            var userDetails = HttpContext.Session.Get<ProfileEdit>("userDetails");

            if (userDetails == null)
            {
                ViewData["msg"] = "You aren't loggin in";
                return View("Error");
            }

            HttpContext.Session.Remove("userDetails");

            var editVm = new ProfileEditVm()
            {
                ProfileDetails = userDetails
            };

            ViewData["hasError"] = false;

            return View(editVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProfileEditVm model)
        {
            ViewData["hasError"] = false;

            if (!ModelState.IsValid)
            {
                ViewData["hasError"] = true;
                return View(model);
            }

            var user = await _userManager.FindByIdAsync(model.ProfileDetails.Id);

            if (user == null)
            {
                ViewData["msg"] = "There isn't such user";
                return View("Error");
            }

            var profilePhoto = "";

            if (model.ProfileDetails.ProfilePhoto == null)
            {
                profilePhoto = model.ProfileDetails.ProfilePhotoUrl;
            }
            else
            {
                var photoName = Path.GetFileName(model.ProfileDetails.ProfilePhotoUrl);
                if (_storageService.HasFile("profile-photos", photoName))
                {
                   await _storageService.DeleteFileAsync("profile-photos", photoName);
                }
                
                var dto = await _storageService.UploadFileAsync("profile-photos", model.ProfileDetails.ProfilePhoto);
                profilePhoto = dto.FullPath;

                if (_storageService is LocalStorageService)
                {
                    profilePhoto = $"uploads/{dto.FullPath }";
                }
            }

            user.UserFName = model.ProfileDetails.FirstName;
            user.UserLName = model.ProfileDetails.LastName;
            user.UserName = model.ProfileDetails.NickName;
            user.BirthDate = model.ProfileDetails.BirthDate;
            user.Email = model.ProfileDetails.Email;
            user.ProfilePhotoPath = profilePhoto;

            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                TempData["succesMsg"] = "Updated the profile";
                return RedirectToAction("Index");
            }

            var errors = string.Join("\n", result.Errors.Select(err => err.Description).ToList());
            ModelState.AddModelError("editErrors", errors);
            ViewData["hasError"] = true;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ProfileEditVm model)
        {
            ViewData["hasError"] = false;

            if (!ModelState.IsValid)
            {
                ViewData["hasError"] = true;
                return View(model);
            }

            var user = await _userManager.FindByIdAsync(model.ChangeDetails.Id);

            if (user == null)
            {
                ViewData["msg"] = "There isn't such user";
                return View("Error");
            }

            var result = await _userManager.ChangePasswordAsync(user, model.ChangeDetails.CurrentPassword, model.ChangeDetails.NewPassword);

            if (result.Succeeded)
            {
                TempData["succesMsg"] = "Updated the profile";
                return RedirectToAction("Index", "Profile");
            }

            var errors = string.Join("\n", result.Errors.Select(err => err.Description).ToList());
            ModelState.AddModelError("editErrors", errors);
            ViewData["hasError"] = true;

            return View("Edit", model);
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MYNEWS.Entities;
using MYNEWS.Models;
using System.Security.Claims;

namespace MYNEWS.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        private readonly UserManager<AppUser> _userManager;

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

            var profileModel = new ProfileIndex
            {
                FullName = user.UserFName + " " + user.UserLName,
                DateOfBirth = user.Age,
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
            return View(profileModel);
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using MYNEWS.Abstractions;
using MYNEWS.Areas.admin_panel.Models;
using MYNEWS.Data;
using MYNEWS.Entities;
using MYNEWS.Enums;
using MYNEWS.Extensions;
using MYNEWS.Services;

namespace MYNEWS.Areas.admin_panel.Controllers
{
    [Area("admin_panel")]
    [Authorize(Roles = nameof(RoleTypes.Admin), AuthenticationSchemes = "AdminAuth")]
    public class UsersController : Controller
    {
        public UsersController(AppDbContext context, UserManager<AppUser> userManager, IStorageService storageService, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _storageService = storageService;
            _roleManager = roleManager;
        }

        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IStorageService _storageService;

        public async Task<IActionResult> GetAllUsers(int page = 1, int pageSize = 5)
        {
            var users = await _context.Users
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(usr => new AllUsersModel()
                {
                    Id = usr.Id,
                    FullName = usr.UserFName + " " + usr.UserLName,
                    UserName = usr.UserName,
                    BirthDate = usr.BirthDate,
                    Email = usr.Email,
                    ProfilePhoto = usr.ProfilePhotoPath
                }).ToListAsync();

            var totalUsers = _context.Users.Count();

            var vm = new GetAllUsersVm()
            {
                Users = users,
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalUsers / (double)pageSize),
                PageSize = pageSize
            };

            return View(vm);
        }

        public IActionResult GetBannedUsers()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Edit(string Id)
        {
            var user = await _userManager.FindByIdAsync(Id);

            if (user == null)
            {
                var errorModel = new ErrorModel()
                {
                    ErrorMessage = "There isn't such user"
                };

                return View("Error", errorModel);
            }
            var userEditDetails = new EditUserModel()
            {
                Id = user.Id,
                FirstName = user.UserFName,
                LastName = user.UserLName,
                NickName = user.UserName,
                BirthDate = user.BirthDate,
                Email = user.Email,
                ProfilePhotoPath = user.ProfilePhotoPath,
            };

            return View(userEditDetails);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditUserModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByIdAsync(model.Id);

            if (user == null)
            {
                ModelState.AddModelError("editError", "There isn't such user");
                return View(model);
                /*
                var errorModel = new ErrorModel()
                {
                    ErrorMessage = "There isn't such user"
                };

                return View("Error", errorModel);
                */
            }

            var profilePhoto = "";

            if (model.ProfilePhoto == null)
            {
                profilePhoto = model.ProfilePhotoPath;
            }
            else
            {
                var photoName = Path.GetFileName(model.ProfilePhotoPath);
                if (_storageService.HasFile("profile-photos", photoName))
                {
                    await _storageService.DeleteFileAsync("profile-photos", photoName);
                }

                var dto = await _storageService.UploadFileAsync("profile-photos", model.ProfilePhoto);

                profilePhoto = dto.FullPath;

                if (_storageService is LocalStorageService)
                {
                    profilePhoto = $"uploads/{dto.FullPath}";
                }
            }

            user.UserFName = model.FirstName;
            user.UserLName = model.LastName;
            user.UserName = model.NickName;
            user.BirthDate = model.BirthDate;
            user.Email = model.Email;
            user.ProfilePhotoPath = profilePhoto;

            var updateResult = await _userManager.UpdateAsync(user);

            if (!updateResult.Succeeded)
            {
                foreach (var error in updateResult.Errors)
                {
                    var updateErrors = updateResult.Errors.ErrorsToString();
                    ModelState.AddModelError("updateError", updateErrors);

                    return View(model);
                }
            }

            return RedirectToAction(nameof(GetAllUsers));
        }

        public async Task<IActionResult> ChangeRole(string Id)
        {
            var user = await CheckUserAsync(Id);

            if (user == null)
            {
                var errorModel = new ErrorModel()
                {
                    ErrorMessage = "There isn't such user"
                };

                return View("Error", errorModel);
            }

            var currentRoles = await _userManager.GetRolesAsync(user);
            var roles = await _context.Roles.ToListAsync();

            var roleVm = new ChangeRoleVm()
            {
                Id = user.Id,
                Email = user.Email,
                UserName = user.UserFName + " " + user.UserLName,
                ProfilePhotoPath = user.ProfilePhotoPath,
                UserRoles = currentRoles.ToList(),
                Roles = roles
            };

            return View(roleVm);
        }

        public async Task<AppUser> CheckUserAsync(string id)
        {
            return await _userManager.FindByIdAsync(id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeRole(ChangeRoleVm model)
        {
            var user = await CheckUserAsync(model.Id);

            if (user == null)
            {
                var errorModel = new ErrorModel()
                {
                    ErrorMessage = "There isn't such user"
                };

                return View("Error", errorModel);
            }

            var role = await _roleManager.FindByIdAsync(model.SelectedRoleId);

            if (role == null)
            {
                var errorModel = new ErrorModel()
                {
                    ErrorMessage = "There isn't such role"
                };

                return View("Error", errorModel);
            }

            if (await _userManager.IsInRoleAsync(user, role.Name))
            {
                var errorModel = new ErrorModel()
                {
                    ErrorMessage = "The user is already has this role"
                };

                return View("Error", errorModel);
            }

            var result = await _userManager.AddToRoleAsync(user, role.Name);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("roleError", result.Errors.ErrorsToString());
                return View(model);
            }

            return RedirectToAction("GetAllUsers");
        }
    }
}

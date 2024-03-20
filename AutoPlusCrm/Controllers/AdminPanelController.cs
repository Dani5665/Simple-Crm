﻿using AutoPlusCrm.Data;
using AutoPlusCrm.Data.Models;
using AutoPlusCrm.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AutoPlusCrm.Controllers
{
	[Authorize(Roles = "Admin")]
	public class AdminPanelController : Controller
    {
        private readonly ApplicationDbContext data;
        private readonly UserManager<ApplicationUser> userManager;
		private readonly RoleManager<IdentityRole> roleManager;

		public AdminPanelController(ApplicationDbContext context, UserManager<ApplicationUser> _userManager, RoleManager<IdentityRole> _roleManager)
        {
            data = context;
            userManager = _userManager;
			roleManager = _roleManager;
        }

        public async Task<IActionResult> Index()
        {
            var users = await userManager.Users
				.Include(u => u.UserStore)
                .AsNoTracking()
                .Select(u => new UsersTableDetailsViewModel(
                    u.Id,
                    u.Email,
                    u.UserFullName,
                    u.UserStore.Name))
                .ToListAsync();

            return View(users);
        }

		[HttpGet]
		public async Task<IActionResult> AddUser()
		{
			PopulateUserRolesList();
			PopulateRetailerStoresList();

			var model = new EditUserViewModel();
			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> AddUser(EditUserViewModel model, string selectedRole, string selectedStore)
		{
			PopulateUserRolesList();
			PopulateRetailerStoresList();

			string email = model.UserEmail; ;
			string password = model.UserPassword;
            string fullName = model.UserFullName;
            var store = await data.RetailerStores.FirstOrDefaultAsync(s => s.Name == selectedStore);
			string role = selectedRole;

			if (await userManager.FindByNameAsync(email) == null)
				{
					var user = new ApplicationUser();
					user.UserName = email;
					user.Email = email;
                    user.UserStoreId = store.Id;
                    user.UserFullName = fullName;

					await userManager.CreateAsync(user, password);

					if (role != null) 
					{
						await userManager.AddToRoleAsync(user, role);
					}
				}
			

			return RedirectToAction("Index", "AdminPanel");
		}

		[HttpGet]
		public async Task<IActionResult> EditUser(string id)
		{
			var user = await data.Users
				.Include(u => u.UserStore)
				.FirstOrDefaultAsync(u => u.Id == id.ToString());

			PopulateUserRolesList();
			PopulateRetailerStoresList();

			var userRole = await userManager.GetRolesAsync(user);

			if (user == null)
			{
                return RedirectToAction("Error404", "Home", 404);
            }

			var model = new EditUserViewModel()
			{
				UserFullName = user.UserFullName,
				UserStore = user.UserStore.Name,
				UserEmail = user.Email,
				UserRole = userRole.First(),
				UserPassword = string.Empty
			};

			if (!ModelState.IsValid)
			{
				return BadRequest();
			}

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> EditUser(EditUserViewModel model, string id/*, string selectedRole*/, string selectedStore)
		{
			var user = await data.Users
				.Include(u => u.UserStore)
				.FirstOrDefaultAsync(u => u.Id == id.ToString());

			PopulateUserRolesList();
			PopulateRetailerStoresList();

			var userStore = await data.RetailerStores.FirstOrDefaultAsync(us => us.Name == selectedStore);
			//var userRole = await userManager.GetRolesAsync(user);

			if (user == null)
			{
                return RedirectToAction("Error404", "Home", 404);
            }
			if (!ModelState.IsValid)
			{
				if (user.UserFullName != model.UserFullName && model.UserFullName != string.Empty && model.UserFullName != null) 
				{
					user.UserFullName = model.UserFullName;
				}
				if (user.UserStoreId != userStore?.Id && userStore?.Id != null)
				{
					user.UserStoreId = userStore.Id; ;
				}
				if (user.Email != model.UserEmail && model.UserEmail != string.Empty && model.UserEmail != null)
				{
					user.Email = model.UserEmail;
				}
				if (model.UserPassword != null && model.UserPassword != string.Empty)
				{
					var userToChangePassword = await userManager.FindByIdAsync(user.Id);
					if (userToChangePassword == null)
					{
						return NotFound();
					}

					var token = await userManager.GeneratePasswordResetTokenAsync(user);
					var result = await userManager.ResetPasswordAsync(user, token, model.UserPassword);
					if (!result.Succeeded)
					{
						return BadRequest(result.Errors);
					}
				}
			}
			
			await data.SaveChangesAsync();
			return RedirectToAction("Index","AdminPanel");
		}

		public void PopulateUserRolesList()
		{
			var roles = roleManager.Roles.ToList();
			ViewBag.UserRoles = new SelectList(roles, "Name", "Name");
		}

		public void PopulateRetailerStoresList()
		{
			var retailerStores = data.RetailerStores.ToList();
			ViewBag.RetailerStores = new SelectList(retailerStores, "Name", "Name");
		}
	}
}

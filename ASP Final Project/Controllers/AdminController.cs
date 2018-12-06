using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TumblrRipOff.Models;

namespace TumblrRipOff.Controllers
{
    //[Authorize(Roles = "Admin")]
    [Authorize(Roles = "Admin,")]
    public class AdminController : Controller
    {
        private RoleManager<IdentityRole> _RoleManager;
        private UserManager<TumblrUserModel> _UserManager;

        public AdminController(RoleManager<IdentityRole> roleManager, UserManager<TumblrUserModel> userManager)
        {
            _RoleManager = roleManager;
            _UserManager = userManager;
        }

        [Route("Admin")]
        public IActionResult Index() // displays list of users
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddUserToRole(string Email, string RoleTitle)
        {
            TumblrUserModel user = _UserManager.FindByEmailAsync(Email).Result;
            if (!_UserManager.GetRolesAsync(user).Result.Contains(RoleTitle))
            {
                IdentityResult result = _UserManager.AddToRoleAsync(user, RoleTitle).Result;
                if (!result.Succeeded)//Check the status of the result
                {
                    throw new Exception(result.Errors.Select(e => e.Description).Aggregate((a, b) => a + "," + b));
                }
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateRole(string RoleName)
        {
            IdentityRole role = new IdentityRole();
            role.Name = RoleName;
            IdentityResult result = _RoleManager.CreateAsync(role).Result;
            return RedirectToAction("Index");
        }
    }
}
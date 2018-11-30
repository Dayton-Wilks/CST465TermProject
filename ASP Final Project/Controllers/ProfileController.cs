using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TumblrRipOff.Models;
using TumblrRipOff.Repositories;
using TumblrRipOff.Utilities;

namespace TumblrRipOff.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private RoleManager<IdentityRole> _RoleManager;
        private UserManager<TumblrUserModel> _UserManager;
        private IPostRepository _postRepository;

        public ProfileController(RoleManager<IdentityRole> roleManager, UserManager<TumblrUserModel> userManager, IPostRepository postRepository)
        {
            _RoleManager = roleManager;
            _UserManager = userManager;
            _postRepository = postRepository;
        }

        [AllowAnonymous]
        [Route("Profile")]
        [Route("Profile/{UserName?}")]
        [HttpGet]
        public IActionResult Index(string UserName) // shows user feed
        {
            var user = _UserManager.FindByNameAsync(UserName).Result;
            if (user == null)
            {
                return View("ErrorPage", new ErrorModel() { ErrorMessage = "This user could not be found!"});
            }
            SanitizedUserModel model = Utility.Convert(user, _postRepository.GetPostCount(UserName));
            return View(model);
        }

        [HttpGet]
        public IActionResult MyProfile()
        {
            return View("MyProfile");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult MyProfile(TumblrUserModel model)
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreatePost()
        {
            return View("CreatePost", new PostModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePost(PostModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("CreatePost", model);
            }
            return RedirectToAction();
        }
    }
}
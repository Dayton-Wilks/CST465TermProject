using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
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
        private IOptionsSnapshot<TumblrConfiguration> _configuration;

        public ProfileController(RoleManager<IdentityRole> roleManager, UserManager<TumblrUserModel> userManager, IPostRepository postRepository, IOptionsSnapshot<TumblrConfiguration> configuration)
        {
            _RoleManager = roleManager;
            _UserManager = userManager;
            _postRepository = postRepository;
            _configuration = configuration;
        }

        [AllowAnonymous]
        [Route("ProfileFeed")]
        [Route("ProfileFeed/{UserName?}")]
        [HttpGet]
        public IActionResult Index(string UserName) // shows user feed
        {
            TumblrUserModel user;
            if (UserName == null || (user = _UserManager.FindByNameAsync(UserName).Result) == null)
            {
                return View("ErrorPage", new ErrorModel() { ErrorMessage = "This user could not be found!"});
            }
            //SanitizedUserModel model = Utility.Convert(user, _postRepository.GetPostCount(UserName));
            //SanitizedUserModel model = Utility.Convert(user, 0);
            List<PostModel> model = _postRepository.GetPosts(UserName);
            return View(model);
        }

        [HttpGet]
        public IActionResult MyProfile()
        {
            TumblrUserModel t = _UserManager.GetUserAsync(User).Result;
            UpdateModel model = new UpdateModel() { UserName = t.UserName, Email = t.Email, AboutMe = t.AboutMe , ProfileImageUrl = t.ProfileImageUrl};
            return View("MyProfile", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult MyProfile(UpdateModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("MyProfile", model);
            }
            var user = _UserManager.GetUserAsync(User).Result;

            user.AboutMe = model.AboutMe;
            user.ProfileImageUrl = model.ProfileImageUrl;
            var x =_UserManager.UpdateAsync(user).Result;

            return RedirectToAction("MyProfile");
        }

        [HttpGet]
        public IActionResult CreatePost()
        {
            TumblrConfiguration c = _configuration.Value;
            return View("CreatePost", new PostModel() { Title = c.DefaultTitle, ImageUrl = c.DefaultImageURL, PostText = c.DefaultText});
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePost(PostModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("CreatePost", model);
            }
            model.Creator = User.Identity.Name;
            
            _postRepository.SavePost(model);
            return RedirectToAction("CreatePost");
        }
    }
}
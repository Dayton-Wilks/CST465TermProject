using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using TumblrRipOff.Models;
using TumblrRipOff.Repositories;

namespace TumblrRipOff.Controllers
{
    public class HomeController : Controller
    {
        private IPostRepository _postRepository { get; set; }
        private IOptionsSnapshot<TumblrConfiguration> _configuration;

        public HomeController(IOptionsSnapshot<TumblrConfiguration> configuration, IPostRepository postRepository)
        {
            _postRepository = postRepository;
            _configuration = configuration;
        }

        [HttpGet]
        [Route("Home/{index?}")]
        public IActionResult Index(int page = 1)
        {
            List<PostModel> pageResults = _postRepository.GetPosts(page);
            return View(pageResults);
        }

        [HttpGet]
        [Route("Home/DisplayPost/{postID?}")]
        public IActionResult DisplayPost(int postID)
        {
            PostModel model = null;
            if (postID == 0 || (model = _postRepository.GetPost(postID)) == null)
            {
                return View("ErrorPage", new ErrorModel() { ErrorMessage = "The post could not be found!" });
            }
            return View(model);
        }
    }
}
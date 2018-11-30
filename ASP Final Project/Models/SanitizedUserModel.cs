using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TumblrRipOff.Models
{
    public class SanitizedUserModel
    {
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Display(Name = "About Me")]
        public string AboutMe { get; set; }

        [Display(Name = "Post Count")]
        public int PostCount { get; set; }

        public string ProfileImageUrl { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TumblrRipOff.Models
{
    public class UpdateModel
    {
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "About Me")]
        public string AboutMe { get; set; }

        [DataType(DataType.ImageUrl)]
        [Display(Name = "Profile Image URL")]
        public string ProfileImageUrl { get; set; }
    }
}

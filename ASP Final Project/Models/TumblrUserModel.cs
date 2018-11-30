using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TumblrRipOff.Models
{
    public class TumblrUserModel : IdentityUser
    {
        public string AboutMe { get; set; } = "";

        public string ProfileImageUrl { get; set; } = "";
    }
}

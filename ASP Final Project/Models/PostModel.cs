using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TumblrRipOff.Models
{
    public class PostModel
    {
        [Display(Name = "Post ID")]
        public int PostID { get; set; }

        [Display(Name = "Post ID")]
        [Required(ErrorMessage = "A post needs a title", AllowEmptyStrings = false)]
        public string Title { get; set; }

        [Display(Name = "Image ID")]
        public string ImageUrl { get; set; } = "";

        [Display(Name = "Post Text")]
        public string PostText { get; set; }

        [Display(Name = "Creator")]
        public string Creator { get; set; }

        [Display(Name = "Timestamp")]
        public DateTime TimeStamp { get; set; }
    }
}

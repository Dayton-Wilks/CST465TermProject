using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TumblrRipOff.Models
{
    public class PostPageModel
    {
        public List<PostModel> posts { get; set; }
        public int page { get; set; }
    }
}

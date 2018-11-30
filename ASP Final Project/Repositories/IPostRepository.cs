using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TumblrRipOff.Models;

namespace TumblrRipOff.Repositories
{
    public interface IPostRepository
    {
        PostModel GetPost(int PostId);

        List<PostModel> GetPosts(int index, string UserName = ""); // retrive 20 at a time?

        int GetPostCount(string userName);

        void DeletePost(int PostID);

        void SavePost(PostModel model);
    }
}

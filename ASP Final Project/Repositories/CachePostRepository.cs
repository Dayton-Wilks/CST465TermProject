using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TumblrRipOff.Models;

namespace TumblrRipOff.Repositories
{
    public class CachePostRepository : PostRepository
    {
        private IMemoryCache _Cache;
        private string _CachePrefix = "CachePostKey_";

        public CachePostRepository(IOptionsSnapshot<TumblrConfiguration> configuration, IConfiguration config, IMemoryCache cache) : base(configuration, config)
        {
            _Cache = cache;
        }

        public override void DeletePost(int PostID)
        {
            base.DeletePost(PostID);
        }

        public override PostModel GetPost(int PostId)
        {
            return base.GetPost(PostId);
        }

        public override List<PostModel> GetPosts(string UserName = "")
        {
            if ((UserName != null && UserName != "")) return base.GetPosts(UserName);

            var postList = (List<PostModel>) _Cache.Get(_CachePrefix);
            if (postList == null)
            {
                postList = base.GetPosts(UserName);
                _Cache.Set(_CachePrefix, postList);
            }
            return postList;
        }

        public override void SavePost(PostModel model)
        {
            base.SavePost(model);
            _Cache.Remove(_CachePrefix);
        }
    }
}

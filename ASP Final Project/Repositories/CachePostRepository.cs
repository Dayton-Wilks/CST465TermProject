using Microsoft.Extensions.Caching.Memory;
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

        public CachePostRepository(IOptionsSnapshot<TumblrConfiguration> configuration, IMemoryCache cache) : base(configuration)
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

        public override int GetPostCount(string userName)
        {
            return base.GetPostCount(userName);
        }

        public override List<PostModel> GetPosts(int index, string UserName = "")
        {
            return base.GetPosts(index, UserName);
        }

        public override void SavePost(PostModel model)
        {
            base.SavePost(model);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TumblrRipOff.Models;

namespace TumblrRipOff.Utilities
{
    public static class Utility
    {
        public static SanitizedUserModel Convert(TumblrUserModel oldModel, int postCount)
        {
            return (oldModel == null) ? null : new SanitizedUserModel() { UserName = oldModel.UserName, AboutMe = oldModel.AboutMe, PostCount = postCount, ProfileImageUrl = oldModel.ProfileImageUrl };
        }
    }
}

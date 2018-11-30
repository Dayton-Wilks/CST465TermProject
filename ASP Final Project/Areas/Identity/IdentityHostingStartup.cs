using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TumblrRipOff.Models;

[assembly: HostingStartup(typeof(TumblrRipOff.Areas.Identity.IdentityHostingStartup))]
namespace TumblrRipOff.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<TumblrRipOffContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("TumblrRipOffContextConnection")));

                //services.AddDefaultIdentity<TumblrUserModel>()
                //    .AddEntityFrameworkStores<TumblrRipOffContext>();

                services.AddIdentity<TumblrUserModel, IdentityRole>(options =>
                {
                    options.Password.RequireDigit = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequiredLength = 4;
                    options.Password.RequiredUniqueChars = 1;
                })
                 .AddRoleManager<RoleManager<IdentityRole>>()
                 .AddDefaultUI()
                 .AddDefaultTokenProviders()
                 .AddEntityFrameworkStores<TumblrRipOffContext>();
            });
        }
    }
}
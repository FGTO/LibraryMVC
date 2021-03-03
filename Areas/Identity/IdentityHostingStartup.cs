using System;
using LibraryMVC.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(LibraryMVC.Areas.Identity.IdentityHostingStartup))]
namespace LibraryMVC.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<LibraryDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("LibraryDbContextConnection")));

                //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    //.AddEntityFrameworkStores<LibraryDbContext>();
            });
        }
    }
}
using System;
using System.Threading.Tasks;
using ClubEquitation.Areas.Identity.Data;
using ClubEquitation.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(ClubEquitation.Areas.Identity.IdentityHostingStartup))]
namespace ClubEquitation.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ClubEquitationContext>(options =>
                    options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=BDClubEquitation;Trusted_Connection=True;"));


                services.AddDefaultIdentity<ClubEquitationUser>()
                    .AddEntityFrameworkStores<ClubEquitationContext>()
                    .AddRoles<IdentityRole>();
                    
            });
           
        }
    }
}
using EventsApp.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EventsApp.Identity
{
    public static class IdentityServiceExtensions
    {
        public static void AddIdentityServices(this IServiceCollection services, 
            IConfiguration configuration)
        {

            services.AddDbContext<EventsAppIdentityDbContext>(options => options
                .UseSqlServer(configuration.GetConnectionString("EventsAppConnectionString"),
                b => b.MigrationsAssembly(typeof(EventsAppIdentityDbContext).Assembly.FullName)));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<EventsAppIdentityDbContext>().AddDefaultTokenProviders();

        }
    }
}
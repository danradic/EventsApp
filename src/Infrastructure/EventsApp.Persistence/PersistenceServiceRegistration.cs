using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EventsApp.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EventsAppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("EventsAppConnectionString")));

            return services; 
        }
    }
}
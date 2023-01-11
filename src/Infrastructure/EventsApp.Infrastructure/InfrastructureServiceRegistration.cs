using EventsApp.Application.Contracts;
using EventsApp.Infrastructure.Security;
using Microsoft.Extensions.DependencyInjection;

namespace EventsApp.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IUserAccessor, UserAccessor>();

            return services;
        }
    }
}
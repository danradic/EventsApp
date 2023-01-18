using EventsApp.Api.Services.Photos;
using EventsApp.Application.Contracts.Infrastructure.Security;
using EventsApp.Application.Contracts.Infrastructure.Services.Photos;
using EventsApp.Infrastructure.Security;
using EventsApp.Infrastructure.Services.Photos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EventsApp.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(
            this IServiceCollection services, 
            IConfiguration configuration)
        {
            services.AddScoped<IUserAccessor, UserAccessor>();
            services.AddScoped<IHttpRequestBodyReader, HttpRequestBodyReader>();
            
            services.AddAuthorization(opt => 
            {
                opt.AddPolicy("IsActivityHost", policy =>
                {
                    policy.Requirements.Add(new IsHostRequirement());
                });
            });
            services.AddTransient<IAuthorizationHandler, IsHostRequirementHandler>();
            // services.AddScoped<IFormFileProxy, FormFileProxy>();
            services.AddScoped<IPhotoCloudStorageService, PhotoCloudStorageService>();
            services.Configure<CloudinarySettings>(configuration.GetSection("Cloudinary"));

            return services;
        }
    }
}
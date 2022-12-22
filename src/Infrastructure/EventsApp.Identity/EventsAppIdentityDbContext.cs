using EventsApp.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EventsApp.Identity
{
    public class EventsAppIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public EventsAppIdentityDbContext(DbContextOptions<EventsAppIdentityDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedUsers(builder);
        }

        private static void SeedUsers(ModelBuilder builder)
        {
            ApplicationUser user = new()
            {
                DisplayName = "Admin",
                Bio = "I'm an admin",
                UserName = "admin",
                Email = "admin@admin.com",
                EmailConfirmed = true
            };

            PasswordHasher<ApplicationUser> passwordHasher = new();
            user.PasswordHash = passwordHasher.HashPassword(user, "Admin@123");

            builder.Entity<ApplicationUser>().HasData(user);
        }
    }
}
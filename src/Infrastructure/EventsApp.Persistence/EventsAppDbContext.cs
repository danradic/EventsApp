using EventsApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EventsApp.Persistence
{
    public class EventsAppDbContext : DbContext
    {
        public EventsAppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EventsAppDbContext).Assembly);
            Seed.SeedData(modelBuilder);
        }

        public DbSet<Activity> Activities { get; set; }
    }
}
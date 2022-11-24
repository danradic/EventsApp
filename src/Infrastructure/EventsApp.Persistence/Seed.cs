using EventsApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EventsApp.Persistence
{
    public class Seed
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>().HasData(new Activity
            {
                Id = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76B7C5DDE}"),
                Title = "Past Activity 1",
                Date = DateTime.Now.AddMonths(-2),
                Description = "Activity 2 months ago",
                Category = "drinks",
                City = "London",
                Venue = "Pub"
            });
            modelBuilder.Entity<Activity>().HasData(new Activity
            {
                Id = Guid.Parse("{B0708D2F-8003-43C1-92A4-EDC76A7C5DDE}"),
                Title = "Past Activity 2",
                Date = DateTime.Now.AddMonths(-1),
                Description = "Activity 1 month ago",
                Category = "culture",
                City = "Paris",
                Venue = "Louvre"
            });
            modelBuilder.Entity<Activity>().HasData(new Activity
            {
                Id = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76A7D5DDE}"),
                Title = "Future Activity 1",
                Date = DateTime.Now.AddMonths(1),
                Description = "Activity 1 month in future",
                Category = "culture",
                City = "London",
                Venue = "Natural History Museum"
            });
            modelBuilder.Entity<Activity>().HasData(new Activity
            {
                Id = Guid.Parse("{B0788D2F-8003-43C5-92A4-EDC76A7C5DDE}"),
                Title = "Future Activity 2",
                Date = DateTime.Now.AddMonths(2),
                Description = "Activity 2 months in future",
                Category = "music",
                City = "London",
                Venue = "O2 Arena"
            });
            modelBuilder.Entity<Activity>().HasData(new Activity
            {
                Id = Guid.Parse("{B0788D2F-8003-43C7-92A4-EDC76A7C5DDE}"),
                Title = "Future Activity 3",
                Date = DateTime.Now.AddMonths(3),
                Description = "Activity 3 months in future",
                Category = "drinks",
                City = "London",
                Venue = "Another pub"
            });
            modelBuilder.Entity<Activity>().HasData(new Activity
            {
                Id = Guid.Parse("{B0788D2F-8003-43C1-42A4-EDC76A7C5DDE}"),
                Title = "Future Activity 4",
                Date = DateTime.Now.AddMonths(4),
                Description = "Activity 4 months in future",
                Category = "drinks",
                City = "London",
                Venue = "Yet another pub"
            });
            modelBuilder.Entity<Activity>().HasData(new Activity
            {
                Id = Guid.Parse("{B0788D2F-8003-46C1-92A4-EDC76A7C5DDE}"),
                Title = "Future Activity 5",
                Date = DateTime.Now.AddMonths(5),
                Description = "Activity 5 months in future",
                Category = "drinks",
                City = "London",
                Venue = "Just another pub"
            });
            modelBuilder.Entity<Activity>().HasData(new Activity
            {
                Id = Guid.Parse("{B0788D2E-8003-43C1-92A4-EDC76A7C5DDE}"),
                Title = "Future Activity 6",
                Date = DateTime.Now.AddMonths(6),
                Description = "Activity 6 months in future",
                Category = "music",
                City = "London",
                Venue = "Roundhouse Camden"
            });
            modelBuilder.Entity<Activity>().HasData(new Activity
            {
                Id = Guid.Parse("{B0768D2F-8003-43C1-92A4-EDC76A7C5DDE}"),
                Title = "Future Activity 7",
                Date = DateTime.Now.AddMonths(7),
                Description = "Activity 2 months ago",
                Category = "travel",
                City = "London",
                Venue = "Somewhere on the Thames"
            });
            modelBuilder.Entity<Activity>().HasData(new Activity
            {
                Id = Guid.Parse("{B0788D2F-8003-43C1-92E4-EDC76A7C5DDE}"),
                Title = "Future Activity 8",
                Date = DateTime.Now.AddMonths(8),
                Description = "Activity 8 months in future",
                Category = "film",
                City = "London",
                Venue = "Cinema"
            });
        }
    }
}
using EventsApp.Application.Models;
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

            var jane = new User 
            {
                UserId = "6df9eb93-33c0-42c0-a85d-cdd96ccd4899",
                UserName = "jane",
                DisplayName = "Jane",
                Email = "jane@test.com",
                Bio = "Jane is a woman of many talents, but most importantly, she has a great sense of humor. She's been known to turn a boring meeting into a comedy show and to make even the grimmest Monday morning bearable with her quick wit. When she's not cracking jokes, you can find her whipping up a storm in the kitchen, binge-watching her favorite shows, or planning her next adventure. Just don't ask her to pick a favorite ice cream flavor, she'll be there for hours."
            };
            var bob = new User 
            { 
                UserId = "7a8a088d-a38e-4187-a3d8-4545ab080450",
                UserName = "bob",
                DisplayName = "Bob",
                Email = "bob@test.com",
                Bio = "Bob is a hardworking individual with a passion for learning new things. He enjoys spending his free time exploring the outdoors and is an avid sports fan. Bob is also a dedicated family man who values spending time with his loved ones. He is a team player and is always willing to lend a helping hand to his colleagues. Bob's positive attitude and strong work ethic make him an asset to any team."
            };
            var tom = new User 
            {
                UserId = "84b07d25-a856-466d-a3a8-4ca6df8630e3",
                UserName = "tom",
                DisplayName = "Tom",
                Email = "tom@test.com",
                Bio = "Tom is a businessman who always has his schedule planned out months in advance, but that doesn't mean he doesn't know how to have fun. When he's not closing deals, you can find him hitting the dance floor, trying new cocktails or planning his next vacation, where he'll probably plan his schedule for the next year. Just don't ask him to be spontaneous, it's not in his schedule."
            };

            var attendees = new List<ActivityAttendee>
            {
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{c5b2be3b-627e-47cd-b893-18de572aaa71}"),
                    ActivityId = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76B7C5DDE}"),
                    UserId = bob.UserId,
                    UserName = bob.UserName,
                    DisplayName = bob.DisplayName,
                    Email = bob.Email,
                    Bio = bob.Bio,
                    IsHost = true
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{90c71ad5-cc49-4b3a-bf58-28c7e776d61f}"),
                    ActivityId = Guid.Parse("{B0708D2F-8003-43C1-92A4-EDC76A7C5DDE}"),
                    UserId = bob.UserId,
                    UserName = bob.UserName,
                    DisplayName = bob.DisplayName,
                    Email = bob.Email,
                    Bio = bob.Bio,
                    IsHost = true
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{fa64ad37-8e1b-4fc5-9ee3-ad69c8cdf798}"),
                    ActivityId = Guid.Parse("{B0708D2F-8003-43C1-92A4-EDC76A7C5DDE}"),
                    UserId = jane.UserId,
                    UserName = jane.UserName,
                    DisplayName = jane.DisplayName,
                    Email = jane.Email,
                    Bio = jane.Bio,
                    IsHost = false
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{23183bdc-a1db-45db-824f-179cf8a8c331}"),
                    ActivityId = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76A7D5DDE}"),
                    UserId = tom.UserId,
                    UserName = tom.UserName,
                    DisplayName = tom.DisplayName,
                    Email = tom.Email,
                    Bio = tom.Bio,
                    IsHost = true
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{87a262c6-c597-4c2d-97fe-732a2737e406}"),
                    ActivityId = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76A7D5DDE}"),
                    UserId = jane.UserId,
                    UserName = jane.UserName,
                    DisplayName = jane.DisplayName,
                    Email = jane.Email,
                    Bio = jane.Bio,
                    IsHost = false
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{ee8f3cfc-2ee1-40a0-824e-30c89a6fde6c}"),
                    ActivityId = Guid.Parse("{B0788D2F-8003-43C5-92A4-EDC76A7C5DDE}"),
                    UserId = bob.UserId,
                    UserName = bob.UserName,
                    DisplayName = bob.DisplayName,
                    Email = bob.Email,
                    Bio = bob.Bio,
                    IsHost = true
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{525b8837-3935-4900-8aab-09f5dce68b4a}"),
                    ActivityId = Guid.Parse("{B0788D2F-8003-43C5-92A4-EDC76A7C5DDE}"),
                    UserId = tom.UserId,
                    UserName = tom.UserName,
                    DisplayName = tom.DisplayName,
                    Email = tom.Email,
                    Bio = tom.Bio,
                    IsHost = false
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{4ebe321f-f48b-4574-9098-1453fdde0331}"),
                    ActivityId = Guid.Parse("{B0788D2F-8003-43C7-92A4-EDC76A7C5DDE}"),
                    UserId = jane.UserId,
                    UserName = jane.UserName,
                    DisplayName = jane.DisplayName,
                    Email = jane.Email,
                    Bio = jane.Bio,
                    IsHost = true
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{16c4764a-a85c-4d31-98e7-b22a83915cff}"),
                    ActivityId = Guid.Parse("{B0788D2F-8003-43C7-92A4-EDC76A7C5DDE}"),
                    UserId = bob.UserId,
                    UserName = bob.UserName,
                    DisplayName = bob.DisplayName,
                    Email = bob.Email,
                    Bio = bob.Bio,
                    IsHost = false
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{d0d1684b-861d-4700-adf1-ec457b50d7e6}"),
                    ActivityId = Guid.Parse("{B0788D2F-8003-43C1-42A4-EDC76A7C5DDE}"),
                    UserId = jane.UserId,
                    UserName = jane.UserName,
                    DisplayName = jane.DisplayName,
                    Email = jane.Email,
                    Bio = jane.Bio,
                    IsHost = true
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{bdc6adab-a35a-4a3a-bc4b-63482e724f99}"),
                    ActivityId = Guid.Parse("{B0788D2F-8003-46C1-92A4-EDC76A7C5DDE}"),
                    UserId = bob.UserId,
                    UserName = bob.UserName,
                    DisplayName = bob.DisplayName,
                    Email = bob.Email,
                    Bio = bob.Bio,
                    IsHost = true
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{f185ce01-3ba6-455a-b5c7-3dcb7b08fcad}"),
                    ActivityId = Guid.Parse("{B0788D2F-8003-46C1-92A4-EDC76A7C5DDE}"),
                    UserId = jane.UserId,
                    UserName = jane.UserName,
                    DisplayName = jane.DisplayName,
                    Email = jane.Email,
                    Bio = jane.Bio,
                    IsHost = false
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{3ab3d0ca-bb82-4c17-ae50-2e5d782e05fd}"),
                    ActivityId = Guid.Parse("{B0788D2E-8003-43C1-92A4-EDC76A7C5DDE}"),
                    UserId = tom.UserId,
                    UserName = tom.UserName,
                    DisplayName = tom.DisplayName,
                    Email = tom.Email,
                    Bio = tom.Bio,
                    IsHost = true
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{7f876625-4407-4439-916a-203bb144e5a3}"),
                    ActivityId = Guid.Parse("{B0788D2E-8003-43C1-92A4-EDC76A7C5DDE}"),
                    UserId = jane.UserId,
                    UserName = jane.UserName,
                    DisplayName = jane.DisplayName,
                    Email = jane.Email,
                    Bio = jane.Bio,
                    IsHost = false
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{30156295-b85c-429f-8924-f019a37db3d3}"),
                    ActivityId = Guid.Parse("{B0768D2F-8003-43C1-92A4-EDC76A7C5DDE}"),
                    UserId = bob.UserId,
                    UserName = bob.UserName,
                    DisplayName = bob.DisplayName,
                    Email = bob.Email,
                    Bio = bob.Bio,
                    IsHost = true
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{b9d2ed76-e6c1-4d56-80e4-95e055f02f49}"),
                    ActivityId = Guid.Parse("{B0768D2F-8003-43C1-92A4-EDC76A7C5DDE}"),
                    UserId = tom.UserId,
                    UserName = tom.UserName,
                    DisplayName = tom.DisplayName,
                    Email = tom.Email,
                    Bio = tom.Bio,
                    IsHost = false
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{38b42910-ed98-424e-97ce-2887ae1ef97d}"),
                    ActivityId = Guid.Parse("{B0788D2F-8003-43C1-92E4-EDC76A7C5DDE}"),
                    UserId = tom.UserId,
                    UserName = tom.UserName,
                    DisplayName = tom.DisplayName,
                    Email = tom.Email,
                    Bio = tom.Bio,
                    IsHost = true
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{6137ddf4-523f-4392-a9cd-d947ac6cdf5a}"),
                    ActivityId = Guid.Parse("{B0788D2F-8003-43C1-92E4-EDC76A7C5DDE}"),
                    UserId = jane.UserId,
                    UserName = jane.UserName,
                    DisplayName = jane.DisplayName,
                    Email = jane.Email,
                    Bio = jane.Bio,
                    IsHost = false
                }
            };

            modelBuilder.Entity<ActivityAttendee>().HasData(attendees);
        }
    }
}
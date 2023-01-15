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

            var attendees = new List<ActivityAttendee>
            {
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{8bd114c1-cf96-430a-9624-cb9df7b3b8d4}"),
                    ActivityId = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76B7C5DDE}"),
                    UserId = "940a1b37-3131-49b7-beb9-f37be7e2b536",
                    UserName = "bob",
                    Email = "bob@test.com",
                    IsHost = true
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{5c757487-a4d5-4207-b9b6-4641cde9737a}"),
                    ActivityId = Guid.Parse("{B0708D2F-8003-43C1-92A4-EDC76A7C5DDE}"),
                    UserId = "940a1b37-3131-49b7-beb9-f37be7e2b536",
                    UserName = "bob",
                    Email = "bob@test.com",
                    IsHost = true
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{553a08fd-b8f6-4268-885d-68108a9c29d8}"),
                    ActivityId = Guid.Parse("{B0708D2F-8003-43C1-92A4-EDC76A7C5DDE}"),
                    UserId = "95036e9b-23d2-4f20-968b-85d5098d46d6",
                    UserName = "jane",
                    Email = "jane@test.com",
                    IsHost = false
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{9db3248d-5d20-4474-b634-63b1d8cb97d8}"),
                    ActivityId = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76A7D5DDE}"),
                    UserId = "868bfa6f-2f65-4a89-8f24-7f0d4d897a0f",
                    UserName = "tom",
                    Email = "tom@test.com",
                    IsHost = true
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{41232c7a-1714-4025-bd01-2de96444c18f}"),
                    ActivityId = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76A7D5DDE}"),
                    UserId = "95036e9b-23d2-4f20-968b-85d5098d46d6",
                    UserName = "jane",
                    Email = "jane@test.com",
                    IsHost = false
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{41fddd3c-8811-4048-aa99-de65e85053b5}"),
                    ActivityId = Guid.Parse("{B0788D2F-8003-43C5-92A4-EDC76A7C5DDE}"),
                    UserId = "940a1b37-3131-49b7-beb9-f37be7e2b536",
                    UserName = "bob",
                    Email = "bob@test.com",
                    IsHost = true
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{bee9b166-1f71-46e2-86aa-1f4bdb9932c0}"),
                    ActivityId = Guid.Parse("{B0788D2F-8003-43C5-92A4-EDC76A7C5DDE}"),
                    UserId = "868bfa6f-2f65-4a89-8f24-7f0d4d897a0f",
                    UserName = "tom",
                    Email = "tom@test.com",
                    IsHost = false
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{d1760bb5-b9e8-4dea-9550-7c59084b3874}"),
                    ActivityId = Guid.Parse("{B0788D2F-8003-43C7-92A4-EDC76A7C5DDE}"),
                    UserId = "95036e9b-23d2-4f20-968b-85d5098d46d6",
                    UserName = "jane",
                    Email = "jane@test.com",
                    IsHost = true
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{13665690-c91a-4382-8615-863dc196a256}"),
                    ActivityId = Guid.Parse("{B0788D2F-8003-43C7-92A4-EDC76A7C5DDE}"),
                    UserId = "940a1b37-3131-49b7-beb9-f37be7e2b536",
                    UserName = "bob",
                    Email = "bob@test.com",
                    IsHost = false
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{70282896-a9a6-4a02-8963-d432ce9d744f}"),
                    ActivityId = Guid.Parse("{B0788D2F-8003-43C1-42A4-EDC76A7C5DDE}"),
                    UserId = "95036e9b-23d2-4f20-968b-85d5098d46d6",
                    UserName = "jane",
                    Email = "jane@test.com",
                    IsHost = true
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{107a0dcf-03ca-4478-be12-e22a83cfde70}"),
                    ActivityId = Guid.Parse("{B0788D2F-8003-46C1-92A4-EDC76A7C5DDE}"),
                    UserId = "940a1b37-3131-49b7-beb9-f37be7e2b536",
                    UserName = "bob",
                    Email = "bob@test.com",
                    IsHost = true
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{53f666e7-f71c-4db7-b42f-0b7ec5550c1a}"),
                    ActivityId = Guid.Parse("{B0788D2F-8003-46C1-92A4-EDC76A7C5DDE}"),
                    UserId = "95036e9b-23d2-4f20-968b-85d5098d46d6",
                    UserName = "jane",
                    Email = "jane@test.com",
                    IsHost = false
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{f6d49e42-19bf-419c-a675-f4fd0d1885bc}"),
                    ActivityId = Guid.Parse("{B0788D2E-8003-43C1-92A4-EDC76A7C5DDE}"),
                    UserId = "868bfa6f-2f65-4a89-8f24-7f0d4d897a0f",
                    UserName = "tom",
                    Email = "tom@test.com",
                    IsHost = true
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{3601016a-6613-42ac-8713-0aa4153c90b8}"),
                    ActivityId = Guid.Parse("{B0788D2E-8003-43C1-92A4-EDC76A7C5DDE}"),
                    UserId = "95036e9b-23d2-4f20-968b-85d5098d46d6",
                    UserName = "jane",
                    Email = "jane@test.com",
                    IsHost = false
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{8d7c889c-8efd-4777-abd0-3abad89c40c2}"),
                    ActivityId = Guid.Parse("{B0768D2F-8003-43C1-92A4-EDC76A7C5DDE}"),
                    UserId = "940a1b37-3131-49b7-beb9-f37be7e2b536",
                    UserName = "bob",
                    Email = "bob@test.com",
                    IsHost = true
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{72751074-d753-4e58-9c78-89e764cbdce4}"),
                    ActivityId = Guid.Parse("{B0768D2F-8003-43C1-92A4-EDC76A7C5DDE}"),
                    UserId = "868bfa6f-2f65-4a89-8f24-7f0d4d897a0f",
                    UserName = "tom",
                    Email = "tom@test.com",
                    IsHost = false
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{7afcbc1c-2c98-4b17-be34-3d30c2ff646c}"),
                    ActivityId = Guid.Parse("{B0788D2F-8003-43C1-92E4-EDC76A7C5DDE}"),
                    UserId = "868bfa6f-2f65-4a89-8f24-7f0d4d897a0f",
                    UserName = "tom",
                    Email = "tom@test.com",
                    IsHost = true
                },
                new ActivityAttendee
                {
                    ActivityAttendeeId = Guid.Parse("{3f843a09-85f5-4658-b36c-2da9b463d0d3}"),
                    ActivityId = Guid.Parse("{B0788D2F-8003-43C1-92E4-EDC76A7C5DDE}"),
                    UserId = "95036e9b-23d2-4f20-968b-85d5098d46d6",
                    UserName = "jane",
                    Email = "jane@test.com",
                    IsHost = false
                }
            };

            modelBuilder.Entity<ActivityAttendee>().HasData(attendees);
        }
    }
}
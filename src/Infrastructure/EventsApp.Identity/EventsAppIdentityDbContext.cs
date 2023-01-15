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
            var users = new List<ApplicationUser>
            {
                new ApplicationUser
                {
                    DisplayName = "Admin",
                    Bio = "Meet the admin of this website, a man who could fix your computer with his eyes closed (but please don't make him do that). He's a self-proclaimed computer geek and is always on the lookout for the next big tech innovation. When he's not coding, you can find him playing video games, building his own PCs, or trying to figure out how to make the office coffee machine work (it's not going well). Just don't ask him about his collection of Star Trek memorabilia, you may never leave.",
                    UserName = "admin",
                    NormalizedUserName = "admin",
                    Email = "admin@test.com",
                    NormalizedEmail= "admin@test.com",
                    EmailConfirmed = true
                },
                new ApplicationUser
                {
                    DisplayName = "Bob",
                    UserName = "bob",
                    Bio = "Bob is a hardworking individual with a passion for learning new things. He enjoys spending his free time exploring the outdoors and is an avid sports fan. Bob is also a dedicated family man who values spending time with his loved ones. He is a team player and is always willing to lend a helping hand to his colleagues. Bob's positive attitude and strong work ethic make him an asset to any team.",
                    NormalizedUserName = "bob",
                    Email = "bob@test.com",
                    NormalizedEmail= "bob@test.com",
                    EmailConfirmed = true
                },
                new ApplicationUser
                {
                    DisplayName = "Jane",
                    Bio = "Jane is a woman of many talents, but most importantly, she has a great sense of humor. She's been known to turn a boring meeting into a comedy show and to make even the grimmest Monday morning bearable with her quick wit. When she's not cracking jokes, you can find her whipping up a storm in the kitchen, binge-watching her favorite shows, or planning her next adventure. Just don't ask her to pick a favorite ice cream flavor, she'll be there for hours.",
                    UserName = "jane",
                    NormalizedUserName = "jane",
                    Email = "jane@test.com",
                    NormalizedEmail= "jane@test.com",
                    EmailConfirmed = true
                },
                new ApplicationUser
                {
                    DisplayName = "Tom",
                    Bio = "Tom is a businessman who always has his schedule planned out months in advance, but that doesn't mean he doesn't know how to have fun. When he's not closing deals, you can find him hitting the dance floor, trying new cocktails or planning his next vacation, where he'll probably plan his schedule for the next year. Just don't ask him to be spontaneous, it's not in his schedule.",
                    UserName = "tom",
                    NormalizedUserName = "tom",
                    Email = "tom@test.com",
                    NormalizedEmail= "tom@test.com",
                    EmailConfirmed = true
                }
            };

            PasswordHasher<ApplicationUser> passwordHasher = new();

            foreach (var user in users)
            {   
                user.PasswordHash = passwordHasher.HashPassword(user, "User@123");
            }
            
            builder.Entity<ApplicationUser>().HasData(users);
        }
    }
}
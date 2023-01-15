using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventsApp.Identity.Migrations
{
    /// <inheritdoc />
    public partial class AddUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a2d21df-2919-404d-8887-c69f8971d8dd");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "520f774c-804c-45cb-95dd-85cc844f38d8", 0, "Meet the admin of this website, a man who could fix your computer with his eyes closed (but please don't make him do that). He's a self-proclaimed computer geek and is always on the lookout for the next big tech innovation. When he's not coding, you can find him playing video games, building his own PCs, or trying to figure out how to make the office coffee machine work (it's not going well). Just don't ask him about his collection of Star Trek memorabilia, you may never leave.", "e113d7ee-2727-4d9c-9f0d-4d053571c0d2", "Admin", "admin@test.com", true, false, null, "admin@test.com", "admin", "AQAAAAIAAYagAAAAEIhv2y2uDXNmLWCrZQVA45iHtxEHoQXvz867thF2uuwD9JweWqhKcGwTYMJiG5bNrg==", null, false, "b8704e04-99e9-4628-bef6-e4e11209e477", false, "admin" },
                    { "868bfa6f-2f65-4a89-8f24-7f0d4d897a0f", 0, "Tom is a businessman who always has his schedule planned out months in advance, but that doesn't mean he doesn't know how to have fun. When he's not closing deals, you can find him hitting the dance floor, trying new cocktails or planning his next vacation, where he'll probably plan his schedule for the next year. Just don't ask him to be spontaneous, it's not in his schedule.", "5328e85b-7868-41a9-b183-ddc5082f23b7", "Tom", "tom@test.com", true, false, null, "tom@test.com", "tom", "AQAAAAIAAYagAAAAEPsQpYwdFxsWdXyEzaxN0s73LQ2aRS8Vnf60SsQpS/mLihCatN7HXaSAv20P9NVAmg==", null, false, "a9222963-96db-4d00-83e1-9e9df8591fb4", false, "tom" },
                    { "940a1b37-3131-49b7-beb9-f37be7e2b536", 0, "Bob is a hardworking individual with a passion for learning new things. He enjoys spending his free time exploring the outdoors and is an avid sports fan. Bob is also a dedicated family man who values spending time with his loved ones. He is a team player and is always willing to lend a helping hand to his colleagues. Bob's positive attitude and strong work ethic make him an asset to any team.", "289d9c51-d8ed-4130-b39a-76415a84cf59", "Bob", "bob@test.com", true, false, null, "bob@test.com", "bob", "AQAAAAIAAYagAAAAEMPf6TAy0do1YSpsvxvxEiYcUQ8fM9a5TUjDn03yd9vmwM7d0W30EB1Bpov7VrxWRw==", null, false, "8aa5d535-25e2-4ab9-9819-3987fea68338", false, "bob" },
                    { "95036e9b-23d2-4f20-968b-85d5098d46d6", 0, "Jane is a woman of many talents, but most importantly, she has a great sense of humor. She's been known to turn a boring meeting into a comedy show and to make even the grimmest Monday morning bearable with her quick wit. When she's not cracking jokes, you can find her whipping up a storm in the kitchen, binge-watching her favorite shows, or planning her next adventure. Just don't ask her to pick a favorite ice cream flavor, she'll be there for hours.", "f55e9679-b184-4c34-9382-209915b9d22e", "Jane", "jane@test.com", true, false, null, "jane@test.com", "jane", "AQAAAAIAAYagAAAAEF2TetMnbFl90PkLtRMqdw0ifNV91ts2HPdKV+9eN5gh0HgehSDPZF6H6Zf2vatbnA==", null, false, "cb5ea324-f690-4a30-b130-99fe01a91d51", false, "jane" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "520f774c-804c-45cb-95dd-85cc844f38d8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "868bfa6f-2f65-4a89-8f24-7f0d4d897a0f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "940a1b37-3131-49b7-beb9-f37be7e2b536");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95036e9b-23d2-4f20-968b-85d5098d46d6");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9a2d21df-2919-404d-8887-c69f8971d8dd", 0, "I'm an admin", "64e2d6ea-7a1d-4a27-ab50-faf7c50f1bb3", "Admin", "admin@admin.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEMiO4s65JIqTv1M5y0V4Prt+tcmSmrmoZFL5XkymscBW/SyXEV/5pHzQ62zq1kVbjw==", null, false, "2fe815e2-4227-4012-8c82-971c89f239f4", false, "admin" });
        }
    }
}

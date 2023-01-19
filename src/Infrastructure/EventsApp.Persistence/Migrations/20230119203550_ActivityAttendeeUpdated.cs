using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventsApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ActivityAttendeeUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("107a0dcf-03ca-4478-be12-e22a83cfde70"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("13665690-c91a-4382-8615-863dc196a256"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("3601016a-6613-42ac-8713-0aa4153c90b8"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("3f843a09-85f5-4658-b36c-2da9b463d0d3"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("41232c7a-1714-4025-bd01-2de96444c18f"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("41fddd3c-8811-4048-aa99-de65e85053b5"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("53f666e7-f71c-4db7-b42f-0b7ec5550c1a"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("553a08fd-b8f6-4268-885d-68108a9c29d8"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("5c757487-a4d5-4207-b9b6-4641cde9737a"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("70282896-a9a6-4a02-8963-d432ce9d744f"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("72751074-d753-4e58-9c78-89e764cbdce4"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("7afcbc1c-2c98-4b17-be34-3d30c2ff646c"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("8bd114c1-cf96-430a-9624-cb9df7b3b8d4"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("8d7c889c-8efd-4777-abd0-3abad89c40c2"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("9db3248d-5d20-4474-b634-63b1d8cb97d8"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("bee9b166-1f71-46e2-86aa-1f4bdb9932c0"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("d1760bb5-b9e8-4dea-9550-7c59084b3874"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("f6d49e42-19bf-419c-a675-f4fd0d1885bc"));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0708d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2022, 12, 19, 21, 35, 50, 634, DateTimeKind.Local).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0768d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 8, 19, 21, 35, 50, 634, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2e-8003-43c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 7, 19, 21, 35, 50, 634, DateTimeKind.Local).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-42a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 5, 19, 21, 35, 50, 634, DateTimeKind.Local).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76a7d5dde"),
                column: "Date",
                value: new DateTime(2023, 2, 19, 21, 35, 50, 634, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76b7c5dde"),
                column: "Date",
                value: new DateTime(2022, 11, 19, 21, 35, 50, 634, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92e4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 9, 19, 21, 35, 50, 634, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c5-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 3, 19, 21, 35, 50, 634, DateTimeKind.Local).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c7-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 4, 19, 21, 35, 50, 634, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-46c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 6, 19, 21, 35, 50, 634, DateTimeKind.Local).AddTicks(1204));

            migrationBuilder.InsertData(
                table: "ActivityAttendees",
                columns: new[] { "ActivityAttendeeId", "ActivityId", "Bio", "DisplayName", "Email", "Image", "IsHost", "UserId", "UserName" },
                values: new object[,]
                {
                    { new Guid("16c4764a-a85c-4d31-98e7-b22a83915cff"), new Guid("b0788d2f-8003-43c7-92a4-edc76a7c5dde"), "Bob is a hardworking individual with a passion for learning new things. He enjoys spending his free time exploring the outdoors and is an avid sports fan. Bob is also a dedicated family man who values spending time with his loved ones. He is a team player and is always willing to lend a helping hand to his colleagues. Bob's positive attitude and strong work ethic make him an asset to any team.", "Bob", "bob@test.com", null, false, "7a8a088d-a38e-4187-a3d8-4545ab080450", "bob" },
                    { new Guid("23183bdc-a1db-45db-824f-179cf8a8c331"), new Guid("b0788d2f-8003-43c1-92a4-edc76a7d5dde"), "Tom is a businessman who always has his schedule planned out months in advance, but that doesn't mean he doesn't know how to have fun. When he's not closing deals, you can find him hitting the dance floor, trying new cocktails or planning his next vacation, where he'll probably plan his schedule for the next year. Just don't ask him to be spontaneous, it's not in his schedule.", "Tom", "tom@test.com", null, true, "84b07d25-a856-466d-a3a8-4ca6df8630e3", "tom" },
                    { new Guid("30156295-b85c-429f-8924-f019a37db3d3"), new Guid("b0768d2f-8003-43c1-92a4-edc76a7c5dde"), "Bob is a hardworking individual with a passion for learning new things. He enjoys spending his free time exploring the outdoors and is an avid sports fan. Bob is also a dedicated family man who values spending time with his loved ones. He is a team player and is always willing to lend a helping hand to his colleagues. Bob's positive attitude and strong work ethic make him an asset to any team.", "Bob", "bob@test.com", null, true, "7a8a088d-a38e-4187-a3d8-4545ab080450", "bob" },
                    { new Guid("38b42910-ed98-424e-97ce-2887ae1ef97d"), new Guid("b0788d2f-8003-43c1-92e4-edc76a7c5dde"), "Tom is a businessman who always has his schedule planned out months in advance, but that doesn't mean he doesn't know how to have fun. When he's not closing deals, you can find him hitting the dance floor, trying new cocktails or planning his next vacation, where he'll probably plan his schedule for the next year. Just don't ask him to be spontaneous, it's not in his schedule.", "Tom", "tom@test.com", null, true, "84b07d25-a856-466d-a3a8-4ca6df8630e3", "tom" },
                    { new Guid("3ab3d0ca-bb82-4c17-ae50-2e5d782e05fd"), new Guid("b0788d2e-8003-43c1-92a4-edc76a7c5dde"), "Tom is a businessman who always has his schedule planned out months in advance, but that doesn't mean he doesn't know how to have fun. When he's not closing deals, you can find him hitting the dance floor, trying new cocktails or planning his next vacation, where he'll probably plan his schedule for the next year. Just don't ask him to be spontaneous, it's not in his schedule.", "Tom", "tom@test.com", null, true, "84b07d25-a856-466d-a3a8-4ca6df8630e3", "tom" },
                    { new Guid("4ebe321f-f48b-4574-9098-1453fdde0331"), new Guid("b0788d2f-8003-43c7-92a4-edc76a7c5dde"), "Jane is a woman of many talents, but most importantly, she has a great sense of humor. She's been known to turn a boring meeting into a comedy show and to make even the grimmest Monday morning bearable with her quick wit. When she's not cracking jokes, you can find her whipping up a storm in the kitchen, binge-watching her favorite shows, or planning her next adventure. Just don't ask her to pick a favorite ice cream flavor, she'll be there for hours.", "Jane", "jane@test.com", null, true, "6df9eb93-33c0-42c0-a85d-cdd96ccd4899", "jane" },
                    { new Guid("525b8837-3935-4900-8aab-09f5dce68b4a"), new Guid("b0788d2f-8003-43c5-92a4-edc76a7c5dde"), "Tom is a businessman who always has his schedule planned out months in advance, but that doesn't mean he doesn't know how to have fun. When he's not closing deals, you can find him hitting the dance floor, trying new cocktails or planning his next vacation, where he'll probably plan his schedule for the next year. Just don't ask him to be spontaneous, it's not in his schedule.", "Tom", "tom@test.com", null, false, "84b07d25-a856-466d-a3a8-4ca6df8630e3", "tom" },
                    { new Guid("6137ddf4-523f-4392-a9cd-d947ac6cdf5a"), new Guid("b0788d2f-8003-43c1-92e4-edc76a7c5dde"), "Jane is a woman of many talents, but most importantly, she has a great sense of humor. She's been known to turn a boring meeting into a comedy show and to make even the grimmest Monday morning bearable with her quick wit. When she's not cracking jokes, you can find her whipping up a storm in the kitchen, binge-watching her favorite shows, or planning her next adventure. Just don't ask her to pick a favorite ice cream flavor, she'll be there for hours.", "Jane", "jane@test.com", null, false, "6df9eb93-33c0-42c0-a85d-cdd96ccd4899", "jane" },
                    { new Guid("7f876625-4407-4439-916a-203bb144e5a3"), new Guid("b0788d2e-8003-43c1-92a4-edc76a7c5dde"), "Jane is a woman of many talents, but most importantly, she has a great sense of humor. She's been known to turn a boring meeting into a comedy show and to make even the grimmest Monday morning bearable with her quick wit. When she's not cracking jokes, you can find her whipping up a storm in the kitchen, binge-watching her favorite shows, or planning her next adventure. Just don't ask her to pick a favorite ice cream flavor, she'll be there for hours.", "Jane", "jane@test.com", null, false, "6df9eb93-33c0-42c0-a85d-cdd96ccd4899", "jane" },
                    { new Guid("87a262c6-c597-4c2d-97fe-732a2737e406"), new Guid("b0788d2f-8003-43c1-92a4-edc76a7d5dde"), "Jane is a woman of many talents, but most importantly, she has a great sense of humor. She's been known to turn a boring meeting into a comedy show and to make even the grimmest Monday morning bearable with her quick wit. When she's not cracking jokes, you can find her whipping up a storm in the kitchen, binge-watching her favorite shows, or planning her next adventure. Just don't ask her to pick a favorite ice cream flavor, she'll be there for hours.", "Jane", "jane@test.com", null, false, "6df9eb93-33c0-42c0-a85d-cdd96ccd4899", "jane" },
                    { new Guid("90c71ad5-cc49-4b3a-bf58-28c7e776d61f"), new Guid("b0708d2f-8003-43c1-92a4-edc76a7c5dde"), "Bob is a hardworking individual with a passion for learning new things. He enjoys spending his free time exploring the outdoors and is an avid sports fan. Bob is also a dedicated family man who values spending time with his loved ones. He is a team player and is always willing to lend a helping hand to his colleagues. Bob's positive attitude and strong work ethic make him an asset to any team.", "Bob", "bob@test.com", null, true, "7a8a088d-a38e-4187-a3d8-4545ab080450", "bob" },
                    { new Guid("b9d2ed76-e6c1-4d56-80e4-95e055f02f49"), new Guid("b0768d2f-8003-43c1-92a4-edc76a7c5dde"), "Tom is a businessman who always has his schedule planned out months in advance, but that doesn't mean he doesn't know how to have fun. When he's not closing deals, you can find him hitting the dance floor, trying new cocktails or planning his next vacation, where he'll probably plan his schedule for the next year. Just don't ask him to be spontaneous, it's not in his schedule.", "Tom", "tom@test.com", null, false, "84b07d25-a856-466d-a3a8-4ca6df8630e3", "tom" },
                    { new Guid("bdc6adab-a35a-4a3a-bc4b-63482e724f99"), new Guid("b0788d2f-8003-46c1-92a4-edc76a7c5dde"), "Bob is a hardworking individual with a passion for learning new things. He enjoys spending his free time exploring the outdoors and is an avid sports fan. Bob is also a dedicated family man who values spending time with his loved ones. He is a team player and is always willing to lend a helping hand to his colleagues. Bob's positive attitude and strong work ethic make him an asset to any team.", "Bob", "bob@test.com", null, true, "7a8a088d-a38e-4187-a3d8-4545ab080450", "bob" },
                    { new Guid("c5b2be3b-627e-47cd-b893-18de572aaa71"), new Guid("b0788d2f-8003-43c1-92a4-edc76b7c5dde"), "Bob is a hardworking individual with a passion for learning new things. He enjoys spending his free time exploring the outdoors and is an avid sports fan. Bob is also a dedicated family man who values spending time with his loved ones. He is a team player and is always willing to lend a helping hand to his colleagues. Bob's positive attitude and strong work ethic make him an asset to any team.", "Bob", "bob@test.com", null, true, "7a8a088d-a38e-4187-a3d8-4545ab080450", "bob" },
                    { new Guid("d0d1684b-861d-4700-adf1-ec457b50d7e6"), new Guid("b0788d2f-8003-43c1-42a4-edc76a7c5dde"), "Jane is a woman of many talents, but most importantly, she has a great sense of humor. She's been known to turn a boring meeting into a comedy show and to make even the grimmest Monday morning bearable with her quick wit. When she's not cracking jokes, you can find her whipping up a storm in the kitchen, binge-watching her favorite shows, or planning her next adventure. Just don't ask her to pick a favorite ice cream flavor, she'll be there for hours.", "Jane", "jane@test.com", null, true, "6df9eb93-33c0-42c0-a85d-cdd96ccd4899", "jane" },
                    { new Guid("ee8f3cfc-2ee1-40a0-824e-30c89a6fde6c"), new Guid("b0788d2f-8003-43c5-92a4-edc76a7c5dde"), "Bob is a hardworking individual with a passion for learning new things. He enjoys spending his free time exploring the outdoors and is an avid sports fan. Bob is also a dedicated family man who values spending time with his loved ones. He is a team player and is always willing to lend a helping hand to his colleagues. Bob's positive attitude and strong work ethic make him an asset to any team.", "Bob", "bob@test.com", null, true, "7a8a088d-a38e-4187-a3d8-4545ab080450", "bob" },
                    { new Guid("f185ce01-3ba6-455a-b5c7-3dcb7b08fcad"), new Guid("b0788d2f-8003-46c1-92a4-edc76a7c5dde"), "Jane is a woman of many talents, but most importantly, she has a great sense of humor. She's been known to turn a boring meeting into a comedy show and to make even the grimmest Monday morning bearable with her quick wit. When she's not cracking jokes, you can find her whipping up a storm in the kitchen, binge-watching her favorite shows, or planning her next adventure. Just don't ask her to pick a favorite ice cream flavor, she'll be there for hours.", "Jane", "jane@test.com", null, false, "6df9eb93-33c0-42c0-a85d-cdd96ccd4899", "jane" },
                    { new Guid("fa64ad37-8e1b-4fc5-9ee3-ad69c8cdf798"), new Guid("b0708d2f-8003-43c1-92a4-edc76a7c5dde"), "Jane is a woman of many talents, but most importantly, she has a great sense of humor. She's been known to turn a boring meeting into a comedy show and to make even the grimmest Monday morning bearable with her quick wit. When she's not cracking jokes, you can find her whipping up a storm in the kitchen, binge-watching her favorite shows, or planning her next adventure. Just don't ask her to pick a favorite ice cream flavor, she'll be there for hours.", "Jane", "jane@test.com", null, false, "6df9eb93-33c0-42c0-a85d-cdd96ccd4899", "jane" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("16c4764a-a85c-4d31-98e7-b22a83915cff"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("23183bdc-a1db-45db-824f-179cf8a8c331"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("30156295-b85c-429f-8924-f019a37db3d3"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("38b42910-ed98-424e-97ce-2887ae1ef97d"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("3ab3d0ca-bb82-4c17-ae50-2e5d782e05fd"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("4ebe321f-f48b-4574-9098-1453fdde0331"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("525b8837-3935-4900-8aab-09f5dce68b4a"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("6137ddf4-523f-4392-a9cd-d947ac6cdf5a"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("7f876625-4407-4439-916a-203bb144e5a3"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("87a262c6-c597-4c2d-97fe-732a2737e406"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("90c71ad5-cc49-4b3a-bf58-28c7e776d61f"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("b9d2ed76-e6c1-4d56-80e4-95e055f02f49"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("bdc6adab-a35a-4a3a-bc4b-63482e724f99"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("c5b2be3b-627e-47cd-b893-18de572aaa71"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("d0d1684b-861d-4700-adf1-ec457b50d7e6"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("ee8f3cfc-2ee1-40a0-824e-30c89a6fde6c"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("f185ce01-3ba6-455a-b5c7-3dcb7b08fcad"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("fa64ad37-8e1b-4fc5-9ee3-ad69c8cdf798"));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0708d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2022, 12, 19, 21, 22, 46, 561, DateTimeKind.Local).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0768d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 8, 19, 21, 22, 46, 561, DateTimeKind.Local).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2e-8003-43c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 7, 19, 21, 22, 46, 561, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-42a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 5, 19, 21, 22, 46, 561, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76a7d5dde"),
                column: "Date",
                value: new DateTime(2023, 2, 19, 21, 22, 46, 561, DateTimeKind.Local).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76b7c5dde"),
                column: "Date",
                value: new DateTime(2022, 11, 19, 21, 22, 46, 561, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92e4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 9, 19, 21, 22, 46, 561, DateTimeKind.Local).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c5-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 3, 19, 21, 22, 46, 561, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c7-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 4, 19, 21, 22, 46, 561, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-46c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 6, 19, 21, 22, 46, 561, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.InsertData(
                table: "ActivityAttendees",
                columns: new[] { "ActivityAttendeeId", "ActivityId", "Bio", "DisplayName", "Email", "Image", "IsHost", "UserId", "UserName" },
                values: new object[,]
                {
                    { new Guid("107a0dcf-03ca-4478-be12-e22a83cfde70"), new Guid("b0788d2f-8003-46c1-92a4-edc76a7c5dde"), "Bob is a hardworking individual with a passion for learning new things. He enjoys spending his free time exploring the outdoors and is an avid sports fan. Bob is also a dedicated family man who values spending time with his loved ones. He is a team player and is always willing to lend a helping hand to his colleagues. Bob's positive attitude and strong work ethic make him an asset to any team.", "Bob", "bob@test.com", null, true, "7a8a088d-a38e-4187-a3d8-4545ab080450", "bob" },
                    { new Guid("13665690-c91a-4382-8615-863dc196a256"), new Guid("b0788d2f-8003-43c7-92a4-edc76a7c5dde"), "Bob is a hardworking individual with a passion for learning new things. He enjoys spending his free time exploring the outdoors and is an avid sports fan. Bob is also a dedicated family man who values spending time with his loved ones. He is a team player and is always willing to lend a helping hand to his colleagues. Bob's positive attitude and strong work ethic make him an asset to any team.", "Bob", "bob@test.com", null, false, "7a8a088d-a38e-4187-a3d8-4545ab080450", "bob" },
                    { new Guid("3601016a-6613-42ac-8713-0aa4153c90b8"), new Guid("b0788d2e-8003-43c1-92a4-edc76a7c5dde"), "Jane is a woman of many talents, but most importantly, she has a great sense of humor. She's been known to turn a boring meeting into a comedy show and to make even the grimmest Monday morning bearable with her quick wit. When she's not cracking jokes, you can find her whipping up a storm in the kitchen, binge-watching her favorite shows, or planning her next adventure. Just don't ask her to pick a favorite ice cream flavor, she'll be there for hours.", "Jane", "jane@test.com", null, false, "6df9eb93-33c0-42c0-a85d-cdd96ccd4899", "jane" },
                    { new Guid("3f843a09-85f5-4658-b36c-2da9b463d0d3"), new Guid("b0788d2f-8003-43c1-92e4-edc76a7c5dde"), "Jane is a woman of many talents, but most importantly, she has a great sense of humor. She's been known to turn a boring meeting into a comedy show and to make even the grimmest Monday morning bearable with her quick wit. When she's not cracking jokes, you can find her whipping up a storm in the kitchen, binge-watching her favorite shows, or planning her next adventure. Just don't ask her to pick a favorite ice cream flavor, she'll be there for hours.", "Jane", "jane@test.com", null, false, "6df9eb93-33c0-42c0-a85d-cdd96ccd4899", "jane" },
                    { new Guid("41232c7a-1714-4025-bd01-2de96444c18f"), new Guid("b0788d2f-8003-43c1-92a4-edc76a7d5dde"), "Jane is a woman of many talents, but most importantly, she has a great sense of humor. She's been known to turn a boring meeting into a comedy show and to make even the grimmest Monday morning bearable with her quick wit. When she's not cracking jokes, you can find her whipping up a storm in the kitchen, binge-watching her favorite shows, or planning her next adventure. Just don't ask her to pick a favorite ice cream flavor, she'll be there for hours.", "Jane", "jane@test.com", null, false, "6df9eb93-33c0-42c0-a85d-cdd96ccd4899", "jane" },
                    { new Guid("41fddd3c-8811-4048-aa99-de65e85053b5"), new Guid("b0788d2f-8003-43c5-92a4-edc76a7c5dde"), "Bob is a hardworking individual with a passion for learning new things. He enjoys spending his free time exploring the outdoors and is an avid sports fan. Bob is also a dedicated family man who values spending time with his loved ones. He is a team player and is always willing to lend a helping hand to his colleagues. Bob's positive attitude and strong work ethic make him an asset to any team.", "Bob", "bob@test.com", null, true, "7a8a088d-a38e-4187-a3d8-4545ab080450", "bob" },
                    { new Guid("53f666e7-f71c-4db7-b42f-0b7ec5550c1a"), new Guid("b0788d2f-8003-46c1-92a4-edc76a7c5dde"), "Jane is a woman of many talents, but most importantly, she has a great sense of humor. She's been known to turn a boring meeting into a comedy show and to make even the grimmest Monday morning bearable with her quick wit. When she's not cracking jokes, you can find her whipping up a storm in the kitchen, binge-watching her favorite shows, or planning her next adventure. Just don't ask her to pick a favorite ice cream flavor, she'll be there for hours.", "Jane", "jane@test.com", null, false, "6df9eb93-33c0-42c0-a85d-cdd96ccd4899", "jane" },
                    { new Guid("553a08fd-b8f6-4268-885d-68108a9c29d8"), new Guid("b0708d2f-8003-43c1-92a4-edc76a7c5dde"), "Jane is a woman of many talents, but most importantly, she has a great sense of humor. She's been known to turn a boring meeting into a comedy show and to make even the grimmest Monday morning bearable with her quick wit. When she's not cracking jokes, you can find her whipping up a storm in the kitchen, binge-watching her favorite shows, or planning her next adventure. Just don't ask her to pick a favorite ice cream flavor, she'll be there for hours.", "Jane", "jane@test.com", null, false, "6df9eb93-33c0-42c0-a85d-cdd96ccd4899", "jane" },
                    { new Guid("5c757487-a4d5-4207-b9b6-4641cde9737a"), new Guid("b0708d2f-8003-43c1-92a4-edc76a7c5dde"), "Bob is a hardworking individual with a passion for learning new things. He enjoys spending his free time exploring the outdoors and is an avid sports fan. Bob is also a dedicated family man who values spending time with his loved ones. He is a team player and is always willing to lend a helping hand to his colleagues. Bob's positive attitude and strong work ethic make him an asset to any team.", "Bob", "bob@test.com", null, true, "7a8a088d-a38e-4187-a3d8-4545ab080450", "bob" },
                    { new Guid("70282896-a9a6-4a02-8963-d432ce9d744f"), new Guid("b0788d2f-8003-43c1-42a4-edc76a7c5dde"), "Jane is a woman of many talents, but most importantly, she has a great sense of humor. She's been known to turn a boring meeting into a comedy show and to make even the grimmest Monday morning bearable with her quick wit. When she's not cracking jokes, you can find her whipping up a storm in the kitchen, binge-watching her favorite shows, or planning her next adventure. Just don't ask her to pick a favorite ice cream flavor, she'll be there for hours.", "Jane", "jane@test.com", null, true, "6df9eb93-33c0-42c0-a85d-cdd96ccd4899", "jane" },
                    { new Guid("72751074-d753-4e58-9c78-89e764cbdce4"), new Guid("b0768d2f-8003-43c1-92a4-edc76a7c5dde"), "Tom is a businessman who always has his schedule planned out months in advance, but that doesn't mean he doesn't know how to have fun. When he's not closing deals, you can find him hitting the dance floor, trying new cocktails or planning his next vacation, where he'll probably plan his schedule for the next year. Just don't ask him to be spontaneous, it's not in his schedule.", "Tom", "tom@test.com", null, false, "84b07d25-a856-466d-a3a8-4ca6df8630e3", "tom" },
                    { new Guid("7afcbc1c-2c98-4b17-be34-3d30c2ff646c"), new Guid("b0788d2f-8003-43c1-92e4-edc76a7c5dde"), "Tom is a businessman who always has his schedule planned out months in advance, but that doesn't mean he doesn't know how to have fun. When he's not closing deals, you can find him hitting the dance floor, trying new cocktails or planning his next vacation, where he'll probably plan his schedule for the next year. Just don't ask him to be spontaneous, it's not in his schedule.", "Tom", "tom@test.com", null, true, "84b07d25-a856-466d-a3a8-4ca6df8630e3", "tom" },
                    { new Guid("8bd114c1-cf96-430a-9624-cb9df7b3b8d4"), new Guid("b0788d2f-8003-43c1-92a4-edc76b7c5dde"), "Bob is a hardworking individual with a passion for learning new things. He enjoys spending his free time exploring the outdoors and is an avid sports fan. Bob is also a dedicated family man who values spending time with his loved ones. He is a team player and is always willing to lend a helping hand to his colleagues. Bob's positive attitude and strong work ethic make him an asset to any team.", "Bob", "bob@test.com", null, true, "7a8a088d-a38e-4187-a3d8-4545ab080450", "bob" },
                    { new Guid("8d7c889c-8efd-4777-abd0-3abad89c40c2"), new Guid("b0768d2f-8003-43c1-92a4-edc76a7c5dde"), "Bob is a hardworking individual with a passion for learning new things. He enjoys spending his free time exploring the outdoors and is an avid sports fan. Bob is also a dedicated family man who values spending time with his loved ones. He is a team player and is always willing to lend a helping hand to his colleagues. Bob's positive attitude and strong work ethic make him an asset to any team.", "Bob", "bob@test.com", null, true, "7a8a088d-a38e-4187-a3d8-4545ab080450", "bob" },
                    { new Guid("9db3248d-5d20-4474-b634-63b1d8cb97d8"), new Guid("b0788d2f-8003-43c1-92a4-edc76a7d5dde"), "Tom is a businessman who always has his schedule planned out months in advance, but that doesn't mean he doesn't know how to have fun. When he's not closing deals, you can find him hitting the dance floor, trying new cocktails or planning his next vacation, where he'll probably plan his schedule for the next year. Just don't ask him to be spontaneous, it's not in his schedule.", "Tom", "tom@test.com", null, true, "84b07d25-a856-466d-a3a8-4ca6df8630e3", "tom" },
                    { new Guid("bee9b166-1f71-46e2-86aa-1f4bdb9932c0"), new Guid("b0788d2f-8003-43c5-92a4-edc76a7c5dde"), "Tom is a businessman who always has his schedule planned out months in advance, but that doesn't mean he doesn't know how to have fun. When he's not closing deals, you can find him hitting the dance floor, trying new cocktails or planning his next vacation, where he'll probably plan his schedule for the next year. Just don't ask him to be spontaneous, it's not in his schedule.", "Tom", "tom@test.com", null, false, "84b07d25-a856-466d-a3a8-4ca6df8630e3", "tom" },
                    { new Guid("d1760bb5-b9e8-4dea-9550-7c59084b3874"), new Guid("b0788d2f-8003-43c7-92a4-edc76a7c5dde"), "Jane is a woman of many talents, but most importantly, she has a great sense of humor. She's been known to turn a boring meeting into a comedy show and to make even the grimmest Monday morning bearable with her quick wit. When she's not cracking jokes, you can find her whipping up a storm in the kitchen, binge-watching her favorite shows, or planning her next adventure. Just don't ask her to pick a favorite ice cream flavor, she'll be there for hours.", "Jane", "jane@test.com", null, true, "6df9eb93-33c0-42c0-a85d-cdd96ccd4899", "jane" },
                    { new Guid("f6d49e42-19bf-419c-a675-f4fd0d1885bc"), new Guid("b0788d2e-8003-43c1-92a4-edc76a7c5dde"), "Tom is a businessman who always has his schedule planned out months in advance, but that doesn't mean he doesn't know how to have fun. When he's not closing deals, you can find him hitting the dance floor, trying new cocktails or planning his next vacation, where he'll probably plan his schedule for the next year. Just don't ask him to be spontaneous, it's not in his schedule.", "Tom", "tom@test.com", null, true, "84b07d25-a856-466d-a3a8-4ca6df8630e3", "tom" }
                });
        }
    }
}

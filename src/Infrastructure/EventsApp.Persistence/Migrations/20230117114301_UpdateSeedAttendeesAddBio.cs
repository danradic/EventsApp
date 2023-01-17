using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventsApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedAttendeesAddBio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0708d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2022, 12, 17, 12, 43, 0, 832, DateTimeKind.Local).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0768d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 8, 17, 12, 43, 0, 832, DateTimeKind.Local).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2e-8003-43c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 7, 17, 12, 43, 0, 832, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-42a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 5, 17, 12, 43, 0, 832, DateTimeKind.Local).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76a7d5dde"),
                column: "Date",
                value: new DateTime(2023, 2, 17, 12, 43, 0, 832, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76b7c5dde"),
                column: "Date",
                value: new DateTime(2022, 11, 17, 12, 43, 0, 832, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92e4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 9, 17, 12, 43, 0, 832, DateTimeKind.Local).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c5-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 3, 17, 12, 43, 0, 832, DateTimeKind.Local).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c7-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 4, 17, 12, 43, 0, 832, DateTimeKind.Local).AddTicks(2806));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-46c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 6, 17, 12, 43, 0, 832, DateTimeKind.Local).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("107a0dcf-03ca-4478-be12-e22a83cfde70"),
                column: "Bio",
                value: "Bob is a hardworking individual with a passion for learning new things. He enjoys spending his free time exploring the outdoors and is an avid sports fan. Bob is also a dedicated family man who values spending time with his loved ones. He is a team player and is always willing to lend a helping hand to his colleagues. Bob's positive attitude and strong work ethic make him an asset to any team.");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("13665690-c91a-4382-8615-863dc196a256"),
                column: "Bio",
                value: "Bob is a hardworking individual with a passion for learning new things. He enjoys spending his free time exploring the outdoors and is an avid sports fan. Bob is also a dedicated family man who values spending time with his loved ones. He is a team player and is always willing to lend a helping hand to his colleagues. Bob's positive attitude and strong work ethic make him an asset to any team.");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("3601016a-6613-42ac-8713-0aa4153c90b8"),
                column: "Bio",
                value: "Jane is a woman of many talents, but most importantly, she has a great sense of humor. She's been known to turn a boring meeting into a comedy show and to make even the grimmest Monday morning bearable with her quick wit. When she's not cracking jokes, you can find her whipping up a storm in the kitchen, binge-watching her favorite shows, or planning her next adventure. Just don't ask her to pick a favorite ice cream flavor, she'll be there for hours.");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("3f843a09-85f5-4658-b36c-2da9b463d0d3"),
                column: "Bio",
                value: "Jane is a woman of many talents, but most importantly, she has a great sense of humor. She's been known to turn a boring meeting into a comedy show and to make even the grimmest Monday morning bearable with her quick wit. When she's not cracking jokes, you can find her whipping up a storm in the kitchen, binge-watching her favorite shows, or planning her next adventure. Just don't ask her to pick a favorite ice cream flavor, she'll be there for hours.");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("41232c7a-1714-4025-bd01-2de96444c18f"),
                column: "Bio",
                value: "Jane is a woman of many talents, but most importantly, she has a great sense of humor. She's been known to turn a boring meeting into a comedy show and to make even the grimmest Monday morning bearable with her quick wit. When she's not cracking jokes, you can find her whipping up a storm in the kitchen, binge-watching her favorite shows, or planning her next adventure. Just don't ask her to pick a favorite ice cream flavor, she'll be there for hours.");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("41fddd3c-8811-4048-aa99-de65e85053b5"),
                column: "Bio",
                value: "Bob is a hardworking individual with a passion for learning new things. He enjoys spending his free time exploring the outdoors and is an avid sports fan. Bob is also a dedicated family man who values spending time with his loved ones. He is a team player and is always willing to lend a helping hand to his colleagues. Bob's positive attitude and strong work ethic make him an asset to any team.");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("53f666e7-f71c-4db7-b42f-0b7ec5550c1a"),
                column: "Bio",
                value: "Jane is a woman of many talents, but most importantly, she has a great sense of humor. She's been known to turn a boring meeting into a comedy show and to make even the grimmest Monday morning bearable with her quick wit. When she's not cracking jokes, you can find her whipping up a storm in the kitchen, binge-watching her favorite shows, or planning her next adventure. Just don't ask her to pick a favorite ice cream flavor, she'll be there for hours.");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("553a08fd-b8f6-4268-885d-68108a9c29d8"),
                column: "Bio",
                value: "Jane is a woman of many talents, but most importantly, she has a great sense of humor. She's been known to turn a boring meeting into a comedy show and to make even the grimmest Monday morning bearable with her quick wit. When she's not cracking jokes, you can find her whipping up a storm in the kitchen, binge-watching her favorite shows, or planning her next adventure. Just don't ask her to pick a favorite ice cream flavor, she'll be there for hours.");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("5c757487-a4d5-4207-b9b6-4641cde9737a"),
                column: "Bio",
                value: "Bob is a hardworking individual with a passion for learning new things. He enjoys spending his free time exploring the outdoors and is an avid sports fan. Bob is also a dedicated family man who values spending time with his loved ones. He is a team player and is always willing to lend a helping hand to his colleagues. Bob's positive attitude and strong work ethic make him an asset to any team.");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("70282896-a9a6-4a02-8963-d432ce9d744f"),
                column: "Bio",
                value: "Jane is a woman of many talents, but most importantly, she has a great sense of humor. She's been known to turn a boring meeting into a comedy show and to make even the grimmest Monday morning bearable with her quick wit. When she's not cracking jokes, you can find her whipping up a storm in the kitchen, binge-watching her favorite shows, or planning her next adventure. Just don't ask her to pick a favorite ice cream flavor, she'll be there for hours.");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("72751074-d753-4e58-9c78-89e764cbdce4"),
                column: "Bio",
                value: "Tom is a businessman who always has his schedule planned out months in advance, but that doesn't mean he doesn't know how to have fun. When he's not closing deals, you can find him hitting the dance floor, trying new cocktails or planning his next vacation, where he'll probably plan his schedule for the next year. Just don't ask him to be spontaneous, it's not in his schedule.");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("7afcbc1c-2c98-4b17-be34-3d30c2ff646c"),
                column: "Bio",
                value: "Tom is a businessman who always has his schedule planned out months in advance, but that doesn't mean he doesn't know how to have fun. When he's not closing deals, you can find him hitting the dance floor, trying new cocktails or planning his next vacation, where he'll probably plan his schedule for the next year. Just don't ask him to be spontaneous, it's not in his schedule.");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("8bd114c1-cf96-430a-9624-cb9df7b3b8d4"),
                column: "Bio",
                value: "Bob is a hardworking individual with a passion for learning new things. He enjoys spending his free time exploring the outdoors and is an avid sports fan. Bob is also a dedicated family man who values spending time with his loved ones. He is a team player and is always willing to lend a helping hand to his colleagues. Bob's positive attitude and strong work ethic make him an asset to any team.");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("8d7c889c-8efd-4777-abd0-3abad89c40c2"),
                column: "Bio",
                value: "Bob is a hardworking individual with a passion for learning new things. He enjoys spending his free time exploring the outdoors and is an avid sports fan. Bob is also a dedicated family man who values spending time with his loved ones. He is a team player and is always willing to lend a helping hand to his colleagues. Bob's positive attitude and strong work ethic make him an asset to any team.");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("9db3248d-5d20-4474-b634-63b1d8cb97d8"),
                column: "Bio",
                value: "Tom is a businessman who always has his schedule planned out months in advance, but that doesn't mean he doesn't know how to have fun. When he's not closing deals, you can find him hitting the dance floor, trying new cocktails or planning his next vacation, where he'll probably plan his schedule for the next year. Just don't ask him to be spontaneous, it's not in his schedule.");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("bee9b166-1f71-46e2-86aa-1f4bdb9932c0"),
                column: "Bio",
                value: "Tom is a businessman who always has his schedule planned out months in advance, but that doesn't mean he doesn't know how to have fun. When he's not closing deals, you can find him hitting the dance floor, trying new cocktails or planning his next vacation, where he'll probably plan his schedule for the next year. Just don't ask him to be spontaneous, it's not in his schedule.");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("d1760bb5-b9e8-4dea-9550-7c59084b3874"),
                column: "Bio",
                value: "Jane is a woman of many talents, but most importantly, she has a great sense of humor. She's been known to turn a boring meeting into a comedy show and to make even the grimmest Monday morning bearable with her quick wit. When she's not cracking jokes, you can find her whipping up a storm in the kitchen, binge-watching her favorite shows, or planning her next adventure. Just don't ask her to pick a favorite ice cream flavor, she'll be there for hours.");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("f6d49e42-19bf-419c-a675-f4fd0d1885bc"),
                column: "Bio",
                value: "Tom is a businessman who always has his schedule planned out months in advance, but that doesn't mean he doesn't know how to have fun. When he's not closing deals, you can find him hitting the dance floor, trying new cocktails or planning his next vacation, where he'll probably plan his schedule for the next year. Just don't ask him to be spontaneous, it's not in his schedule.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0708d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2022, 12, 16, 19, 47, 5, 525, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0768d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 8, 16, 19, 47, 5, 525, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2e-8003-43c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 7, 16, 19, 47, 5, 525, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-42a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 5, 16, 19, 47, 5, 525, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76a7d5dde"),
                column: "Date",
                value: new DateTime(2023, 2, 16, 19, 47, 5, 525, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76b7c5dde"),
                column: "Date",
                value: new DateTime(2022, 11, 16, 19, 47, 5, 525, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92e4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 9, 16, 19, 47, 5, 525, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c5-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 3, 16, 19, 47, 5, 525, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c7-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 4, 16, 19, 47, 5, 525, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-46c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 6, 16, 19, 47, 5, 525, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("107a0dcf-03ca-4478-be12-e22a83cfde70"),
                column: "Bio",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("13665690-c91a-4382-8615-863dc196a256"),
                column: "Bio",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("3601016a-6613-42ac-8713-0aa4153c90b8"),
                column: "Bio",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("3f843a09-85f5-4658-b36c-2da9b463d0d3"),
                column: "Bio",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("41232c7a-1714-4025-bd01-2de96444c18f"),
                column: "Bio",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("41fddd3c-8811-4048-aa99-de65e85053b5"),
                column: "Bio",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("53f666e7-f71c-4db7-b42f-0b7ec5550c1a"),
                column: "Bio",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("553a08fd-b8f6-4268-885d-68108a9c29d8"),
                column: "Bio",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("5c757487-a4d5-4207-b9b6-4641cde9737a"),
                column: "Bio",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("70282896-a9a6-4a02-8963-d432ce9d744f"),
                column: "Bio",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("72751074-d753-4e58-9c78-89e764cbdce4"),
                column: "Bio",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("7afcbc1c-2c98-4b17-be34-3d30c2ff646c"),
                column: "Bio",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("8bd114c1-cf96-430a-9624-cb9df7b3b8d4"),
                column: "Bio",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("8d7c889c-8efd-4777-abd0-3abad89c40c2"),
                column: "Bio",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("9db3248d-5d20-4474-b634-63b1d8cb97d8"),
                column: "Bio",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("bee9b166-1f71-46e2-86aa-1f4bdb9932c0"),
                column: "Bio",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("d1760bb5-b9e8-4dea-9550-7c59084b3874"),
                column: "Bio",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("f6d49e42-19bf-419c-a675-f4fd0d1885bc"),
                column: "Bio",
                value: null);
        }
    }
}

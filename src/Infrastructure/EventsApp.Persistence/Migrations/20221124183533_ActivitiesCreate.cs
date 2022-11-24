using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventsApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ActivitiesCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[,]
                {
                    { new Guid("b0708d2f-8003-43c1-92a4-edc76a7c5dde"), "culture", "Paris", new DateTime(2022, 10, 24, 19, 35, 33, 371, DateTimeKind.Local).AddTicks(2959), "Activity 1 month ago", "Past Activity 2", "Louvre" },
                    { new Guid("b0768d2f-8003-43c1-92a4-edc76a7c5dde"), "travel", "London", new DateTime(2023, 6, 24, 19, 35, 33, 371, DateTimeKind.Local).AddTicks(3048), "Activity 2 months ago", "Future Activity 7", "Somewhere on the Thames" },
                    { new Guid("b0788d2e-8003-43c1-92a4-edc76a7c5dde"), "music", "London", new DateTime(2023, 5, 24, 19, 35, 33, 371, DateTimeKind.Local).AddTicks(3036), "Activity 6 months in future", "Future Activity 6", "Roundhouse Camden" },
                    { new Guid("b0788d2f-8003-43c1-42a4-edc76a7c5dde"), "drinks", "London", new DateTime(2023, 3, 24, 19, 35, 33, 371, DateTimeKind.Local).AddTicks(3013), "Activity 4 months in future", "Future Activity 4", "Yet another pub" },
                    { new Guid("b0788d2f-8003-43c1-92a4-edc76a7d5dde"), "culture", "London", new DateTime(2022, 12, 24, 19, 35, 33, 371, DateTimeKind.Local).AddTicks(2974), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" },
                    { new Guid("b0788d2f-8003-43c1-92a4-edc76b7c5dde"), "drinks", "London", new DateTime(2022, 9, 24, 19, 35, 33, 371, DateTimeKind.Local).AddTicks(2882), "Activity 2 months ago", "Past Activity 1", "Pub" },
                    { new Guid("b0788d2f-8003-43c1-92e4-edc76a7c5dde"), "film", "London", new DateTime(2023, 7, 24, 19, 35, 33, 371, DateTimeKind.Local).AddTicks(3094), "Activity 8 months in future", "Future Activity 8", "Cinema" },
                    { new Guid("b0788d2f-8003-43c5-92a4-edc76a7c5dde"), "music", "London", new DateTime(2023, 1, 24, 19, 35, 33, 371, DateTimeKind.Local).AddTicks(2986), "Activity 2 months in future", "Future Activity 2", "O2 Arena" },
                    { new Guid("b0788d2f-8003-43c7-92a4-edc76a7c5dde"), "drinks", "London", new DateTime(2023, 2, 24, 19, 35, 33, 371, DateTimeKind.Local).AddTicks(2998), "Activity 3 months in future", "Future Activity 3", "Another pub" },
                    { new Guid("b0788d2f-8003-46c1-92a4-edc76a7c5dde"), "drinks", "London", new DateTime(2023, 4, 24, 19, 35, 33, 371, DateTimeKind.Local).AddTicks(3025), "Activity 5 months in future", "Future Activity 5", "Just another pub" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0708d2f-8003-43c1-92a4-edc76a7c5dde"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0768d2f-8003-43c1-92a4-edc76a7c5dde"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2e-8003-43c1-92a4-edc76a7c5dde"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-42a4-edc76a7c5dde"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76a7d5dde"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76b7c5dde"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92e4-edc76a7c5dde"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c5-92a4-edc76a7c5dde"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c7-92a4-edc76a7c5dde"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-46c1-92a4-edc76a7c5dde"));
        }
    }
}

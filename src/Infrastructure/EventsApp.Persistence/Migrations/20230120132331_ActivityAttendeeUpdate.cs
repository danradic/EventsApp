using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventsApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ActivityAttendeeUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0708d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2022, 12, 20, 14, 23, 30, 920, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0768d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 8, 20, 14, 23, 30, 920, DateTimeKind.Local).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2e-8003-43c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 7, 20, 14, 23, 30, 920, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-42a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 5, 20, 14, 23, 30, 920, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76a7d5dde"),
                column: "Date",
                value: new DateTime(2023, 2, 20, 14, 23, 30, 920, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76b7c5dde"),
                column: "Date",
                value: new DateTime(2022, 11, 20, 14, 23, 30, 920, DateTimeKind.Local).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92e4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 9, 20, 14, 23, 30, 920, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c5-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 3, 20, 14, 23, 30, 920, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c7-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 4, 20, 14, 23, 30, 920, DateTimeKind.Local).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-46c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 6, 20, 14, 23, 30, 920, DateTimeKind.Local).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("16c4764a-a85c-4d31-98e7-b22a83915cff"),
                column: "Image",
                value: "https://res.cloudinary.com/dialkfwlz/image/upload/v1674220245/dfeyqwume4of1fzeibj5.jpg");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("23183bdc-a1db-45db-824f-179cf8a8c331"),
                column: "Image",
                value: "https://res.cloudinary.com/dialkfwlz/image/upload/v1674220306/spkaxptndbgr6wvrk9dh.jpg");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("30156295-b85c-429f-8924-f019a37db3d3"),
                column: "Image",
                value: "https://res.cloudinary.com/dialkfwlz/image/upload/v1674220245/dfeyqwume4of1fzeibj5.jpg");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("38b42910-ed98-424e-97ce-2887ae1ef97d"),
                column: "Image",
                value: "https://res.cloudinary.com/dialkfwlz/image/upload/v1674220306/spkaxptndbgr6wvrk9dh.jpg");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("3ab3d0ca-bb82-4c17-ae50-2e5d782e05fd"),
                column: "Image",
                value: "https://res.cloudinary.com/dialkfwlz/image/upload/v1674220306/spkaxptndbgr6wvrk9dh.jpg");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("4ebe321f-f48b-4574-9098-1453fdde0331"),
                column: "Image",
                value: "https://res.cloudinary.com/dialkfwlz/image/upload/v1674160787/urvj1ohuxr9xukihu6c9.jpg");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("525b8837-3935-4900-8aab-09f5dce68b4a"),
                column: "Image",
                value: "https://res.cloudinary.com/dialkfwlz/image/upload/v1674220306/spkaxptndbgr6wvrk9dh.jpg");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("6137ddf4-523f-4392-a9cd-d947ac6cdf5a"),
                column: "Image",
                value: "https://res.cloudinary.com/dialkfwlz/image/upload/v1674160787/urvj1ohuxr9xukihu6c9.jpg");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("7f876625-4407-4439-916a-203bb144e5a3"),
                column: "Image",
                value: "https://res.cloudinary.com/dialkfwlz/image/upload/v1674160787/urvj1ohuxr9xukihu6c9.jpg");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("87a262c6-c597-4c2d-97fe-732a2737e406"),
                column: "Image",
                value: "https://res.cloudinary.com/dialkfwlz/image/upload/v1674160787/urvj1ohuxr9xukihu6c9.jpg");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("90c71ad5-cc49-4b3a-bf58-28c7e776d61f"),
                column: "Image",
                value: "https://res.cloudinary.com/dialkfwlz/image/upload/v1674220245/dfeyqwume4of1fzeibj5.jpg");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("b9d2ed76-e6c1-4d56-80e4-95e055f02f49"),
                column: "Image",
                value: "https://res.cloudinary.com/dialkfwlz/image/upload/v1674220306/spkaxptndbgr6wvrk9dh.jpg");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("bdc6adab-a35a-4a3a-bc4b-63482e724f99"),
                column: "Image",
                value: "https://res.cloudinary.com/dialkfwlz/image/upload/v1674220245/dfeyqwume4of1fzeibj5.jpg");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("c5b2be3b-627e-47cd-b893-18de572aaa71"),
                column: "Image",
                value: "https://res.cloudinary.com/dialkfwlz/image/upload/v1674220245/dfeyqwume4of1fzeibj5.jpg");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("d0d1684b-861d-4700-adf1-ec457b50d7e6"),
                column: "Image",
                value: "https://res.cloudinary.com/dialkfwlz/image/upload/v1674160787/urvj1ohuxr9xukihu6c9.jpg");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("ee8f3cfc-2ee1-40a0-824e-30c89a6fde6c"),
                column: "Image",
                value: "https://res.cloudinary.com/dialkfwlz/image/upload/v1674220245/dfeyqwume4of1fzeibj5.jpg");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("f185ce01-3ba6-455a-b5c7-3dcb7b08fcad"),
                column: "Image",
                value: "https://res.cloudinary.com/dialkfwlz/image/upload/v1674160787/urvj1ohuxr9xukihu6c9.jpg");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("fa64ad37-8e1b-4fc5-9ee3-ad69c8cdf798"),
                column: "Image",
                value: "https://res.cloudinary.com/dialkfwlz/image/upload/v1674160787/urvj1ohuxr9xukihu6c9.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("16c4764a-a85c-4d31-98e7-b22a83915cff"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("23183bdc-a1db-45db-824f-179cf8a8c331"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("30156295-b85c-429f-8924-f019a37db3d3"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("38b42910-ed98-424e-97ce-2887ae1ef97d"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("3ab3d0ca-bb82-4c17-ae50-2e5d782e05fd"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("4ebe321f-f48b-4574-9098-1453fdde0331"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("525b8837-3935-4900-8aab-09f5dce68b4a"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("6137ddf4-523f-4392-a9cd-d947ac6cdf5a"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("7f876625-4407-4439-916a-203bb144e5a3"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("87a262c6-c597-4c2d-97fe-732a2737e406"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("90c71ad5-cc49-4b3a-bf58-28c7e776d61f"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("b9d2ed76-e6c1-4d56-80e4-95e055f02f49"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("bdc6adab-a35a-4a3a-bc4b-63482e724f99"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("c5b2be3b-627e-47cd-b893-18de572aaa71"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("d0d1684b-861d-4700-adf1-ec457b50d7e6"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("ee8f3cfc-2ee1-40a0-824e-30c89a6fde6c"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("f185ce01-3ba6-455a-b5c7-3dcb7b08fcad"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("fa64ad37-8e1b-4fc5-9ee3-ad69c8cdf798"),
                column: "Image",
                value: null);
        }
    }
}

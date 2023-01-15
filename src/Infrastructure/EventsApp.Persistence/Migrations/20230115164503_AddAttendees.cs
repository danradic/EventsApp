using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventsApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddAttendees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0708d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2022, 12, 15, 17, 45, 3, 292, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0768d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 8, 15, 17, 45, 3, 292, DateTimeKind.Local).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2e-8003-43c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 7, 15, 17, 45, 3, 292, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-42a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 5, 15, 17, 45, 3, 292, DateTimeKind.Local).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76a7d5dde"),
                column: "Date",
                value: new DateTime(2023, 2, 15, 17, 45, 3, 292, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76b7c5dde"),
                column: "Date",
                value: new DateTime(2022, 11, 15, 17, 45, 3, 292, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92e4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 9, 15, 17, 45, 3, 292, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c5-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 3, 15, 17, 45, 3, 292, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c7-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 4, 15, 17, 45, 3, 292, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-46c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 6, 15, 17, 45, 3, 292, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.InsertData(
                table: "ActivityAttendees",
                columns: new[] { "ActivityAttendeeId", "ActivityId", "Bio", "DisplayName", "Email", "Image", "IsHost", "UserId", "UserName" },
                values: new object[,]
                {
                    { new Guid("107a0dcf-03ca-4478-be12-e22a83cfde70"), new Guid("b0788d2f-8003-46c1-92a4-edc76a7c5dde"), null, null, "bob@test.com", null, true, "940a1b37-3131-49b7-beb9-f37be7e2b536", "bob" },
                    { new Guid("13665690-c91a-4382-8615-863dc196a256"), new Guid("b0788d2f-8003-43c7-92a4-edc76a7c5dde"), null, null, "bob@test.com", null, false, "940a1b37-3131-49b7-beb9-f37be7e2b536", "bob" },
                    { new Guid("3601016a-6613-42ac-8713-0aa4153c90b8"), new Guid("b0788d2e-8003-43c1-92a4-edc76a7c5dde"), null, null, "jane@test.com", null, false, "95036e9b-23d2-4f20-968b-85d5098d46d6", "jane" },
                    { new Guid("3f843a09-85f5-4658-b36c-2da9b463d0d3"), new Guid("b0788d2f-8003-43c1-92e4-edc76a7c5dde"), null, null, "jane@test.com", null, false, "95036e9b-23d2-4f20-968b-85d5098d46d6", "jane" },
                    { new Guid("41232c7a-1714-4025-bd01-2de96444c18f"), new Guid("b0788d2f-8003-43c1-92a4-edc76a7d5dde"), null, null, "jane@test.com", null, false, "95036e9b-23d2-4f20-968b-85d5098d46d6", "jane" },
                    { new Guid("41fddd3c-8811-4048-aa99-de65e85053b5"), new Guid("b0788d2f-8003-43c5-92a4-edc76a7c5dde"), null, null, "bob@test.com", null, true, "940a1b37-3131-49b7-beb9-f37be7e2b536", "bob" },
                    { new Guid("53f666e7-f71c-4db7-b42f-0b7ec5550c1a"), new Guid("b0788d2f-8003-46c1-92a4-edc76a7c5dde"), null, null, "jane@test.com", null, false, "95036e9b-23d2-4f20-968b-85d5098d46d6", "jane" },
                    { new Guid("553a08fd-b8f6-4268-885d-68108a9c29d8"), new Guid("b0708d2f-8003-43c1-92a4-edc76a7c5dde"), null, null, "jane@test.com", null, false, "95036e9b-23d2-4f20-968b-85d5098d46d6", "jane" },
                    { new Guid("582ce36c-77a7-4689-9b78-e2419e78316b"), new Guid("b0788d2f-8003-43c1-92a4-edc76a7d5dde"), null, null, "jane@test.com", null, false, "95036e9b-23d2-4f20-968b-85d5098d46d6", "jane" },
                    { new Guid("5c757487-a4d5-4207-b9b6-4641cde9737a"), new Guid("b0708d2f-8003-43c1-92a4-edc76a7c5dde"), null, null, "bob@test.com", null, true, "940a1b37-3131-49b7-beb9-f37be7e2b536", "bob" },
                    { new Guid("70282896-a9a6-4a02-8963-d432ce9d744f"), new Guid("b0788d2f-8003-43c1-42a4-edc76a7c5dde"), null, null, "jane@test.com", null, true, "95036e9b-23d2-4f20-968b-85d5098d46d6", "jane" },
                    { new Guid("72751074-d753-4e58-9c78-89e764cbdce4"), new Guid("b0768d2f-8003-43c1-92a4-edc76a7c5dde"), null, null, "tom@test.com", null, false, "868bfa6f-2f65-4a89-8f24-7f0d4d897a0f", "tom" },
                    { new Guid("7afcbc1c-2c98-4b17-be34-3d30c2ff646c"), new Guid("b0788d2f-8003-43c1-92e4-edc76a7c5dde"), null, null, "tom@test.com", null, true, "868bfa6f-2f65-4a89-8f24-7f0d4d897a0f", "tom" },
                    { new Guid("8bd114c1-cf96-430a-9624-cb9df7b3b8d4"), new Guid("b0788d2f-8003-43c1-92a4-edc76b7c5dde"), null, null, "bob@test.com", null, true, "940a1b37-3131-49b7-beb9-f37be7e2b536", "bob" },
                    { new Guid("8d7c889c-8efd-4777-abd0-3abad89c40c2"), new Guid("b0768d2f-8003-43c1-92a4-edc76a7c5dde"), null, null, "bob@test.com", null, true, "940a1b37-3131-49b7-beb9-f37be7e2b536", "bob" },
                    { new Guid("9db3248d-5d20-4474-b634-63b1d8cb97d8"), new Guid("b0788d2f-8003-43c1-92a4-edc76a7d5dde"), null, null, "tom@test.com", null, true, "868bfa6f-2f65-4a89-8f24-7f0d4d897a0f", "tom" },
                    { new Guid("bee9b166-1f71-46e2-86aa-1f4bdb9932c0"), new Guid("b0788d2f-8003-43c5-92a4-edc76a7c5dde"), null, null, "tom@test.com", null, false, "868bfa6f-2f65-4a89-8f24-7f0d4d897a0f", "tom" },
                    { new Guid("c0f0642b-f235-4c65-8ca6-7fdde6a7518c"), new Guid("b0788d2f-8003-43c1-92a4-edc76a7d5dde"), null, null, "tom@test.com", null, true, "868bfa6f-2f65-4a89-8f24-7f0d4d897a0f", "tom" },
                    { new Guid("d1760bb5-b9e8-4dea-9550-7c59084b3874"), new Guid("b0788d2f-8003-43c7-92a4-edc76a7c5dde"), null, null, "jane@test.com", null, true, "95036e9b-23d2-4f20-968b-85d5098d46d6", "jane" },
                    { new Guid("f6d49e42-19bf-419c-a675-f4fd0d1885bc"), new Guid("b0788d2e-8003-43c1-92a4-edc76a7c5dde"), null, null, "tom@test.com", null, true, "868bfa6f-2f65-4a89-8f24-7f0d4d897a0f", "tom" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("582ce36c-77a7-4689-9b78-e2419e78316b"));

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
                keyValue: new Guid("c0f0642b-f235-4c65-8ca6-7fdde6a7518c"));

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
                value: new DateTime(2022, 12, 14, 16, 34, 16, 834, DateTimeKind.Local).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0768d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 8, 14, 16, 34, 16, 834, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2e-8003-43c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 7, 14, 16, 34, 16, 834, DateTimeKind.Local).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-42a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 5, 14, 16, 34, 16, 834, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76a7d5dde"),
                column: "Date",
                value: new DateTime(2023, 2, 14, 16, 34, 16, 834, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76b7c5dde"),
                column: "Date",
                value: new DateTime(2022, 11, 14, 16, 34, 16, 834, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92e4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 9, 14, 16, 34, 16, 834, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c5-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 3, 14, 16, 34, 16, 834, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c7-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 4, 14, 16, 34, 16, 834, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-46c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 6, 14, 16, 34, 16, 834, DateTimeKind.Local).AddTicks(4137));
        }
    }
}

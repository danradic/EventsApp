using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventsApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedAttendees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("582ce36c-77a7-4689-9b78-e2419e78316b"));

            migrationBuilder.DeleteData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("c0f0642b-f235-4c65-8ca6-7fdde6a7518c"));

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
                column: "DisplayName",
                value: "Bob");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("13665690-c91a-4382-8615-863dc196a256"),
                column: "DisplayName",
                value: "Bob");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("3601016a-6613-42ac-8713-0aa4153c90b8"),
                column: "DisplayName",
                value: "Jane");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("3f843a09-85f5-4658-b36c-2da9b463d0d3"),
                column: "DisplayName",
                value: "Jane");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("41232c7a-1714-4025-bd01-2de96444c18f"),
                column: "DisplayName",
                value: "Jane");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("41fddd3c-8811-4048-aa99-de65e85053b5"),
                column: "DisplayName",
                value: "Bob");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("53f666e7-f71c-4db7-b42f-0b7ec5550c1a"),
                column: "DisplayName",
                value: "Jane");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("553a08fd-b8f6-4268-885d-68108a9c29d8"),
                column: "DisplayName",
                value: "Jane");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("5c757487-a4d5-4207-b9b6-4641cde9737a"),
                column: "DisplayName",
                value: "Bob");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("70282896-a9a6-4a02-8963-d432ce9d744f"),
                column: "DisplayName",
                value: "Jane");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("72751074-d753-4e58-9c78-89e764cbdce4"),
                column: "DisplayName",
                value: "Tom");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("7afcbc1c-2c98-4b17-be34-3d30c2ff646c"),
                column: "DisplayName",
                value: "Tom");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("8bd114c1-cf96-430a-9624-cb9df7b3b8d4"),
                column: "DisplayName",
                value: "Bob");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("8d7c889c-8efd-4777-abd0-3abad89c40c2"),
                column: "DisplayName",
                value: "Bob");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("9db3248d-5d20-4474-b634-63b1d8cb97d8"),
                column: "DisplayName",
                value: "Tom");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("bee9b166-1f71-46e2-86aa-1f4bdb9932c0"),
                column: "DisplayName",
                value: "Tom");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("d1760bb5-b9e8-4dea-9550-7c59084b3874"),
                column: "DisplayName",
                value: "Jane");

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("f6d49e42-19bf-419c-a675-f4fd0d1885bc"),
                column: "DisplayName",
                value: "Tom");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("107a0dcf-03ca-4478-be12-e22a83cfde70"),
                column: "DisplayName",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("13665690-c91a-4382-8615-863dc196a256"),
                column: "DisplayName",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("3601016a-6613-42ac-8713-0aa4153c90b8"),
                column: "DisplayName",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("3f843a09-85f5-4658-b36c-2da9b463d0d3"),
                column: "DisplayName",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("41232c7a-1714-4025-bd01-2de96444c18f"),
                column: "DisplayName",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("41fddd3c-8811-4048-aa99-de65e85053b5"),
                column: "DisplayName",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("53f666e7-f71c-4db7-b42f-0b7ec5550c1a"),
                column: "DisplayName",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("553a08fd-b8f6-4268-885d-68108a9c29d8"),
                column: "DisplayName",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("5c757487-a4d5-4207-b9b6-4641cde9737a"),
                column: "DisplayName",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("70282896-a9a6-4a02-8963-d432ce9d744f"),
                column: "DisplayName",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("72751074-d753-4e58-9c78-89e764cbdce4"),
                column: "DisplayName",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("7afcbc1c-2c98-4b17-be34-3d30c2ff646c"),
                column: "DisplayName",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("8bd114c1-cf96-430a-9624-cb9df7b3b8d4"),
                column: "DisplayName",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("8d7c889c-8efd-4777-abd0-3abad89c40c2"),
                column: "DisplayName",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("9db3248d-5d20-4474-b634-63b1d8cb97d8"),
                column: "DisplayName",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("bee9b166-1f71-46e2-86aa-1f4bdb9932c0"),
                column: "DisplayName",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("d1760bb5-b9e8-4dea-9550-7c59084b3874"),
                column: "DisplayName",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityAttendees",
                keyColumn: "ActivityAttendeeId",
                keyValue: new Guid("f6d49e42-19bf-419c-a675-f4fd0d1885bc"),
                column: "DisplayName",
                value: null);

            migrationBuilder.InsertData(
                table: "ActivityAttendees",
                columns: new[] { "ActivityAttendeeId", "ActivityId", "Bio", "DisplayName", "Email", "Image", "IsHost", "UserId", "UserName" },
                values: new object[,]
                {
                    { new Guid("582ce36c-77a7-4689-9b78-e2419e78316b"), new Guid("b0788d2f-8003-43c1-92a4-edc76a7d5dde"), null, null, "jane@test.com", null, false, "95036e9b-23d2-4f20-968b-85d5098d46d6", "jane" },
                    { new Guid("c0f0642b-f235-4c65-8ca6-7fdde6a7518c"), new Guid("b0788d2f-8003-43c1-92a4-edc76a7d5dde"), null, null, "tom@test.com", null, true, "868bfa6f-2f65-4a89-8f24-7f0d4d897a0f", "tom" }
                });
        }
    }
}

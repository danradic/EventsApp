using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventsApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddCancelledProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCancelled",
                table: "Activities",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0708d2f-8003-43c1-92a4-edc76a7c5dde"),
                columns: new[] { "Date", "IsCancelled" },
                values: new object[] { new DateTime(2022, 12, 14, 16, 34, 16, 834, DateTimeKind.Local).AddTicks(4057), false });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0768d2f-8003-43c1-92a4-edc76a7c5dde"),
                columns: new[] { "Date", "IsCancelled" },
                values: new object[] { new DateTime(2023, 8, 14, 16, 34, 16, 834, DateTimeKind.Local).AddTicks(4167), false });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2e-8003-43c1-92a4-edc76a7c5dde"),
                columns: new[] { "Date", "IsCancelled" },
                values: new object[] { new DateTime(2023, 7, 14, 16, 34, 16, 834, DateTimeKind.Local).AddTicks(4152), false });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-42a4-edc76a7c5dde"),
                columns: new[] { "Date", "IsCancelled" },
                values: new object[] { new DateTime(2023, 5, 14, 16, 34, 16, 834, DateTimeKind.Local).AddTicks(4123), false });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76a7d5dde"),
                columns: new[] { "Date", "IsCancelled" },
                values: new object[] { new DateTime(2023, 2, 14, 16, 34, 16, 834, DateTimeKind.Local).AddTicks(4076), false });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76b7c5dde"),
                columns: new[] { "Date", "IsCancelled" },
                values: new object[] { new DateTime(2022, 11, 14, 16, 34, 16, 834, DateTimeKind.Local).AddTicks(3951), false });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92e4-edc76a7c5dde"),
                columns: new[] { "Date", "IsCancelled" },
                values: new object[] { new DateTime(2023, 9, 14, 16, 34, 16, 834, DateTimeKind.Local).AddTicks(4278), false });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c5-92a4-edc76a7c5dde"),
                columns: new[] { "Date", "IsCancelled" },
                values: new object[] { new DateTime(2023, 3, 14, 16, 34, 16, 834, DateTimeKind.Local).AddTicks(4091), false });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c7-92a4-edc76a7c5dde"),
                columns: new[] { "Date", "IsCancelled" },
                values: new object[] { new DateTime(2023, 4, 14, 16, 34, 16, 834, DateTimeKind.Local).AddTicks(4106), false });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-46c1-92a4-edc76a7c5dde"),
                columns: new[] { "Date", "IsCancelled" },
                values: new object[] { new DateTime(2023, 6, 14, 16, 34, 16, 834, DateTimeKind.Local).AddTicks(4137), false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCancelled",
                table: "Activities");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0708d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2022, 12, 12, 19, 26, 10, 57, DateTimeKind.Local).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0768d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 8, 12, 19, 26, 10, 57, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2e-8003-43c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 7, 12, 19, 26, 10, 57, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-42a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 5, 12, 19, 26, 10, 57, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76a7d5dde"),
                column: "Date",
                value: new DateTime(2023, 2, 12, 19, 26, 10, 57, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76b7c5dde"),
                column: "Date",
                value: new DateTime(2022, 11, 12, 19, 26, 10, 57, DateTimeKind.Local).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92e4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 9, 12, 19, 26, 10, 57, DateTimeKind.Local).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c5-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 3, 12, 19, 26, 10, 57, DateTimeKind.Local).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c7-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 4, 12, 19, 26, 10, 57, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-46c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 6, 12, 19, 26, 10, 57, DateTimeKind.Local).AddTicks(456));
        }
    }
}

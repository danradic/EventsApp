using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventsApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class PhotoEntityAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsMain = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photos_ApplicationUserId",
                table: "Photos",
                column: "ApplicationUserId"
            );

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0708d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2022, 12, 17, 20, 8, 56, 999, DateTimeKind.Local).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0768d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 8, 17, 20, 8, 56, 999, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2e-8003-43c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 7, 17, 20, 8, 56, 999, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-42a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 5, 17, 20, 8, 56, 999, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76a7d5dde"),
                column: "Date",
                value: new DateTime(2023, 2, 17, 20, 8, 56, 999, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76b7c5dde"),
                column: "Date",
                value: new DateTime(2022, 11, 17, 20, 8, 56, 999, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92e4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 9, 17, 20, 8, 56, 999, DateTimeKind.Local).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c5-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 3, 17, 20, 8, 56, 999, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c7-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 4, 17, 20, 8, 56, 999, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-46c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 6, 17, 20, 8, 56, 999, DateTimeKind.Local).AddTicks(5120));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");

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
        }
    }
}

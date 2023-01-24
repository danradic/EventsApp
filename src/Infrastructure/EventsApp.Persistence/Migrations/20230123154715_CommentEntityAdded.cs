using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventsApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CommentEntityAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActivityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0708d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2022, 12, 23, 16, 47, 14, 817, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0768d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 8, 23, 16, 47, 14, 817, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2e-8003-43c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 7, 23, 16, 47, 14, 817, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-42a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 5, 23, 16, 47, 14, 817, DateTimeKind.Local).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76a7d5dde"),
                column: "Date",
                value: new DateTime(2023, 2, 23, 16, 47, 14, 817, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76b7c5dde"),
                column: "Date",
                value: new DateTime(2022, 11, 23, 16, 47, 14, 817, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c1-92e4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 9, 23, 16, 47, 14, 817, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c5-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 3, 23, 16, 47, 14, 817, DateTimeKind.Local).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-43c7-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 4, 23, 16, 47, 14, 817, DateTimeKind.Local).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b0788d2f-8003-46c1-92a4-edc76a7c5dde"),
                column: "Date",
                value: new DateTime(2023, 6, 23, 16, 47, 14, 817, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ActivityId",
                table: "Comments",
                column: "ActivityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

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
        }
    }
}

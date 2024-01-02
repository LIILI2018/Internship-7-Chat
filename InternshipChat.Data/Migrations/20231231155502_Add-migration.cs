using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternshipChat.Data.Migrations
{
    /// <inheritdoc />
    public partial class Addmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Messages",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 12, 31, 16, 55, 2, 426, DateTimeKind.Local).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 12, 31, 16, 55, 2, 426, DateTimeKind.Local).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 12, 31, 16, 55, 2, 426, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 12, 31, 16, 55, 2, 426, DateTimeKind.Local).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 12, 31, 16, 55, 2, 426, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2023, 12, 31, 16, 55, 2, 426, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2023, 12, 31, 16, 55, 2, 426, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2023, 12, 31, 16, 55, 2, 426, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2023, 12, 31, 16, 55, 2, 426, DateTimeKind.Local).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2023, 12, 31, 16, 55, 2, 426, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 12, 31, 16, 55, 2, 426, DateTimeKind.Local).AddTicks(1539));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "Messages");
        }
    }
}

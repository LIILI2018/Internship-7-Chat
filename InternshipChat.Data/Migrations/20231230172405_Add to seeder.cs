using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternshipChat.Data.Migrations
{
    /// <inheritdoc />
    public partial class Addtoseeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsAdmin", "Name", "Surename" },
                values: new object[] { 13, "aa", true, "Dino", "Dujmović" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);
        }
    }
}

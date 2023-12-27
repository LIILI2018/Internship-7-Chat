using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InternshipChat.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CanalType",
                table: "Canals",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Canals",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Canals",
                columns: new[] { "Id", "CanalType", "Name" },
                values: new object[,]
                {
                    { 1, 0, "Ivan-Toni" },
                    { 2, 1, "Kanal za admine" },
                    { 3, 1, "Kanal za sve" },
                    { 4, 0, "Dino-Zoran" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsAdmin", "Name", "Surename" },
                values: new object[,]
                {
                    { 1, "IvanRaca@gmail.com", true, "Ivan", "Racetin" },
                    { 2, "Muzika@gmail.com", true, "Toni", "Cetinski" },
                    { 3, "Pjesništvo1000@gmail.com", true, "Luko", "Paljetak" },
                    { 4, "RibeSuNajbolje@gmail.com", true, "Mihaela", "Orah" },
                    { 5, "Korona123@gmail.com", false, "Marin", "Zika" },
                    { 6, "BiliPivac@gmail.com", false, "Vojko", "V" },
                    { 7, "Zoran321@gmail.com", false, "Zoran", "Tadija" },
                    { 8, "ZV@gmail.com", false, "Željko", "Veliki" },
                    { 9, "ZM@gmail.com", false, "Željko", "Veliki" },
                    { 10, "VEDROORDEV@gmail.com", false, "Veran", "Brkan" },
                    { 11, "MarioDživo2@gmail.com", false, "Marin", "Getaldić" },
                    { 12, "DinoD.@gmail.com", true, "Dino", "Dujmović" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "CanalId", "Content", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, 3, "Pokemoni", "Dadada", 1 },
                    { 2, 1, "Jabuka je crvena", "1", 1 },
                    { 3, 2, "Lorem ipsum dolor sit amet", "2", 1 },
                    { 4, 2, "kako si", "3", 1 },
                    { 5, 2, "Si akako", "4", 4 },
                    { 6, 2, "A tout le monde", "5", 3 },
                    { 7, 3, "A tout mes amies", "6", 2 },
                    { 8, 3, "Je vus aime ", "7", 5 },
                    { 9, 3, "Megadeath", "8", 3 },
                    { 10, 3, "Sunce siješe bijelom bojom", "9", 6 },
                    { 11, 3, "si kako", "Kako si", 4 }
                });

            migrationBuilder.InsertData(
                table: "UserCanals",
                columns: new[] { "CanalId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 2, 4 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 3, 7 },
                    { 4, 7 },
                    { 3, 8 },
                    { 3, 9 },
                    { 3, 10 },
                    { 3, 11 },
                    { 2, 12 },
                    { 3, 12 },
                    { 4, 12 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UserCanals",
                keyColumns: new[] { "CanalId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "UserCanals",
                keyColumns: new[] { "CanalId", "UserId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "UserCanals",
                keyColumns: new[] { "CanalId", "UserId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "UserCanals",
                keyColumns: new[] { "CanalId", "UserId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "UserCanals",
                keyColumns: new[] { "CanalId", "UserId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "UserCanals",
                keyColumns: new[] { "CanalId", "UserId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "UserCanals",
                keyColumns: new[] { "CanalId", "UserId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "UserCanals",
                keyColumns: new[] { "CanalId", "UserId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "UserCanals",
                keyColumns: new[] { "CanalId", "UserId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "UserCanals",
                keyColumns: new[] { "CanalId", "UserId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "UserCanals",
                keyColumns: new[] { "CanalId", "UserId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "UserCanals",
                keyColumns: new[] { "CanalId", "UserId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "UserCanals",
                keyColumns: new[] { "CanalId", "UserId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "UserCanals",
                keyColumns: new[] { "CanalId", "UserId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "UserCanals",
                keyColumns: new[] { "CanalId", "UserId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "UserCanals",
                keyColumns: new[] { "CanalId", "UserId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "UserCanals",
                keyColumns: new[] { "CanalId", "UserId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "UserCanals",
                keyColumns: new[] { "CanalId", "UserId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "UserCanals",
                keyColumns: new[] { "CanalId", "UserId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "UserCanals",
                keyColumns: new[] { "CanalId", "UserId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "UserCanals",
                keyColumns: new[] { "CanalId", "UserId" },
                keyValues: new object[] { 4, 12 });

            migrationBuilder.DeleteData(
                table: "Canals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Canals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Canals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Canals",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DropColumn(
                name: "CanalType",
                table: "Canals");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Canals");
        }
    }
}

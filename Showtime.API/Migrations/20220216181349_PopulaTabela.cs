using Microsoft.EntityFrameworkCore.Migrations;

namespace Showtime.API.Migrations
{
    public partial class PopulaTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "Channel", "Name", "Number of Seasons", "Parental Rating" },
                values: new object[] { 1, "Netflix", "Squid Game", 1, 18 });

            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "Channel", "Name", "Number of Seasons", "Parental Rating" },
                values: new object[] { 2, "Fox", "Glee", 6, 12 });

            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "Channel", "Name", "Number of Seasons", "Parental Rating" },
                values: new object[] { 3, "AMC", "Breaking Bad", 5, 16 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Showtime.API.Migrations
{
    public partial class PopulateUsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "E-mail", "password", "role", "Name" },
                values: new object[] { 10, "buzz@gmail.com", "infinitybeyond", "admin", "Buzz Lightyear" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "E-mail", "password", "role", "Name" },
                values: new object[] { 11, "selinakyle@gmail.com", "meow1234", "admin", "Catwoman" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "E-mail", "password", "role", "Name" },
                values: new object[] { 12, "wandavision@gmail.com", "sokovia", "admin", "WandaMaximoff" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}

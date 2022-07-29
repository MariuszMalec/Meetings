using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeetingsUsers.WpApi.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "FirstName", "LastName", "PasswordHash", "PhoneNumber" },
                values: new object[] { 1, new DateTime(2022, 7, 29, 19, 19, 14, 262, DateTimeKind.Local).AddTicks(6684), "mm@example.com", "Mariusz", "Malec", "mm13@!", "" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "FirstName", "LastName", "PasswordHash", "PhoneNumber" },
                values: new object[] { 2, new DateTime(2022, 7, 29, 19, 19, 14, 265, DateTimeKind.Local).AddTicks(5621), "bm@example.com", "Barbara", "Malec", "bm01@!", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

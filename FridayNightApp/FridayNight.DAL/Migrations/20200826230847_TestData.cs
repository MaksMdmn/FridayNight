using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FridayNight.DAL.Migrations
{
    public partial class TestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "accounts",
                columns: new[] { "uid", "discriminator", "email", "password", "phone", "first_name", "last_name", "User_music_preferences_uid" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), "User", null, null, null, "test", "test", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "accounts",
                keyColumn: "uid",
                keyValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace FridayNight.DAL.Migrations
{
    public partial class AccountModelFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TalentSeeker_name",
                table: "accounts");

            migrationBuilder.DropColumn(
                name: "TalentSeeker_phone",
                table: "accounts");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "accounts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                table: "accounts");

            migrationBuilder.AddColumn<string>(
                name: "TalentSeeker_name",
                table: "accounts",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TalentSeeker_phone",
                table: "accounts",
                type: "text",
                nullable: true);
        }
    }
}

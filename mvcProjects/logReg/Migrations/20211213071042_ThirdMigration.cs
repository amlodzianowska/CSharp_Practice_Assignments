using Microsoft.EntityFrameworkCore.Migrations;

namespace logReg.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "username",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "firstname",
                table: "Users",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "lastname",
                table: "Users",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "firstname",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "lastname",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "username",
                table: "Users",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "");
        }
    }
}

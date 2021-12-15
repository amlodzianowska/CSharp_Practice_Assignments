using Microsoft.EntityFrameworkCore.Migrations;

namespace manyToMany.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cast_Cast_CastId1",
                table: "Cast");

            migrationBuilder.DropIndex(
                name: "IX_Cast_CastId1",
                table: "Cast");

            migrationBuilder.DropColumn(
                name: "CastId1",
                table: "Cast");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CastId1",
                table: "Cast",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cast_CastId1",
                table: "Cast",
                column: "CastId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Cast_Cast_CastId1",
                table: "Cast",
                column: "CastId1",
                principalTable: "Cast",
                principalColumn: "CastId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

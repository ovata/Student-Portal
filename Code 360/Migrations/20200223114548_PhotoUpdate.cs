using Microsoft.EntityFrameworkCore.Migrations;

namespace Code_360.Migrations
{
    public partial class PhotoUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

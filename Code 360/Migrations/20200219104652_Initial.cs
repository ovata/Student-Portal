using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Code_360.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Nationality = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    MaritalStatus = table.Column<int>(nullable: true),
                    AddmissionType = table.Column<int>(nullable: false),
                    NextOfKinName = table.Column<string>(nullable: false),
                    NextOfKinEmail = table.Column<string>(nullable: false),
                    NextOfKinPhone = table.Column<string>(nullable: false),
                    NextOfKinDocumentUrl = table.Column<string>(nullable: true),
                    BVN = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}

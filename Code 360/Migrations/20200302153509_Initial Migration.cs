using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Code_360.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Batches_BatchId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ProjectName",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectUrl",
                table: "Projects");

            migrationBuilder.AlterColumn<Guid>(
                name: "BatchId",
                table: "Students",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Batches_BatchId",
                table: "Students",
                column: "BatchId",
                principalTable: "Batches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Batches_BatchId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Projects");

            migrationBuilder.AlterColumn<Guid>(
                name: "BatchId",
                table: "Students",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectName",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProjectUrl",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Batches_BatchId",
                table: "Students",
                column: "BatchId",
                principalTable: "Batches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

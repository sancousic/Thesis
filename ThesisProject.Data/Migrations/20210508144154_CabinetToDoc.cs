using Microsoft.EntityFrameworkCore.Migrations;

namespace ThesisProject.Data.Migrations
{
    public partial class CabinetToDoc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CabinetId",
                table: "Doctors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_CabinetId",
                table: "Doctors",
                column: "CabinetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Cabinets_CabinetId",
                table: "Doctors",
                column: "CabinetId",
                principalTable: "Cabinets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Cabinets_CabinetId",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_CabinetId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "CabinetId",
                table: "Doctors");
        }
    }
}

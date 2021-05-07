using Microsoft.EntityFrameworkCore.Migrations;

namespace ThesisProject.Data.Migrations
{
    public partial class Schedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DoctorId",
                table: "Schedules",
                type: "varchar(255)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_DoctorId",
                table: "Schedules",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Doctors_DoctorId",
                table: "Schedules",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Doctors_DoctorId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_DoctorId",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Schedules");
        }
    }
}

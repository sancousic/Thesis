using Microsoft.EntityFrameworkCore.Migrations;

namespace ThesisProject.Data.Migrations
{
    public partial class diagnoseHistoryRef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "status",
                table: "Diagnoses",
                newName: "Status");

            migrationBuilder.AddColumn<string>(
                name: "DoctorId",
                table: "DiagnoseHistories",
                type: "varchar(255)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DiagnoseHistories_DoctorId",
                table: "DiagnoseHistories",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_DiagnoseHistories_Doctors_DoctorId",
                table: "DiagnoseHistories",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiagnoseHistories_Doctors_DoctorId",
                table: "DiagnoseHistories");

            migrationBuilder.DropIndex(
                name: "IX_DiagnoseHistories_DoctorId",
                table: "DiagnoseHistories");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "DiagnoseHistories");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Diagnoses",
                newName: "status");
        }
    }
}

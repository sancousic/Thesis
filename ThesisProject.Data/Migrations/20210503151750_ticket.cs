using Microsoft.EntityFrameworkCore.Migrations;

namespace ThesisProject.Data.Migrations
{
    public partial class ticket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PacientId",
                table: "Tickets",
                type: "varchar(255)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ScheduleId",
                table: "Tickets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_PacientId",
                table: "Tickets",
                column: "PacientId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ScheduleId",
                table: "Tickets",
                column: "ScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Pacients_PacientId",
                table: "Tickets",
                column: "PacientId",
                principalTable: "Pacients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Schedules_ScheduleId",
                table: "Tickets",
                column: "ScheduleId",
                principalTable: "Schedules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Pacients_PacientId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Schedules_ScheduleId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_PacientId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_ScheduleId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "PacientId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "ScheduleId",
                table: "Tickets");
        }
    }
}

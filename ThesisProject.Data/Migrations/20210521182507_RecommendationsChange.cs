using Microsoft.EntityFrameworkCore.Migrations;

namespace ThesisProject.Data.Migrations
{
    public partial class RecommendationsChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reccomendation_Cards_CardId",
                table: "Reccomendation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reccomendation",
                table: "Reccomendation");

            migrationBuilder.RenameTable(
                name: "Reccomendation",
                newName: "Reccomendations");

            migrationBuilder.RenameIndex(
                name: "IX_Reccomendation_CardId",
                table: "Reccomendations",
                newName: "IX_Reccomendations_CardId");

            migrationBuilder.AddColumn<string>(
                name: "DoctorId",
                table: "Reccomendations",
                type: "varchar(255)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reccomendations",
                table: "Reccomendations",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Reccomendations_DoctorId",
                table: "Reccomendations",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reccomendations_Cards_CardId",
                table: "Reccomendations",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reccomendations_Doctors_DoctorId",
                table: "Reccomendations",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reccomendations_Cards_CardId",
                table: "Reccomendations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reccomendations_Doctors_DoctorId",
                table: "Reccomendations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reccomendations",
                table: "Reccomendations");

            migrationBuilder.DropIndex(
                name: "IX_Reccomendations_DoctorId",
                table: "Reccomendations");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Reccomendations");

            migrationBuilder.RenameTable(
                name: "Reccomendations",
                newName: "Reccomendation");

            migrationBuilder.RenameIndex(
                name: "IX_Reccomendations_CardId",
                table: "Reccomendation",
                newName: "IX_Reccomendation_CardId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reccomendation",
                table: "Reccomendation",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reccomendation_Cards_CardId",
                table: "Reccomendation",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

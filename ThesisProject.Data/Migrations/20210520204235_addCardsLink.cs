using Microsoft.EntityFrameworkCore.Migrations;

namespace ThesisProject.Data.Migrations
{
    public partial class addCardsLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CardId",
                table: "Diagnoses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Diagnoses_CardId",
                table: "Diagnoses",
                column: "CardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Diagnoses_Cards_CardId",
                table: "Diagnoses",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diagnoses_Cards_CardId",
                table: "Diagnoses");

            migrationBuilder.DropIndex(
                name: "IX_Diagnoses_CardId",
                table: "Diagnoses");

            migrationBuilder.DropColumn(
                name: "CardId",
                table: "Diagnoses");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace ThesisProject.Data.Migrations
{
    public partial class CardChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pacients_Cards_CardId",
                table: "Pacients");

            migrationBuilder.DropIndex(
                name: "IX_Pacients_CardId",
                table: "Pacients");

            migrationBuilder.DropColumn(
                name: "CardId",
                table: "Pacients");

            migrationBuilder.AddColumn<string>(
                name: "PacientId",
                table: "Cards",
                type: "varchar(255)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cards_PacientId",
                table: "Cards",
                column: "PacientId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Pacients_PacientId",
                table: "Cards",
                column: "PacientId",
                principalTable: "Pacients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Pacients_PacientId",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_PacientId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "PacientId",
                table: "Cards");

            migrationBuilder.AddColumn<int>(
                name: "CardId",
                table: "Pacients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pacients_CardId",
                table: "Pacients",
                column: "CardId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacients_Cards_CardId",
                table: "Pacients",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

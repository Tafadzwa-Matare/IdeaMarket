using Microsoft.EntityFrameworkCore.Migrations;

namespace ideaMarket.Migrations
{
    public partial class addTableRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Investments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdeasIdeaId",
                table: "Investments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Investments_ApplicationUserId",
                table: "Investments",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Investments_IdeasIdeaId",
                table: "Investments",
                column: "IdeasIdeaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Investments_AspNetUsers_ApplicationUserId",
                table: "Investments",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Investments_Ideas_IdeasIdeaId",
                table: "Investments",
                column: "IdeasIdeaId",
                principalTable: "Ideas",
                principalColumn: "IdeaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Investments_AspNetUsers_ApplicationUserId",
                table: "Investments");

            migrationBuilder.DropForeignKey(
                name: "FK_Investments_Ideas_IdeasIdeaId",
                table: "Investments");

            migrationBuilder.DropIndex(
                name: "IX_Investments_ApplicationUserId",
                table: "Investments");

            migrationBuilder.DropIndex(
                name: "IX_Investments_IdeasIdeaId",
                table: "Investments");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Investments");

            migrationBuilder.DropColumn(
                name: "IdeasIdeaId",
                table: "Investments");
        }
    }
}

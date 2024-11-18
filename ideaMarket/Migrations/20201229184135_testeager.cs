using Microsoft.EntityFrameworkCore.Migrations;

namespace ideaMarket.Migrations
{
    public partial class testeager : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Investments",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "IdeaId",
                table: "Investments",
                newName: "IdeaID");

            migrationBuilder.RenameColumn(
                name: "InvestimentId",
                table: "Investments",
                newName: "InvestimentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Investments",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "IdeaID",
                table: "Investments",
                newName: "IdeaId");

            migrationBuilder.RenameColumn(
                name: "InvestimentID",
                table: "Investments",
                newName: "InvestimentId");
        }
    }
}

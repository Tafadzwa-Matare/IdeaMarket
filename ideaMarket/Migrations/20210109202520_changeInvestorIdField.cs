using Microsoft.EntityFrameworkCore.Migrations;

namespace ideaMarket.Migrations
{
    public partial class changeInvestorIdField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Investments");

            migrationBuilder.AddColumn<string>(
                name: "InvestorID",
                table: "Investments",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvestorID",
                table: "Investments");

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Investments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

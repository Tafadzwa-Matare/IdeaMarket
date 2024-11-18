using Microsoft.EntityFrameworkCore.Migrations;

namespace ideaMarket.Migrations
{
    public partial class test5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InvestorEmail",
                table: "Investments",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "InvestorName",
                table: "Investments",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "InvestorSurname",
                table: "Investments",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvestorEmail",
                table: "Investments");

            migrationBuilder.DropColumn(
                name: "InvestorName",
                table: "Investments");

            migrationBuilder.DropColumn(
                name: "InvestorSurname",
                table: "Investments");
        }
    }
}

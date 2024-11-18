using Microsoft.EntityFrameworkCore.Migrations;

namespace ideaMarket.Migrations
{
    public partial class moreIdeaFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactDetails",
                table: "Ideas");

            migrationBuilder.AddColumn<string>(
                name: "CompanyAddress",
                table: "Ideas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CompanyEmail",
                table: "Ideas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IdeaSector",
                table: "Ideas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "JustifyCapital",
                table: "Ideas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MobileNumber",
                table: "Ideas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OtherContactDetails",
                table: "Ideas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TeamSize",
                table: "Ideas",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyAddress",
                table: "Ideas");

            migrationBuilder.DropColumn(
                name: "CompanyEmail",
                table: "Ideas");

            migrationBuilder.DropColumn(
                name: "IdeaSector",
                table: "Ideas");

            migrationBuilder.DropColumn(
                name: "JustifyCapital",
                table: "Ideas");

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "Ideas");

            migrationBuilder.DropColumn(
                name: "OtherContactDetails",
                table: "Ideas");

            migrationBuilder.DropColumn(
                name: "TeamSize",
                table: "Ideas");

            migrationBuilder.AddColumn<string>(
                name: "ContactDetails",
                table: "Ideas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

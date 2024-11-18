using Microsoft.EntityFrameworkCore.Migrations;

namespace ideaMarket.Migrations
{
    public partial class ideaGradefield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ideaGrade",
                table: "Ideas",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ideaGrade",
                table: "Ideas");
        }
    }
}

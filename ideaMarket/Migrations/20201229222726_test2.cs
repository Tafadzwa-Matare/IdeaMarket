using Microsoft.EntityFrameworkCore.Migrations;

namespace ideaMarket.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Investments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Investments_Id",
                table: "Investments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Investments_AspNetUsers_Id",
                table: "Investments",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Investments_AspNetUsers_Id",
                table: "Investments");

            migrationBuilder.DropIndex(
                name: "IX_Investments_Id",
                table: "Investments");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Investments");
        }
    }
}

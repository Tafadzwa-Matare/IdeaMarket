using Microsoft.EntityFrameworkCore.Migrations;

namespace ideaMarket.Migrations
{
    public partial class testeager1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Investments",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Investments_IdeaID",
                table: "Investments",
                column: "IdeaID");

            migrationBuilder.CreateIndex(
                name: "IX_Investments_UserID",
                table: "Investments",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Investments_Ideas_IdeaID",
                table: "Investments",
                column: "IdeaID",
                principalTable: "Ideas",
                principalColumn: "IdeaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Investments_AspNetUsers_UserID",
                table: "Investments",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Investments_Ideas_IdeaID",
                table: "Investments");

            migrationBuilder.DropForeignKey(
                name: "FK_Investments_AspNetUsers_UserID",
                table: "Investments");

            migrationBuilder.DropIndex(
                name: "IX_Investments_IdeaID",
                table: "Investments");

            migrationBuilder.DropIndex(
                name: "IX_Investments_UserID",
                table: "Investments");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Investments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Investments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdeasIdeaId",
                table: "Investments",
                type: "int",
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
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace ideaMarket.Migrations
{
    public partial class addIdeasAndInvestments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ideas",
                columns: table => new
                {
                    IdeaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdeaName = table.Column<string>(nullable: false),
                    IdeaOwner = table.Column<string>(nullable: false),
                    ContactDetails = table.Column<string>(nullable: false),
                    MinimumCapital = table.Column<int>(nullable: false),
                    MaximumCapital = table.Column<int>(nullable: false),
                    IdeaCriteria = table.Column<string>(nullable: false),
                    IdeaSummary = table.Column<string>(nullable: false),
                    IdeaPicture = table.Column<string>(nullable: false),
                    IdeaPlan = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ideas", x => x.IdeaId);
                });

            migrationBuilder.CreateTable(
                name: "Investments",
                columns: table => new
                {
                    InvestimentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    IdeaId = table.Column<int>(nullable: false),
                    InvestmentAmount = table.Column<int>(nullable: false),
                    AmountInvested = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investments", x => x.InvestimentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ideas");

            migrationBuilder.DropTable(
                name: "Investments");
        }
    }
}

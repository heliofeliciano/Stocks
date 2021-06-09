using Microsoft.EntityFrameworkCore.Migrations;

namespace Stocks.Migrations
{
    public partial class StockImageColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PathImageLogo",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PathImageLogo",
                table: "Companies");
        }
    }
}

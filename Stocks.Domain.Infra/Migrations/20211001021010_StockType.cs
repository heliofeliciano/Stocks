using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Stocks.Domain.Infra.Migrations
{
    public partial class StockType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Company_CompanyId",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_StockMarket_StockMarketId",
                table: "Stock");

            migrationBuilder.AlterColumn<Guid>(
                name: "StockMarketId",
                table: "Stock",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CompanyId",
                table: "Stock",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EStockType",
                table: "Stock",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Company_CompanyId",
                table: "Stock",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_StockMarket_StockMarketId",
                table: "Stock",
                column: "StockMarketId",
                principalTable: "StockMarket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Company_CompanyId",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_StockMarket_StockMarketId",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EStockType",
                table: "Stock");

            migrationBuilder.AlterColumn<Guid>(
                name: "StockMarketId",
                table: "Stock",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "CompanyId",
                table: "Stock",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Company_CompanyId",
                table: "Stock",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_StockMarket_StockMarketId",
                table: "Stock",
                column: "StockMarketId",
                principalTable: "StockMarket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RA.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class nTierUpdate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Categories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Tables",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Suppliers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Stocks",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "OrderDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Employees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true);
        }
    }
}

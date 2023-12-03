﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RA.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UnitsInStockInt32 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UnitsInStock",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "UnitsInStock",
                table: "Products",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}

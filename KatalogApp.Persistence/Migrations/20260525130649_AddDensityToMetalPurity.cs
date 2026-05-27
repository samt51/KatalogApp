using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KatalogApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddDensityToMetalPurity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Density",
                table: "MetalPurities",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 25, 16, 6, 48, 340, DateTimeKind.Local).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "MetalPurities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Density",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "MetalPurities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Density",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "MetalPurities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Density",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "MetalPurities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Density",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "MetalPurities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Density",
                value: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Density",
                table: "MetalPurities");

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 25, 6, 20, 21, 798, DateTimeKind.Local).AddTicks(2032));
        }
    }
}

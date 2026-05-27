using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KatalogApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedMetalPurityData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 25, 16, 10, 37, 618, DateTimeKind.Local).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "MetalPurities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Density",
                value: 11.0m);

            migrationBuilder.UpdateData(
                table: "MetalPurities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Density",
                value: 11.2m);

            migrationBuilder.UpdateData(
                table: "MetalPurities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Density",
                value: 11.6m);

            migrationBuilder.UpdateData(
                table: "MetalPurities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Density",
                value: 13.4m);

            migrationBuilder.UpdateData(
                table: "MetalPurities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Density",
                value: 15.5m);

            migrationBuilder.InsertData(
                table: "MetalPurities",
                columns: new[] { "Id", "CreatedDate", "Density", "IsDeleted", "Milyem", "ModifyDate", "Name", "UserId" },
                values: new object[,]
                {
                    { 6, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.75m, false, 0.916m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "22K", null },
                    { 7, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19.32m, false, 0.995m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "24K", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MetalPurities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MetalPurities",
                keyColumn: "Id",
                keyValue: 7);

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
    }
}

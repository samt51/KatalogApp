using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KatalogApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStoneSettingToUnitId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MetalPurities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MetalPurities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "SettingType",
                table: "StoneSettings");

            migrationBuilder.AddColumn<int>(
                name: "UnitId",
                table: "StoneSettings",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 25, 19, 40, 44, 233, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "StoneSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "UnitId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "StoneSettings",
                keyColumn: "Id",
                keyValue: 2,
                column: "UnitId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "StoneSettings",
                keyColumn: "Id",
                keyValue: 3,
                column: "UnitId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "StoneSettings",
                keyColumn: "Id",
                keyValue: 4,
                column: "UnitId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_StoneSettings_UnitId",
                table: "StoneSettings",
                column: "UnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_StoneSettings_Units_UnitId",
                table: "StoneSettings",
                column: "UnitId",
                principalTable: "Units",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoneSettings_Units_UnitId",
                table: "StoneSettings");

            migrationBuilder.DropIndex(
                name: "IX_StoneSettings_UnitId",
                table: "StoneSettings");

            migrationBuilder.DropColumn(
                name: "UnitId",
                table: "StoneSettings");

            migrationBuilder.AddColumn<string>(
                name: "SettingType",
                table: "StoneSettings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 25, 16, 10, 37, 618, DateTimeKind.Local).AddTicks(7551));

            migrationBuilder.InsertData(
                table: "MetalPurities",
                columns: new[] { "Id", "CreatedDate", "Density", "IsDeleted", "Milyem", "ModifyDate", "Name", "UserId" },
                values: new object[,]
                {
                    { 6, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.75m, false, 0.916m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "22K", null },
                    { 7, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19.32m, false, 0.995m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "24K", null }
                });

            migrationBuilder.UpdateData(
                table: "StoneSettings",
                keyColumn: "Id",
                keyValue: 1,
                column: "SettingType",
                value: "Adet");

            migrationBuilder.UpdateData(
                table: "StoneSettings",
                keyColumn: "Id",
                keyValue: 2,
                column: "SettingType",
                value: "Adet");

            migrationBuilder.UpdateData(
                table: "StoneSettings",
                keyColumn: "Id",
                keyValue: 3,
                column: "SettingType",
                value: "Karat");

            migrationBuilder.UpdateData(
                table: "StoneSettings",
                keyColumn: "Id",
                keyValue: 4,
                column: "SettingType",
                value: "Karat");
        }
    }
}

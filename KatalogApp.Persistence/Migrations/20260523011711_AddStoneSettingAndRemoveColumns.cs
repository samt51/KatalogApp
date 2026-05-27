using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KatalogApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddStoneSettingAndRemoveColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CostSettingPrice",
                table: "Stones");

            migrationBuilder.DropColumn(
                name: "CustomerPrice",
                table: "Stones");

            migrationBuilder.DropColumn(
                name: "CustomerSettingPrice",
                table: "Stones");

            migrationBuilder.DropColumn(
                name: "SettingType",
                table: "Stones");

            migrationBuilder.AddColumn<int>(
                name: "StoneSettingId",
                table: "Stones",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StoneSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SettingType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SettingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoneSettings", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "StoneSettings",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "ModifyDate", "SettingPrice", "SettingType", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.50m, "Adet", null },
                    { 2, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.70m, "Adet", null },
                    { 3, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m, "Karat", null },
                    { 4, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, "Karat", null }
                });

            migrationBuilder.UpdateData(
                table: "Stones",
                keyColumn: "Id",
                keyValue: 1,
                column: "StoneSettingId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stones",
                keyColumn: "Id",
                keyValue: 2,
                column: "StoneSettingId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Stones",
                keyColumn: "Id",
                keyValue: 3,
                column: "StoneSettingId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stones",
                keyColumn: "Id",
                keyValue: 4,
                column: "StoneSettingId",
                value: 4);

            migrationBuilder.CreateIndex(
                name: "IX_Stones_StoneSettingId",
                table: "Stones",
                column: "StoneSettingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stones_StoneSettings_StoneSettingId",
                table: "Stones",
                column: "StoneSettingId",
                principalTable: "StoneSettings",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stones_StoneSettings_StoneSettingId",
                table: "Stones");

            migrationBuilder.DropTable(
                name: "StoneSettings");

            migrationBuilder.DropIndex(
                name: "IX_Stones_StoneSettingId",
                table: "Stones");

            migrationBuilder.DropColumn(
                name: "StoneSettingId",
                table: "Stones");

            migrationBuilder.AddColumn<decimal>(
                name: "CostSettingPrice",
                table: "Stones",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CustomerPrice",
                table: "Stones",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CustomerSettingPrice",
                table: "Stones",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "SettingType",
                table: "Stones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Stones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CostSettingPrice", "CustomerPrice", "CustomerSettingPrice", "SettingType" },
                values: new object[] { 0.50m, 0m, 0m, "Adet" });

            migrationBuilder.UpdateData(
                table: "Stones",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CostSettingPrice", "CustomerPrice", "CustomerSettingPrice", "SettingType" },
                values: new object[] { 0.70m, 0m, 0m, "Adet" });

            migrationBuilder.UpdateData(
                table: "Stones",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CostSettingPrice", "CustomerPrice", "CustomerSettingPrice", "SettingType" },
                values: new object[] { 30m, 0m, 0m, "Karat" });

            migrationBuilder.UpdateData(
                table: "Stones",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CostSettingPrice", "CustomerPrice", "CustomerSettingPrice", "SettingType" },
                values: new object[] { 40m, 0m, 0m, "Karat" });
        }
    }
}

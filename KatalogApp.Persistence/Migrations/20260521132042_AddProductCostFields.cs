using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KatalogApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddProductCostFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "GoldCost",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "LaborCost",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SettingCost",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "StoneCost",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalCost",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "GoldCost", "LaborCost", "SettingCost", "StoneCost", "TotalCost" },
                values: new object[] { 0m, 0m, 0m, 0m, 0m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoldCost",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "LaborCost",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SettingCost",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "StoneCost",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TotalCost",
                table: "Products");
        }
    }
}

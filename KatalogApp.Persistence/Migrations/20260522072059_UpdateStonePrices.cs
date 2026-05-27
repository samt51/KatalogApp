using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KatalogApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStonePrices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SettingPrice",
                table: "Stones",
                newName: "CustomerSettingPrice");

            migrationBuilder.RenameColumn(
                name: "PricePerCarat",
                table: "Stones",
                newName: "CustomerPrice");

            migrationBuilder.AddColumn<decimal>(
                name: "CostPrice",
                table: "Stones",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CostSettingPrice",
                table: "Stones",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Stones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CostPrice", "CostSettingPrice", "CustomerPrice", "CustomerSettingPrice" },
                values: new object[] { 200m, 0.50m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Stones",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CostPrice", "CostSettingPrice", "CustomerPrice", "CustomerSettingPrice" },
                values: new object[] { 300m, 0.70m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Stones",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CostPrice", "CostSettingPrice", "CustomerPrice", "CustomerSettingPrice" },
                values: new object[] { 350m, 30m, 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Stones",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CostPrice", "CostSettingPrice", "CustomerPrice", "CustomerSettingPrice" },
                values: new object[] { 400m, 40m, 0m, 0m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CostPrice",
                table: "Stones");

            migrationBuilder.DropColumn(
                name: "CostSettingPrice",
                table: "Stones");

            migrationBuilder.RenameColumn(
                name: "CustomerSettingPrice",
                table: "Stones",
                newName: "SettingPrice");

            migrationBuilder.RenameColumn(
                name: "CustomerPrice",
                table: "Stones",
                newName: "PricePerCarat");

            migrationBuilder.UpdateData(
                table: "Stones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PricePerCarat", "SettingPrice" },
                values: new object[] { 200m, 0.50m });

            migrationBuilder.UpdateData(
                table: "Stones",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PricePerCarat", "SettingPrice" },
                values: new object[] { 300m, 0.70m });

            migrationBuilder.UpdateData(
                table: "Stones",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PricePerCarat", "SettingPrice" },
                values: new object[] { 350m, 30m });

            migrationBuilder.UpdateData(
                table: "Stones",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PricePerCarat", "SettingPrice" },
                values: new object[] { 400m, 40m });
        }
    }
}

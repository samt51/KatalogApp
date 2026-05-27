using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KatalogApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductMetalColorAndPurity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Colors_ColorsId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Karat",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "ColorsId",
                table: "Products",
                newName: "StoneColorId");

            migrationBuilder.RenameColumn(
                name: "ColorId",
                table: "Products",
                newName: "MetalPurityId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ColorsId",
                table: "Products",
                newName: "IX_Products_StoneColorId");

            migrationBuilder.AddColumn<int>(
                name: "MetalColorId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "MetalColorId", "MetalPurityId" },
                values: new object[] { null, 4 });

            migrationBuilder.CreateIndex(
                name: "IX_Products_MetalColorId",
                table: "Products",
                column: "MetalColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_MetalPurityId",
                table: "Products",
                column: "MetalPurityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Colors_MetalColorId",
                table: "Products",
                column: "MetalColorId",
                principalTable: "Colors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Colors_StoneColorId",
                table: "Products",
                column: "StoneColorId",
                principalTable: "Colors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_MetalPurities_MetalPurityId",
                table: "Products",
                column: "MetalPurityId",
                principalTable: "MetalPurities",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Colors_MetalColorId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Colors_StoneColorId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_MetalPurities_MetalPurityId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_MetalColorId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_MetalPurityId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MetalColorId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "StoneColorId",
                table: "Products",
                newName: "ColorsId");

            migrationBuilder.RenameColumn(
                name: "MetalPurityId",
                table: "Products",
                newName: "ColorId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_StoneColorId",
                table: "Products",
                newName: "IX_Products_ColorsId");

            migrationBuilder.AddColumn<string>(
                name: "Karat",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "ColorId", "Karat" },
                values: new object[] { null, "14k" });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Colors_ColorsId",
                table: "Products",
                column: "ColorsId",
                principalTable: "Colors",
                principalColumn: "Id");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KatalogApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductStone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Stones_StoneId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Stones_Colors_ColorsId",
                table: "Stones");

            migrationBuilder.DropForeignKey(
                name: "FK_Stones_Units_UnitsId",
                table: "Stones");

            migrationBuilder.DropIndex(
                name: "IX_Products_StoneId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Carat",
                table: "Stones");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Stones");

            migrationBuilder.DropColumn(
                name: "QuantityUnit",
                table: "Stones");

            migrationBuilder.DropColumn(
                name: "StoneId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "UnitsId",
                table: "Stones",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ColorsId",
                table: "Stones",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "ProductStones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    StoneId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Carat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalCarat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductStones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductStones_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductStones_Stones_StoneId",
                        column: x => x.StoneId,
                        principalTable: "Stones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 700, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 702, DateTimeKind.Local).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 702, DateTimeKind.Local).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 702, DateTimeKind.Local).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 702, DateTimeKind.Local).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 703, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 703, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1162));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1165));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1171));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1224));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1284));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1289));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1326));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1329));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1362));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1394));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1398));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1411));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1416));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1422));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1482));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1484));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1583));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1585));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1586));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1588));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1589));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1647));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1654));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1657));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1714));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 304,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 305,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1738));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 306,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 307,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 308,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 309,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 310,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 311,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1744));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 312,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 313,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 314,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 315,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 316,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 317,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 318,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 319,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 320,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 321,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 322,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1774));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 323,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 324,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 325,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 326,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 327,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 328,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 329,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 330,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 331,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1785));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 332,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 333,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 334,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 335,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 336,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 337,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 338,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 339,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 340,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 341,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1805));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 342,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 343,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1807));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 344,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 345,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 346,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 347,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 348,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1813));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 349,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1814));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 350,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 351,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 352,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 353,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 354,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1819));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 355,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 356,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1822));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 357,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1823));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 358,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 359,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 360,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1835));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 361,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 362,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1837));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 363,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 364,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 365,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1841));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 366,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 367,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1843));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 368,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 369,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 370,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 371,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 372,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 373,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 374,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 375,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 376,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 377,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 378,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 379,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 380,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 381,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 382,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 383,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 384,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 385,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 386,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 387,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 388,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 389,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 390,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 391,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 392,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 393,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 394,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 395,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1882));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 396,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 397,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 398,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 399,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 401,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 402,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 403,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 404,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 405,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 406,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 407,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 408,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 409,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1907));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 410,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 411,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 412,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 413,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 414,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 415,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 416,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 417,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 418,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 419,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 420,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 421,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 422,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 423,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 424,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 425,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 426,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 427,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 428,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 429,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 430,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 431,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 432,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 433,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 434,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 435,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 436,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 437,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 438,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 439,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 440,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 441,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 442,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 443,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 444,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 445,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 446,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 447,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 448,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 449,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 450,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 451,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 452,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 453,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2145));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 454,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 455,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 456,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 457,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 458,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 459,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 460,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2153));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 461,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2154));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 462,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 463,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 464,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 465,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2158));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 466,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9179));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 712, DateTimeKind.Local).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 728, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 734, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 49, 12, 734, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.CreateIndex(
                name: "IX_ProductStones_ProductId",
                table: "ProductStones",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStones_StoneId",
                table: "ProductStones",
                column: "StoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stones_Colors_ColorsId",
                table: "Stones",
                column: "ColorsId",
                principalTable: "Colors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stones_Units_UnitsId",
                table: "Stones",
                column: "UnitsId",
                principalTable: "Units",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stones_Colors_ColorsId",
                table: "Stones");

            migrationBuilder.DropForeignKey(
                name: "FK_Stones_Units_UnitsId",
                table: "Stones");

            migrationBuilder.DropTable(
                name: "ProductStones");

            migrationBuilder.AlterColumn<int>(
                name: "UnitsId",
                table: "Stones",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ColorsId",
                table: "Stones",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Carat",
                table: "Stones",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Quantity",
                table: "Stones",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "QuantityUnit",
                table: "Stones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "StoneId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 431, DateTimeKind.Local).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 432, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 432, DateTimeKind.Local).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 432, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 432, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 432, DateTimeKind.Local).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 432, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(558));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(783));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 304,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 305,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 306,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 307,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 308,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 309,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 310,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 311,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 312,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 313,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 314,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 315,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 316,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 317,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 318,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 319,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 320,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 321,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 322,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 323,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 324,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 325,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 326,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 327,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 328,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 329,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 330,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 331,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 332,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 333,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 334,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 335,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 336,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 337,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 338,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(955));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 339,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 340,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 341,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 342,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 343,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 344,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 345,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 346,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 347,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 348,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 349,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 350,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 351,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 352,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 353,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 354,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 355,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 356,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 357,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 358,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 359,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 360,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 361,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 362,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 363,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 364,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 365,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 366,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 367,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 368,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 369,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 370,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 371,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 372,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 373,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 374,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 375,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 376,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 377,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 378,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 379,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 380,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 381,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 382,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 383,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1032));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 384,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 385,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 386,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 387,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 388,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 389,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 390,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 391,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 392,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 393,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 394,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 395,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 396,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 397,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 398,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 399,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 401,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 402,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 403,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 404,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 405,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 406,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 407,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 408,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 409,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 410,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 411,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 412,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 413,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 414,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 415,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 416,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 417,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 418,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 419,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 420,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 421,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 422,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1093));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 423,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 424,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 425,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 426,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 427,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1098));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 428,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 429,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 430,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 431,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 432,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 433,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 434,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 435,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 436,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 437,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 438,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 439,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 440,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 441,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 442,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 443,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 444,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 445,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 446,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 447,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 448,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 449,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 450,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 451,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 452,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 453,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 454,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 455,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 456,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 457,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 458,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 459,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 460,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 461,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 462,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 463,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 464,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 465,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1155));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 466,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1156));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(902), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(922), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(924), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(926), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(927), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(929), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(945), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(947), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(949), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(974), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(976), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(978), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(980), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(982), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(983), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(985), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(987), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(988), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(990), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(991), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1002), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1004), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1005), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1007), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1009), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1010), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1012), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1014), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1015), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1017), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1018), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1020), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1022), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1032), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1034), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1043), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1045), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1047), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1048), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1050), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1052), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1054), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1055), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1057), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1059), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1060), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1062), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1072), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1074), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1076), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1078), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1079), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1081), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1083), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1084), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1086), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1087), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1089), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1091), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1092), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1094), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1117), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1119), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1121), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1122), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1124), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1126), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1127), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1129), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1131), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1132), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1134), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1136), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1137), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1139), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1149), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1151), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1153), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1154), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1156), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1158), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1159), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1161), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1163), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1164), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1166), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1173), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1174), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1176), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1186), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1188), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1190), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1195), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1197), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1198), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1200), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1202), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1203), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1205), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1207), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1208), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1210), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1218), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1220), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1222), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1223), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1225), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1227), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1228), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1230), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1232), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1234), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1241), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1243), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1244), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1246), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1254), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1256), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1258), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1260), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1261), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1263), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1265), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1266), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1268), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1273), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1275), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1276), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1278), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1280), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1290), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1293), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1294), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1296), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1297), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1299), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1301), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1302), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1310), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1313), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1315), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1317), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1320), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1322), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1333), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1335), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1336), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1338), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1340), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1342), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1344), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1352), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1354), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1356), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1357), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1359), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1360), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1362), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1371), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1373), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1375), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1376), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1378), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1386), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1388), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1389), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1391), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1393), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1394), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1396), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1397), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1408), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1409), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1411), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1413), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1414), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1416), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1418), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1419), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1421), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1423), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1424), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1426), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1430), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1432), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1441), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1447), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1449), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1450), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1458), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1460), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1462), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1463), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1465), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1466), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1468), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1470), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1471), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1473), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1475), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1476), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1478), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedDate", "StoneId" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1479), null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 460, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 38, 8, 460, DateTimeKind.Local).AddTicks(6147));

            migrationBuilder.CreateIndex(
                name: "IX_Products_StoneId",
                table: "Products",
                column: "StoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Stones_StoneId",
                table: "Products",
                column: "StoneId",
                principalTable: "Stones",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stones_Colors_ColorsId",
                table: "Stones",
                column: "ColorsId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stones_Units_UnitsId",
                table: "Stones",
                column: "UnitsId",
                principalTable: "Units",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

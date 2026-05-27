using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KatalogApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductMetalRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiamondCarat",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Gram",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 358, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 359, DateTimeKind.Local).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 359, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 359, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 359, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 359, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 359, DateTimeKind.Local).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 360, DateTimeKind.Local).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 360, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 360, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 360, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 360, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 360, DateTimeKind.Local).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 360, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 360, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 360, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "CustomerGroups",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 361, DateTimeKind.Local).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "CustomerGroups",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 361, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "CustomerGroups",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 361, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "CustomerGroups",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 361, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "CustomerGroups",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 361, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "MetalPurities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 361, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "MetalPurities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 361, DateTimeKind.Local).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "MetalPurities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 361, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "MetalPurities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 361, DateTimeKind.Local).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "MetalTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 361, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "MetalTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 361, DateTimeKind.Local).AddTicks(9527));

            migrationBuilder.UpdateData(
                table: "MetalTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 361, DateTimeKind.Local).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "MetalTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 361, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "MetalTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 361, DateTimeKind.Local).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 304,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 305,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 306,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 307,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 308,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 309,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 310,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 311,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 312,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 313,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 314,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 315,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 316,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 317,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 318,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 319,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 320,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 321,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 322,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 323,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 324,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 325,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 326,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 327,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 328,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 329,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 330,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 331,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 332,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 333,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 334,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 335,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 336,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 337,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 338,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 339,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 340,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 341,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 342,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 343,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 344,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 345,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 346,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 347,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 348,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 349,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 350,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 351,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 352,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 353,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 354,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 355,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 356,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 357,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 358,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 359,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 360,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 361,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 362,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 363,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 364,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 365,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 366,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 367,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 368,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 369,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 370,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 371,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 372,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 373,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 374,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 375,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 376,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 377,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 378,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 379,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 380,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 381,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 382,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 383,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 384,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 385,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 386,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 387,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 388,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 389,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 390,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 391,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 392,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 393,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 394,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 395,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 396,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 397,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 398,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 399,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 401,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 402,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 403,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 404,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 405,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 406,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 407,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 408,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 409,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 410,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 411,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 412,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 413,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 414,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 415,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 416,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 417,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 418,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 419,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 420,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 421,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 422,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 423,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 424,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 425,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 426,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 427,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 428,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 429,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 430,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 431,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 432,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 433,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 434,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 435,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 436,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 437,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 438,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 439,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 440,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 441,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 442,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 443,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 444,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 445,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 446,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 447,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 448,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 449,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 450,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 451,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 452,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 453,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 454,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 455,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 456,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 457,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 458,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 459,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 460,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 461,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 462,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 463,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 464,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 465,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 466,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2225));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2256));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2457));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2527));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2556));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2559));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2576));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2589));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2638));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2806));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2808));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 384, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 384, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 384, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 384, DateTimeKind.Local).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 384, DateTimeKind.Local).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 384, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 384, DateTimeKind.Local).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 384, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 384, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 384, DateTimeKind.Local).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 384, DateTimeKind.Local).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(5433));

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 391, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 6, 2, 20, 391, DateTimeKind.Local).AddTicks(1540));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DiamondCarat",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Gram",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 668, DateTimeKind.Local).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 669, DateTimeKind.Local).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 669, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 669, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 669, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 669, DateTimeKind.Local).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 669, DateTimeKind.Local).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 670, DateTimeKind.Local).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 670, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 670, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 670, DateTimeKind.Local).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 670, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 670, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 670, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 670, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 670, DateTimeKind.Local).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "CustomerGroups",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 671, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "CustomerGroups",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 671, DateTimeKind.Local).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "CustomerGroups",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 671, DateTimeKind.Local).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "CustomerGroups",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 671, DateTimeKind.Local).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "CustomerGroups",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 671, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "MetalPurities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 671, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "MetalPurities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 671, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "MetalPurities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 671, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "MetalPurities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 671, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "MetalTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 671, DateTimeKind.Local).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "MetalTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 671, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "MetalTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 671, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "MetalTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 671, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "MetalTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 671, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6016));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6024));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6227));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6324));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6476));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6647));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 304,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 305,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 306,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 307,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 308,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 309,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 310,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 311,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 312,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 313,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 314,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 315,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 316,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 317,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 318,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 319,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 320,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 321,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 322,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 323,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 324,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 325,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 326,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 327,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 328,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 329,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 330,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 331,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 332,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 333,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 334,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 335,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 336,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 337,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 338,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 339,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 340,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 341,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 342,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 343,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 344,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 345,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 346,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 347,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 348,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 349,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 350,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 351,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 352,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 353,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 354,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 355,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 356,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 357,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 358,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 359,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 360,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 361,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 362,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 363,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 364,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 365,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 366,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 367,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 368,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 369,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 370,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 371,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 372,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 373,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 374,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 375,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 376,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 377,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 378,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 379,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 380,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 381,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 382,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 383,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 384,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 385,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 386,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 387,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 388,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 389,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 390,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 391,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 392,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 393,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 394,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 395,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 396,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 397,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 398,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 399,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 401,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 402,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 403,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 404,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 405,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 406,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 407,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 408,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 409,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 410,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 411,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 412,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 413,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 414,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 415,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 416,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 417,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 418,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 419,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 420,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 421,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 422,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 423,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 424,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 425,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 426,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 427,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 428,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 429,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 430,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 431,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 432,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 433,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 434,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 435,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 436,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 437,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 438,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 439,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 440,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 441,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 442,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 443,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 444,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 445,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 446,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 447,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 448,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 449,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 450,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 451,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 452,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 453,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 454,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 455,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 456,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 457,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 458,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 459,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 460,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 461,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 462,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 463,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 464,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 465,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 466,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 693, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1222), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1249), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1251), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1253), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1261), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1262), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1265), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1267), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1269), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1270), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1272), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1274), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1275), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1277), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1279), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1344), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1346), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1348), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1350), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1351), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1353), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1355), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1357), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1359), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1361), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1363), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1364), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1366), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1368), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1379), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1381), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1383), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1385), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1387), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1389), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1391), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1421), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1423), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1425), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1427), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1428), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1431), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1433), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1443), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1445), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1447), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1449), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1451), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1470), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1472), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1474), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1475), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1477), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1479), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1481), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1483), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1499), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1501), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1525), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1527), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1528), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1530), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1532), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1534), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1535), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1537), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1539), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1540), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1542), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1544), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1556), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1558), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1560), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1561), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1563), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1565), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1566), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1568), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1570), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1574), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1598), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1599), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1601), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1603), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1614), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1616), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1617), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1619), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1621), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1623), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1624), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1626), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1628), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1629), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1631), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1633), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1635), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1636), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1653), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1655), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1656), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1658), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1681), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1683), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1685), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1686), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1688), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1690), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1692), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1693), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1695), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1697), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1707), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1709), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1711), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1713), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1714), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1716), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1718), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1719), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1721), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1723), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1725), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1730), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1747), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1758), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1760), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1762), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1764), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1765), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1767), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1769), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1770), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1772), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1774), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1775), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1777), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1779), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1781), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1791), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1793), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1795), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1797), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1798), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1800), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1849), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1851), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1853), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1855), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1856), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1858), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1860), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1862), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1872), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1874), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1876), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1878), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1879), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1881), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1883), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1887), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1889), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1891), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1892), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1894), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1896), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1898), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1940), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1942), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1944), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1945), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1947), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1949), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1951), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1952), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1954), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1956), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1958), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1960), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1965), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1976), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1978), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1980), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1982), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1983), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1985), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1987), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1989), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(2011), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(2013), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(2015), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(2017), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(2018), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(2020), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(2022), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(2024), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(2026), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(2028), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(2029), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(2031), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(2033), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(2035), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram" },
                values: new object[] { new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(2037), 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 695, DateTimeKind.Local).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 695, DateTimeKind.Local).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 695, DateTimeKind.Local).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 695, DateTimeKind.Local).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 695, DateTimeKind.Local).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 695, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 695, DateTimeKind.Local).AddTicks(3595));

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 695, DateTimeKind.Local).AddTicks(3595));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 695, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 695, DateTimeKind.Local).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 695, DateTimeKind.Local).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 701, DateTimeKind.Local).AddTicks(63));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 701, DateTimeKind.Local).AddTicks(567));
        }
    }
}

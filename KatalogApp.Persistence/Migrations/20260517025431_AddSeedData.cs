using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KatalogApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Clarity",
                table: "Stones");

            migrationBuilder.DropColumn(
                name: "Cut",
                table: "Stones");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Stones");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "ProductMetals");

            migrationBuilder.DropColumn(
                name: "MetalType",
                table: "ProductMetals");

            migrationBuilder.DropColumn(
                name: "Purity",
                table: "ProductMetals");

            migrationBuilder.AddColumn<int>(
                name: "StoneClarityId",
                table: "Stones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StoneCutId",
                table: "Stones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StoneTypeId",
                table: "Stones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "ProductMetals",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ColorsId",
                table: "ProductMetals",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MetalPurityId",
                table: "ProductMetals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MetalTypeId",
                table: "ProductMetals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ColorType",
                table: "Colors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "MetalPurities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetalPurities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MetalTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetalTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StoneClarities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoneClarities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StoneCuts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoneCuts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StoneTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoneTypes", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Code", "ColorType", "CreatedDate", "IsDeleted", "ModifyDate", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, "D", "Stone", new DateTime(2026, 5, 17, 5, 54, 30, 670, DateTimeKind.Local).AddTicks(5668), false, null, "D", null },
                    { 2, "E", "Stone", new DateTime(2026, 5, 17, 5, 54, 30, 670, DateTimeKind.Local).AddTicks(5676), false, null, "E", null },
                    { 3, "F", "Stone", new DateTime(2026, 5, 17, 5, 54, 30, 670, DateTimeKind.Local).AddTicks(5677), false, null, "F", null },
                    { 4, "G", "Stone", new DateTime(2026, 5, 17, 5, 54, 30, 670, DateTimeKind.Local).AddTicks(5678), false, null, "G", null },
                    { 5, "H", "Stone", new DateTime(2026, 5, 17, 5, 54, 30, 670, DateTimeKind.Local).AddTicks(5680), false, null, "H", null },
                    { 6, "WHT", "Metal", new DateTime(2026, 5, 17, 5, 54, 30, 670, DateTimeKind.Local).AddTicks(5681), false, null, "Beyaz Altın", null },
                    { 7, "YLW", "Metal", new DateTime(2026, 5, 17, 5, 54, 30, 670, DateTimeKind.Local).AddTicks(5682), false, null, "Sarı Altın", null },
                    { 8, "RSE", "Metal", new DateTime(2026, 5, 17, 5, 54, 30, 670, DateTimeKind.Local).AddTicks(5750), false, null, "Rose Altın", null },
                    { 9, "PLT", "Metal", new DateTime(2026, 5, 17, 5, 54, 30, 670, DateTimeKind.Local).AddTicks(5752), false, null, "Platin", null }
                });

            migrationBuilder.InsertData(
                table: "CustomerGroups",
                columns: new[] { "Id", "CreatedDate", "DiscountRate", "IsDeleted", "ModifyDate", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 5, 54, 30, 671, DateTimeKind.Local).AddTicks(1386), 0m, false, null, "G1", null },
                    { 2, new DateTime(2026, 5, 17, 5, 54, 30, 671, DateTimeKind.Local).AddTicks(1426), 5m, false, null, "G2", null },
                    { 3, new DateTime(2026, 5, 17, 5, 54, 30, 671, DateTimeKind.Local).AddTicks(1428), 10m, false, null, "G3", null },
                    { 4, new DateTime(2026, 5, 17, 5, 54, 30, 671, DateTimeKind.Local).AddTicks(1432), 15m, false, null, "G4", null },
                    { 5, new DateTime(2026, 5, 17, 5, 54, 30, 671, DateTimeKind.Local).AddTicks(1433), 20m, false, null, "G5", null }
                });

            migrationBuilder.InsertData(
                table: "MetalPurities",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "ModifyDate", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 5, 54, 30, 671, DateTimeKind.Local).AddTicks(4211), false, null, "8K", null },
                    { 2, new DateTime(2026, 5, 17, 5, 54, 30, 671, DateTimeKind.Local).AddTicks(4216), false, null, "14K", null },
                    { 3, new DateTime(2026, 5, 17, 5, 54, 30, 671, DateTimeKind.Local).AddTicks(4217), false, null, "18K", null },
                    { 4, new DateTime(2026, 5, 17, 5, 54, 30, 671, DateTimeKind.Local).AddTicks(4218), false, null, "22K", null }
                });

            migrationBuilder.InsertData(
                table: "MetalTypes",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "ModifyDate", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 5, 54, 30, 671, DateTimeKind.Local).AddTicks(7062), false, null, "Altın", null },
                    { 2, new DateTime(2026, 5, 17, 5, 54, 30, 671, DateTimeKind.Local).AddTicks(7067), false, null, "Beyaz Altın", null },
                    { 3, new DateTime(2026, 5, 17, 5, 54, 30, 671, DateTimeKind.Local).AddTicks(7069), false, null, "Rose Altın", null },
                    { 4, new DateTime(2026, 5, 17, 5, 54, 30, 671, DateTimeKind.Local).AddTicks(7070), false, null, "Platin", null },
                    { 5, new DateTime(2026, 5, 17, 5, 54, 30, 671, DateTimeKind.Local).AddTicks(7070), false, null, "Gümüş", null }
                });

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
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1279));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1425));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1631));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1633));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1714));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1762));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1774));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1795));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1855));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1889));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedDate",
                value: new DateTime(2026, 5, 17, 5, 54, 30, 680, DateTimeKind.Local).AddTicks(2037));

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

            migrationBuilder.InsertData(
                table: "StoneClarities",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "ModifyDate", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(5443), false, null, "FL", null },
                    { 2, new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(5448), false, null, "IF", null },
                    { 3, new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(5450), false, null, "VVS1", null },
                    { 4, new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(5451), false, null, "VVS2", null },
                    { 5, new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(5452), false, null, "VS1", null },
                    { 6, new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(5453), false, null, "VS2", null },
                    { 7, new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(5453), false, null, "SI1", null },
                    { 8, new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(5454), false, null, "SI2", null }
                });

            migrationBuilder.InsertData(
                table: "StoneCuts",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "ModifyDate", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(9839), false, null, "Round", null },
                    { 2, new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(9844), false, null, "Princess", null },
                    { 3, new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(9846), false, null, "Emerald", null },
                    { 4, new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(9846), false, null, "Oval", null },
                    { 5, new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(9848), false, null, "Pear", null },
                    { 6, new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(9849), false, null, "Cushion", null },
                    { 7, new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(9850), false, null, "Radiant", null },
                    { 8, new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(9851), false, null, "Heart", null },
                    { 9, new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(9852), false, null, "Marquise", null },
                    { 10, new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(9853), false, null, "Asscher", null },
                    { 11, new DateTime(2026, 5, 17, 5, 54, 30, 694, DateTimeKind.Local).AddTicks(9854), false, null, "Baguette", null }
                });

            migrationBuilder.InsertData(
                table: "StoneTypes",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "ModifyDate", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 5, 54, 30, 695, DateTimeKind.Local).AddTicks(3584), false, null, "Pırlanta", null },
                    { 2, new DateTime(2026, 5, 17, 5, 54, 30, 695, DateTimeKind.Local).AddTicks(3589), false, null, "Baget", null },
                    { 3, new DateTime(2026, 5, 17, 5, 54, 30, 695, DateTimeKind.Local).AddTicks(3591), false, null, "Safir", null },
                    { 4, new DateTime(2026, 5, 17, 5, 54, 30, 695, DateTimeKind.Local).AddTicks(3592), false, null, "Yakut", null },
                    { 5, new DateTime(2026, 5, 17, 5, 54, 30, 695, DateTimeKind.Local).AddTicks(3593), false, null, "Zümrüt", null },
                    { 6, new DateTime(2026, 5, 17, 5, 54, 30, 695, DateTimeKind.Local).AddTicks(3594), false, null, "Elmas", null },
                    { 7, new DateTime(2026, 5, 17, 5, 54, 30, 695, DateTimeKind.Local).AddTicks(3595), false, null, "Moissanite", null },
                    { 8, new DateTime(2026, 5, 17, 5, 54, 30, 695, DateTimeKind.Local).AddTicks(3595), false, null, "Zirkon", null }
                });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Id", "Code", "CreatedDate", "IsDeleted", "ModifyDate", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, "Ad", new DateTime(2026, 5, 17, 5, 54, 30, 695, DateTimeKind.Local).AddTicks(7019), false, null, "Adet", null },
                    { 2, "Ct", new DateTime(2026, 5, 17, 5, 54, 30, 695, DateTimeKind.Local).AddTicks(7026), false, null, "Ct", null },
                    { 3, "Gr", new DateTime(2026, 5, 17, 5, 54, 30, 695, DateTimeKind.Local).AddTicks(7027), false, null, "Gram", null }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Stones_StoneClarityId",
                table: "Stones",
                column: "StoneClarityId");

            migrationBuilder.CreateIndex(
                name: "IX_Stones_StoneCutId",
                table: "Stones",
                column: "StoneCutId");

            migrationBuilder.CreateIndex(
                name: "IX_Stones_StoneTypeId",
                table: "Stones",
                column: "StoneTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMetals_ColorsId",
                table: "ProductMetals",
                column: "ColorsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMetals_MetalPurityId",
                table: "ProductMetals",
                column: "MetalPurityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMetals_MetalTypeId",
                table: "ProductMetals",
                column: "MetalTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductMetals_Colors_ColorsId",
                table: "ProductMetals",
                column: "ColorsId",
                principalTable: "Colors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductMetals_MetalPurities_MetalPurityId",
                table: "ProductMetals",
                column: "MetalPurityId",
                principalTable: "MetalPurities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductMetals_MetalTypes_MetalTypeId",
                table: "ProductMetals",
                column: "MetalTypeId",
                principalTable: "MetalTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stones_StoneClarities_StoneClarityId",
                table: "Stones",
                column: "StoneClarityId",
                principalTable: "StoneClarities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stones_StoneCuts_StoneCutId",
                table: "Stones",
                column: "StoneCutId",
                principalTable: "StoneCuts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stones_StoneTypes_StoneTypeId",
                table: "Stones",
                column: "StoneTypeId",
                principalTable: "StoneTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductMetals_Colors_ColorsId",
                table: "ProductMetals");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductMetals_MetalPurities_MetalPurityId",
                table: "ProductMetals");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductMetals_MetalTypes_MetalTypeId",
                table: "ProductMetals");

            migrationBuilder.DropForeignKey(
                name: "FK_Stones_StoneClarities_StoneClarityId",
                table: "Stones");

            migrationBuilder.DropForeignKey(
                name: "FK_Stones_StoneCuts_StoneCutId",
                table: "Stones");

            migrationBuilder.DropForeignKey(
                name: "FK_Stones_StoneTypes_StoneTypeId",
                table: "Stones");

            migrationBuilder.DropTable(
                name: "MetalPurities");

            migrationBuilder.DropTable(
                name: "MetalTypes");

            migrationBuilder.DropTable(
                name: "StoneClarities");

            migrationBuilder.DropTable(
                name: "StoneCuts");

            migrationBuilder.DropTable(
                name: "StoneTypes");

            migrationBuilder.DropIndex(
                name: "IX_Stones_StoneClarityId",
                table: "Stones");

            migrationBuilder.DropIndex(
                name: "IX_Stones_StoneCutId",
                table: "Stones");

            migrationBuilder.DropIndex(
                name: "IX_Stones_StoneTypeId",
                table: "Stones");

            migrationBuilder.DropIndex(
                name: "IX_ProductMetals_ColorsId",
                table: "ProductMetals");

            migrationBuilder.DropIndex(
                name: "IX_ProductMetals_MetalPurityId",
                table: "ProductMetals");

            migrationBuilder.DropIndex(
                name: "IX_ProductMetals_MetalTypeId",
                table: "ProductMetals");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CustomerGroups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CustomerGroups",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CustomerGroups",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CustomerGroups",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CustomerGroups",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "StoneClarityId",
                table: "Stones");

            migrationBuilder.DropColumn(
                name: "StoneCutId",
                table: "Stones");

            migrationBuilder.DropColumn(
                name: "StoneTypeId",
                table: "Stones");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "ProductMetals");

            migrationBuilder.DropColumn(
                name: "ColorsId",
                table: "ProductMetals");

            migrationBuilder.DropColumn(
                name: "MetalPurityId",
                table: "ProductMetals");

            migrationBuilder.DropColumn(
                name: "MetalTypeId",
                table: "ProductMetals");

            migrationBuilder.DropColumn(
                name: "ColorType",
                table: "Colors");

            migrationBuilder.AddColumn<string>(
                name: "Clarity",
                table: "Stones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cut",
                table: "Stones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Stones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "ProductMetals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MetalType",
                table: "ProductMetals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Purity",
                table: "ProductMetals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
        }
    }
}

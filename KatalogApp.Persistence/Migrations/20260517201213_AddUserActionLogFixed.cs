using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KatalogApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddUserActionLogFixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SubscriptionEndDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Units",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "Units",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "StoneTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "StoneTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Stones",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "Stones",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "StoneCuts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "StoneCuts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "StoneClarities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "StoneClarities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Roles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ProductStones",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "ProductStones",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ProductPrices",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "ProductPrices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ProductMetals",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "ProductMetals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ProductImages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "ProductImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "MetalTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "MetalTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "MetalPurities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "MetalPurities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "CustomerGroups",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "CustomerGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Colors",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "Colors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ParentId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "UserActionLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ActionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActionLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserActionLogs_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserActionLogs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "Name", "ParentId", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BÄ°LEKLÄ°K", 0, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "ModifyDate", "Name", "ParentId", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KelepÃ§e Kategorisi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KELEPÃ‡E", 0, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate", "ParentId", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "ModifyDate", "Name", "ParentId", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KÃ¼pe Kategorisi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KÃœPE", 0, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "ModifyDate", "ParentId", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PÄ±rlanta Kategorisi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate", "ParentId", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "ModifyDate", "Name", "ParentId", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "YÃ¼zÃ¼k Kategorisi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "YÃœZÃœK", 0, 0 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "CustomerGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "CustomerGroups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "CustomerGroups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "CustomerGroups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "CustomerGroups",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "MetalPurities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "MetalPurities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "MetalPurities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "MetalPurities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "MetalTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "MetalTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "MetalTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "MetalTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "MetalTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedDate", "DiamondCarat", "Gram", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastName", "ModifyDate", "SubscriptionEndDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KavalcÄ±", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "SubscriptionEndDate", "UserId" },
                values: new object[] { new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.CreateIndex(
                name: "IX_UserActionLogs_ProductId",
                table: "UserActionLogs",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_UserActionLogs_UserId",
                table: "UserActionLogs",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserActionLogs");

            migrationBuilder.DropColumn(
                name: "DiamondCarat",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Gram",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SubscriptionEndDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Units",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "Units",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "StoneTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "StoneTypes",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Stones",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "Stones",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "StoneCuts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "StoneCuts",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "StoneClarities",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "StoneClarities",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Roles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "Roles",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ProductStones",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "ProductStones",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "Products",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ProductPrices",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "ProductPrices",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ProductMetals",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "ProductMetals",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ProductImages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "ProductImages",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "MetalTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "MetalTypes",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "MetalPurities",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "MetalPurities",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "CustomerGroups",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "CustomerGroups",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Colors",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "Colors",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Categories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ParentId",
                table: "Categories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "Name", "ParentId", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 358, DateTimeKind.Local).AddTicks(1800), null, "BİLEKLİK", null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "ModifyDate", "Name", "ParentId", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 359, DateTimeKind.Local).AddTicks(6755), "Kelepçe Kategorisi", null, "KELEPÇE", null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate", "ParentId", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 359, DateTimeKind.Local).AddTicks(6772), null, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "ModifyDate", "Name", "ParentId", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 359, DateTimeKind.Local).AddTicks(6773), "Küpe Kategorisi", null, "KÜPE", null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "ModifyDate", "ParentId", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 359, DateTimeKind.Local).AddTicks(6774), "Pırlanta Kategorisi", null, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate", "ParentId", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 359, DateTimeKind.Local).AddTicks(6776), null, null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "ModifyDate", "Name", "ParentId", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 359, DateTimeKind.Local).AddTicks(6777), "Yüzük Kategorisi", null, "YÜZÜK", null, null });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 360, DateTimeKind.Local).AddTicks(8138), null, null });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 360, DateTimeKind.Local).AddTicks(8146), null, null });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 360, DateTimeKind.Local).AddTicks(8147), null, null });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 360, DateTimeKind.Local).AddTicks(8148), null, null });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 360, DateTimeKind.Local).AddTicks(8150), null, null });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 360, DateTimeKind.Local).AddTicks(8151), null, null });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 360, DateTimeKind.Local).AddTicks(8152), null, null });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 360, DateTimeKind.Local).AddTicks(8154), null, null });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 360, DateTimeKind.Local).AddTicks(8155), null, null });

            migrationBuilder.UpdateData(
                table: "CustomerGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 361, DateTimeKind.Local).AddTicks(3754), null, null });

            migrationBuilder.UpdateData(
                table: "CustomerGroups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 361, DateTimeKind.Local).AddTicks(3795), null, null });

            migrationBuilder.UpdateData(
                table: "CustomerGroups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 361, DateTimeKind.Local).AddTicks(3797), null, null });

            migrationBuilder.UpdateData(
                table: "CustomerGroups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 361, DateTimeKind.Local).AddTicks(3798), null, null });

            migrationBuilder.UpdateData(
                table: "CustomerGroups",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 361, DateTimeKind.Local).AddTicks(3800), null, null });

            migrationBuilder.UpdateData(
                table: "MetalPurities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 361, DateTimeKind.Local).AddTicks(6617), null, null });

            migrationBuilder.UpdateData(
                table: "MetalPurities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 361, DateTimeKind.Local).AddTicks(6622), null, null });

            migrationBuilder.UpdateData(
                table: "MetalPurities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 361, DateTimeKind.Local).AddTicks(6623), null, null });

            migrationBuilder.UpdateData(
                table: "MetalPurities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 361, DateTimeKind.Local).AddTicks(6624), null, null });

            migrationBuilder.UpdateData(
                table: "MetalTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 361, DateTimeKind.Local).AddTicks(9522), null, null });

            migrationBuilder.UpdateData(
                table: "MetalTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 361, DateTimeKind.Local).AddTicks(9527), null, null });

            migrationBuilder.UpdateData(
                table: "MetalTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 361, DateTimeKind.Local).AddTicks(9528), null, null });

            migrationBuilder.UpdateData(
                table: "MetalTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 361, DateTimeKind.Local).AddTicks(9530), null, null });

            migrationBuilder.UpdateData(
                table: "MetalTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 361, DateTimeKind.Local).AddTicks(9531), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8290), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8317), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8318), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8319), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8320), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8321), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8323), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8324), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8325), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8326), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8327), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8328), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8329), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8330), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8332), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8344), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8345), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8346), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8348), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8349), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8350), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8351), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8352), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8353), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8354), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8355), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8357), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8358), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8359), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8360), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8361), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8362), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8363), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8364), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8375), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8376), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8377), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8378), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8379), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8380), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8382), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8383), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8384), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8385), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8386), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8387), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8388), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8389), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8391), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8392), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8393), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8394), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8395), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8404), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8405), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8406), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8408), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8409), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8410), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8411), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8412), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8413), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8414), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8415), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8420), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8451), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8453), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8454), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8455), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8456), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8457), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8458), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8460), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8469), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8471), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8472), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8473), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8474), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8475), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8476), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8478), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8479), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8480), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8481), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8482), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8483), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8484), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8485), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8486), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8488), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8489), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8490), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8500), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8501), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8502), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8503), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8504), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8505), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8506), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8507), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8509), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8510), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8511), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8512), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8513), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8514), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8515), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8516), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8518), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8519), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8520), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8529), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8530), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8531), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8533), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8534), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8535), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8536), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8537), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8538), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8539), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8541), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8542), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8543), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8544), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8545), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8546), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8547), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8549), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8550), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8558), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8559), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8561), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8562), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8563), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8564), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8565), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8566), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8567), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8568), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8570), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8571), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8575), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8576), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8577), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8578), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8579), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8581), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8582), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8592), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8593), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8594), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8595), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8596), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8598), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8599), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8600), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8601), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8602), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8603), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8604), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8605), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8607), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8608), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8609), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8610), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8611), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8633), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8642), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8644), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8645), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8646), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8647), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8648), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8649), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8652), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8654), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8655), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8656), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8657), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8658), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8659), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8660), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8661), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8662), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8664), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8665), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8673), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8674), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8675), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8676), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8677), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8679), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8680), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8681), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8682), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8683), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8684), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8685), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8687), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8688), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8689), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8690), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8691), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8692), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8693), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8694), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8704), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8705), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8706), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8707), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8708), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8709), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8710), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8712), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8713), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8714), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8715), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8716), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8717), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8718), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8719), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8721), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8722), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8723), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8724), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8733), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8734), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8735), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8736), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8737), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8738), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8739), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8740), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8742), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8743), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8744), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8745), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8746), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8747), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8748), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8749), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8751), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8752), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8753), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8762), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8764), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8765), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8766), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8767), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8768), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8769), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8770), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8772), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8773), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8774), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8775), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8776), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8777), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8778), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8779), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8781), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8782), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8783), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8792), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8793), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8794), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8795), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8797), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8798), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8823), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8824), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8825), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8826), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8827), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8828), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8829), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8831), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8832), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8833), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8834), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8835), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8836), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8845), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8846), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8847), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8848), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8850), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8851), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8852), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8853), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8854), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8855), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8856), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8857), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8859), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8860), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8861), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8862), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8863), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8864), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8865), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8873), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8874), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8876), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8877), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8878), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8879), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8880), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8881), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8882), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8884), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8888), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8889), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8890), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8892), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8893), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8894), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8895), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8896), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8897), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8906), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8907), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8908), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8909), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8910), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8911), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8912), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8914), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8915), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8916), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8917), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8918), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8919), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8920), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8921), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8923), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8924), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8925), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8926), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8927), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8937), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8938), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8939), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8940), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8941), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8942), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8943), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8944), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8946), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8947), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8948), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8949), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8950), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8951), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8952), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8953), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8954), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8956), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8957), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8966), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8967), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8973), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8974), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8975), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8976), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8977), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8978), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8979), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8981), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8982), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8983), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8998), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(8999), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9000), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9002), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9003), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9004), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9005), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9015), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9016), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9017), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9018), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9019), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9021), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9022), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9023), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9024), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9025), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9026), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9027), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9028), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9029), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9031), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9032), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9033), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9034), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9035), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9050), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9051), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9052), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9053), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9054), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9055), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9057), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9058), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9059), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9060), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9061), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9062), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9063), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9064), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9066), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9067), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9068), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9069), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9070), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9079), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9080), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9081), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9083), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9084), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9085), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9086), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9087), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9088), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9089), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9091), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9092), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9093), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9094), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9095), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9096), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9097), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9098), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9100), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9109), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9111), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9112), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9113), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9114), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9115), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9116), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9121), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9122), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9123), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9124), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9126), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9127), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9128), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9129), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9130), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9131), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9132), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9133), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9135), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9136), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9137), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9138), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9139), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9140), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9141), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9142), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9144), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9145), null, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 383, DateTimeKind.Local).AddTicks(9146), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2011), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2036), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2104), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2107), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2109), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2111), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2112), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2114), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2116), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2118), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2120), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2122), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2124), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2125), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2127), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2138), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2140), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2142), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2144), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2146), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2147), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2152), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2188), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2190), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2192), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2194), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2195), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2197), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2199), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2210), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2212), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2214), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2216), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2217), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2219), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2221), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2223), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2225), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2227), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2229), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2233), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2256), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2258), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2269), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2271), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2273), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2274), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2276), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2278), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2280), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2282), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2284), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2285), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2287), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2289), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2291), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2302), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2305), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2306), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2308), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2313), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2337), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2339), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2341), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2343), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2344), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2346), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2348), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2350), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2352), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2362), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2365), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2366), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2368), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2370), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2372), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2374), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2376), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2377), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2379), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2381), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2408), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2410), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2412), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2423), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2425), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2427), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2428), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2430), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2432), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2434), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2436), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2438), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2439), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2441), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2443), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2445), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2447), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2457), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2458), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2483), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2485), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2487), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2489), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2490), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2492), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2494), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2496), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2498), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2500), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2501), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2504), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2514), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2516), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2518), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2520), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2521), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2523), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2525), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2527), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2552), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2554), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2556), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2558), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2559), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2570), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2572), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2574), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2576), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2578), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2579), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2581), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2583), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2585), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2587), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2589), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2591), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2592), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2594), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2605), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2624), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2625), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2627), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2629), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2631), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2633), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2635), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2637), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2638), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2640), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2642), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2644), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2646), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2657), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2659), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2661), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2663), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2665), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2666), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2703), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2705), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2707), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2709), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2711), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2713), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2714), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2716), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2726), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2728), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2730), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2731), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2733), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2735), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2737), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2739), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2741), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2742), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2744), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2746), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2781), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2791), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2793), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2795), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2797), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2799), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2801), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2803), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2805), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2806), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2808), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2810), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2812), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2814), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2815), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2818), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2819), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2821), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2823), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2846), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2848), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2850), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2851), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 370, DateTimeKind.Local).AddTicks(2856), null, null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 384, DateTimeKind.Local).AddTicks(4096), null, null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 384, DateTimeKind.Local).AddTicks(4106), null, null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 384, DateTimeKind.Local).AddTicks(4108), null, null });

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 384, DateTimeKind.Local).AddTicks(7947), null, null });

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 384, DateTimeKind.Local).AddTicks(7953), null, null });

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 384, DateTimeKind.Local).AddTicks(7954), null, null });

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 384, DateTimeKind.Local).AddTicks(7956), null, null });

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 384, DateTimeKind.Local).AddTicks(7957), null, null });

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 384, DateTimeKind.Local).AddTicks(7960), null, null });

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 384, DateTimeKind.Local).AddTicks(7961), null, null });

            migrationBuilder.UpdateData(
                table: "StoneClarities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 384, DateTimeKind.Local).AddTicks(7962), null, null });

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(2074), null, null });

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(2080), null, null });

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(2081), null, null });

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(2082), null, null });

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(2083), null, null });

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(2084), null, null });

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(2085), null, null });

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(2086), null, null });

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(2087), null, null });

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(2088), null, null });

            migrationBuilder.UpdateData(
                table: "StoneCuts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(2089), null, null });

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(5426), null, null });

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(5432), null, null });

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(5433), null, null });

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(5434), null, null });

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(5435), null, null });

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(5436), null, null });

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(5437), null, null });

            migrationBuilder.UpdateData(
                table: "StoneTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(5438), null, null });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(8459), null, null });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(8465), null, null });

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifyDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 385, DateTimeKind.Local).AddTicks(8466), null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastName", "ModifyDate", "SubscriptionEndDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 391, DateTimeKind.Local).AddTicks(588), "Kavalcı", null, null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifyDate", "SubscriptionEndDate", "UserId" },
                values: new object[] { new DateTime(2026, 5, 17, 6, 2, 20, 391, DateTimeKind.Local).AddTicks(1540), null, null, null });
        }
    }
}

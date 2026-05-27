using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KatalogApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
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
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubscriptionEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsLocked = table.Column<bool>(type: "bit", nullable: false),
                    CustomerGroupId = table.Column<int>(type: "int", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    RolesId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_CustomerGroups_CustomerGroupId",
                        column: x => x.CustomerGroupId,
                        principalTable: "CustomerGroups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Stones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    UnitsId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QuantityUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Clarity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Carat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: true),
                    ColorsId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stones_Colors_ColorsId",
                        column: x => x.ColorsId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stones_Units_UnitsId",
                        column: x => x.UnitsId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gram = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Karat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiamondCarat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    StoneId = table.Column<int>(type: "int", nullable: true),
                    ColorId = table.Column<int>(type: "int", nullable: true),
                    ColorsId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Colors_ColorsId",
                        column: x => x.ColorsId,
                        principalTable: "Colors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Stones_StoneId",
                        column: x => x.StoneId,
                        principalTable: "Stones",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductMetals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    MetalType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Purity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMetals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductMetals_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductPrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CustomerGroupId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductPrices_CustomerGroups_CustomerGroupId",
                        column: x => x.CustomerGroupId,
                        principalTable: "CustomerGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductPrices_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "ModifyDate", "Name", "ParentId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 5, 38, 8, 431, DateTimeKind.Local).AddTicks(2573), "Bileklik Kategorisi", false, null, "BİLEKLİK", null, null },
                    { 2, new DateTime(2026, 5, 17, 5, 38, 8, 432, DateTimeKind.Local).AddTicks(5480), "Kelepçe Kategorisi", false, null, "KELEPÇE", null, null },
                    { 3, new DateTime(2026, 5, 17, 5, 38, 8, 432, DateTimeKind.Local).AddTicks(5492), "Kolye Kategorisi", false, null, "KOLYE", null, null },
                    { 4, new DateTime(2026, 5, 17, 5, 38, 8, 432, DateTimeKind.Local).AddTicks(5494), "Küpe Kategorisi", false, null, "KÜPE", null, null },
                    { 5, new DateTime(2026, 5, 17, 5, 38, 8, 432, DateTimeKind.Local).AddTicks(5495), "Pırlanta Kategorisi", false, null, "PIRLANTA", null, null },
                    { 6, new DateTime(2026, 5, 17, 5, 38, 8, 432, DateTimeKind.Local).AddTicks(5496), "Set Kategorisi", false, null, "SET", null, null },
                    { 7, new DateTime(2026, 5, 17, 5, 38, 8, 432, DateTimeKind.Local).AddTicks(5498), "Yüzük Kategorisi", false, null, "YÜZÜK", null, null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "ModifyDate", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(6212), false, null, "SystemAdmin", null },
                    { 2, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(6225), false, null, "Admin", null },
                    { 3, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(6226), false, null, "Customer", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CompanyName", "CreatedDate", "CustomerGroupId", "Email", "FirstName", "IsDeleted", "IsLocked", "LastName", "ModifyDate", "Password", "PhoneNumber", "RoleId", "RolesId", "SubscriptionEndDate", "UserId" },
                values: new object[,]
                {
                    { 1, "", "", new DateTime(2026, 5, 17, 5, 38, 8, 460, DateTimeKind.Local).AddTicks(5681), null, "kuyumhesap@gmail.com", "Mahmut", false, false, "Kavalcı", null, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", "05363956979", 1, null, null, null },
                    { 2, "", "", new DateTime(2026, 5, 17, 5, 38, 8, 460, DateTimeKind.Local).AddTicks(6147), null, "admin@admin.com", "Admin", false, false, "Admin", null, "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", "", 2, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Code", "ColorId", "ColorsId", "CreatedDate", "Description", "DiamondCarat", "Gram", "ImageName", "IsDeleted", "Karat", "ModifyDate", "Name", "StoneId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "DGF26BL00027", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(902), "", 0m, 0m, "BİLEKLİK/DGF26BL00027-1.jpg", false, "14k", null, "DGF26BL00027", null, null },
                    { 2, 1, "DGF26BL00035", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(922), "", 0m, 0m, "BİLEKLİK/DGF26BL00035-2.jpg", false, "14k", null, "DGF26BL00035", null, null },
                    { 3, 1, "DGF26BL00038", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(924), "", 0m, 0m, "BİLEKLİK/DGF26BL00038-2.jpg", false, "14k", null, "DGF26BL00038", null, null },
                    { 4, 1, "DGF26BL00054", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(926), "", 0m, 0m, "BİLEKLİK/DGF26BL00054-2.jpg", false, "14k", null, "DGF26BL00054", null, null },
                    { 5, 1, "DGF26BL00055", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(927), "", 0m, 0m, "BİLEKLİK/DGF26BL00055-2.jpg", false, "14k", null, "DGF26BL00055", null, null },
                    { 6, 1, "DGF26BL00066", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(929), "", 0m, 0m, "BİLEKLİK/DGF26BL00066-2.jpg", false, "14k", null, "DGF26BL00066", null, null },
                    { 7, 1, "DGF26BL00067", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(945), "", 0m, 0m, "BİLEKLİK/DGF26BL00067-2.jpg", false, "14k", null, "DGF26BL00067", null, null },
                    { 8, 1, "DGF26BL00068", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(947), "", 0m, 0m, "BİLEKLİK/DGF26BL00068-2.jpg", false, "14k", null, "DGF26BL00068", null, null },
                    { 9, 1, "DGF26BL00069", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(949), "", 0m, 0m, "BİLEKLİK/DGF26BL00069-2.jpg", false, "14k", null, "DGF26BL00069", null, null },
                    { 10, 1, "DGF26BL00070", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(974), "", 0m, 0m, "BİLEKLİK/DGF26BL00070-2.jpg", false, "14k", null, "DGF26BL00070", null, null },
                    { 11, 1, "DGF26BL00071", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(976), "", 0m, 0m, "BİLEKLİK/DGF26BL00071-2.jpg", false, "14k", null, "DGF26BL00071", null, null },
                    { 12, 1, "DGF26BL00072", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(978), "", 0m, 0m, "BİLEKLİK/DGF26BL00072-2.jpg", false, "14k", null, "DGF26BL00072", null, null },
                    { 13, 1, "DGF26BL00073", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(980), "", 0m, 0m, "BİLEKLİK/DGF26BL00073.jpg", false, "14k", null, "DGF26BL00073", null, null },
                    { 14, 1, "DGF26BL00074", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(982), "", 0m, 0m, "BİLEKLİK/DGF26BL00074-3_(2).JPG", false, "14k", null, "DGF26BL00074", null, null },
                    { 15, 1, "DGF26BL00075", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(983), "", 0m, 0m, "BİLEKLİK/DGF26BL00075-3-2_(2).JPG", false, "14k", null, "DGF26BL00075", null, null },
                    { 16, 2, "DGF26BL00031", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(985), "", 0m, 0m, "KELEPÇE/DGF26BL00031-2.jpg", false, "14k", null, "DGF26BL00031", null, null },
                    { 17, 2, "DGF26BZ00013", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(987), "", 0m, 0m, "KELEPÇE/DGF26BZ00013-2.jpg", false, "14k", null, "DGF26BZ00013", null, null },
                    { 18, 2, "DGF26BZ00014", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(988), "", 0m, 0m, "KELEPÇE/DGF26BZ00014-2.jpg", false, "14k", null, "DGF26BZ00014", null, null },
                    { 19, 3, "DGF26KU00089", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(990), "", 0m, 0m, "KOLYE/DGF26KU00089-2.jpg", false, "14k", null, "DGF26KU00089", null, null },
                    { 20, 3, "DGF26KU00205", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(991), "", 0m, 0m, "KOLYE/DGF26KU00205-2.jpg", false, "14k", null, "DGF26KU00205", null, null },
                    { 21, 3, "DGF26KU00206", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1002), "", 0m, 0m, "KOLYE/DGF26KU00206-2.jpg", false, "14k", null, "DGF26KU00206", null, null },
                    { 22, 3, "DGF26KU00207", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1004), "", 0m, 0m, "KOLYE/DGF26KU00207-2.jpg", false, "14k", null, "DGF26KU00207", null, null },
                    { 23, 3, "DGF26KU00208", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1005), "", 0m, 0m, "KOLYE/DGF26KU00208-2.jpg", false, "14k", null, "DGF26KU00208", null, null },
                    { 24, 3, "DGF26KU00226", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1007), "", 0m, 0m, "KOLYE/DGF26KU00226-2.jpg", false, "14k", null, "DGF26KU00226", null, null },
                    { 25, 3, "DGF26KU00227", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1009), "", 0m, 0m, "KOLYE/DGF26KU00227-2.jpg", false, "14k", null, "DGF26KU00227", null, null },
                    { 26, 3, "DGF26KU00231", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1010), "", 0m, 0m, "KOLYE/DGF26KU00231-2.jpg", false, "14k", null, "DGF26KU00231", null, null },
                    { 27, 3, "DGF26KU00237", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1012), "", 0m, 0m, "KOLYE/DGF26KU00237-2.jpg", false, "14k", null, "DGF26KU00237", null, null },
                    { 28, 3, "DGF26KU00256", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1014), "", 0m, 0m, "KOLYE/DGF26KU00256-2.jpg", false, "14k", null, "DGF26KU00256", null, null },
                    { 29, 3, "DGF26KU00269", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1015), "", 0m, 0m, "KOLYE/DGF26KU00269-2.jpg", false, "14k", null, "DGF26KU00269", null, null },
                    { 30, 3, "DGF26KU00327", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1017), "", 0m, 0m, "KOLYE/DGF26KU00327-2.jpg", false, "14k", null, "DGF26KU00327", null, null },
                    { 31, 3, "DGF26KU00328", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1018), "", 0m, 0m, "KOLYE/DGF26KU00328-2.jpg", false, "14k", null, "DGF26KU00328", null, null },
                    { 32, 3, "DGF26KU00336", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1020), "", 0m, 0m, "KOLYE/DGF26KU00336-2.jpg", false, "14k", null, "DGF26KU00336", null, null },
                    { 33, 3, "DGF26KU00347", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1022), "", 0m, 0m, "KOLYE/DGF26KU00347-2.jpg", false, "14k", null, "DGF26KU00347", null, null },
                    { 34, 3, "DGF26KU00348", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1032), "", 0m, 0m, "KOLYE/DGF26KU00348-2.jpg", false, "14k", null, "DGF26KU00348", null, null },
                    { 35, 3, "DGF26KU00349", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1034), "", 0m, 0m, "KOLYE/DGF26KU00349-2.jpg", false, "14k", null, "DGF26KU00349", null, null },
                    { 36, 3, "DGF26KU00350", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1043), "", 0m, 0m, "KOLYE/DGF26KU00350-2.jpg", false, "14k", null, "DGF26KU00350", null, null },
                    { 37, 3, "DGF26KU00353", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1045), "", 0m, 0m, "KOLYE/DGF26KU00353-2.jpg", false, "14k", null, "DGF26KU00353", null, null },
                    { 38, 3, "NAİF13", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1047), "", 0m, 0m, "KOLYE/NAİF13-2.JPG", false, "14k", null, "NAİF13", null, null },
                    { 39, 4, "DGF26KP00128", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1048), "", 0m, 0m, "KÜPE/DGF26KP00128-2.jpg", false, "14k", null, "DGF26KP00128", null, null },
                    { 40, 4, "DGF26KP00142", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1050), "", 0m, 0m, "KÜPE/DGF26KP00142-2.jpg", false, "14k", null, "DGF26KP00142", null, null },
                    { 41, 4, "DGF26KP00143", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1052), "", 0m, 0m, "KÜPE/DGF26KP00143-2.jpg", false, "14k", null, "DGF26KP00143", null, null },
                    { 42, 4, "DGF26KP00144", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1054), "", 0m, 0m, "KÜPE/DGF26KP00144-2.jpg", false, "14k", null, "DGF26KP00144", null, null },
                    { 43, 4, "DGF26KP00152", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1055), "", 0m, 0m, "KÜPE/DGF26KP00152-2.jpg", false, "14k", null, "DGF26KP00152", null, null },
                    { 44, 4, "DGF26KP00153", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1057), "", 0m, 0m, "KÜPE/DGF26KP00153-2.jpg", false, "14k", null, "DGF26KP00153", null, null },
                    { 45, 4, "DGF26KP00154", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1059), "", 0m, 0m, "KÜPE/DGF26KP00154-2.jpg", false, "14k", null, "DGF26KP00154", null, null },
                    { 46, 4, "DGF26KP00155", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1060), "", 0m, 0m, "KÜPE/DGF26KP00155-2.jpg", false, "14k", null, "DGF26KP00155", null, null },
                    { 47, 4, "DGF26KP00156", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1062), "", 0m, 0m, "KÜPE/DGF26KP00156-2.jpg", false, "14k", null, "DGF26KP00156", null, null },
                    { 48, 4, "DGF26KP00157", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1072), "", 0m, 0m, "KÜPE/DGF26KP00157-2.jpg", false, "14k", null, "DGF26KP00157", null, null },
                    { 49, 4, "DGF26KP00158", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1074), "", 0m, 0m, "KÜPE/DGF26KP00158-2.jpg", false, "14k", null, "DGF26KP00158", null, null },
                    { 50, 4, "DGF26KP00160", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1076), "", 0m, 0m, "KÜPE/DGF26KP00160-2.jpg", false, "14k", null, "DGF26KP00160", null, null },
                    { 51, 4, "DGF26KP00161", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1078), "", 0m, 0m, "KÜPE/DGF26KP00161-2.jpg", false, "14k", null, "DGF26KP00161", null, null },
                    { 52, 4, "DGF26KP00162", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1079), "", 0m, 0m, "KÜPE/DGF26KP00162-2.jpg", false, "14k", null, "DGF26KP00162", null, null },
                    { 53, 4, "DGF26KP00164", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1081), "", 0m, 0m, "KÜPE/DGF26KP00164-2.jpg", false, "14k", null, "DGF26KP00164", null, null },
                    { 54, 4, "DGF26KP00165", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1083), "", 0m, 0m, "KÜPE/DGF26KP00165-2.jpg", false, "14k", null, "DGF26KP00165", null, null },
                    { 55, 4, "DGF26KP00166", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1084), "", 0m, 0m, "KÜPE/DGF26KP00166-2.jpg", false, "14k", null, "DGF26KP00166", null, null },
                    { 56, 4, "DGF26KP00167", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1086), "", 0m, 0m, "KÜPE/DGF26KP00167-2.jpg", false, "14k", null, "DGF26KP00167", null, null },
                    { 57, 4, "DGF26KP00169", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1087), "", 0m, 0m, "KÜPE/DGF26KP00169-2.jpg", false, "14k", null, "DGF26KP00169", null, null },
                    { 58, 4, "DGF26KP00170", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1089), "", 0m, 0m, "KÜPE/DGF26KP00170-2.jpg", false, "14k", null, "DGF26KP00170", null, null },
                    { 59, 4, "DGF26KP00171", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1091), "", 0m, 0m, "KÜPE/DGF26KP00171-2.jpg", false, "14k", null, "DGF26KP00171", null, null },
                    { 60, 4, "DGF26KP00172", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1092), "", 0m, 0m, "KÜPE/DGF26KP00172-2.jpg", false, "14k", null, "DGF26KP00172", null, null },
                    { 61, 4, "DGF26KP00173", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1094), "", 0m, 0m, "KÜPE/DGF26KP00173-2.jpg", false, "14k", null, "DGF26KP00173", null, null },
                    { 62, 4, "DGF26KP00175", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1117), "", 0m, 0m, "KÜPE/DGF26KP00175-2.jpg", false, "14k", null, "DGF26KP00175", null, null },
                    { 63, 4, "DGF26KP00176", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1119), "", 0m, 0m, "KÜPE/DGF26KP00176-2.jpg", false, "14k", null, "DGF26KP00176", null, null },
                    { 64, 4, "DGF26KP00178", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1121), "", 0m, 0m, "KÜPE/DGF26KP00178-2.jpg", false, "14k", null, "DGF26KP00178", null, null },
                    { 65, 4, "DGF26KP00184", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1122), "", 0m, 0m, "KÜPE/DGF26KP00184-2.jpg", false, "14k", null, "DGF26KP00184", null, null },
                    { 66, 4, "DGF26KP00186", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1124), "", 0m, 0m, "KÜPE/DGF26KP00186-2.jpg", false, "14k", null, "DGF26KP00186", null, null },
                    { 67, 4, "DGF26KP00189", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1126), "", 0m, 0m, "KÜPE/DGF26KP00189-2.jpg", false, "14k", null, "DGF26KP00189", null, null },
                    { 68, 4, "DGF26KP00215", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1127), "", 0m, 0m, "KÜPE/DGF26KP00215-2.jpg", false, "14k", null, "DGF26KP00215", null, null },
                    { 69, 4, "DGF26KP00218", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1129), "", 0m, 0m, "KÜPE/DGF26KP00218-2.jpg", false, "14k", null, "DGF26KP00218", null, null },
                    { 70, 4, "DGF26KP00219", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1131), "", 0m, 0m, "KÜPE/DGF26KP00219-3.JPG", false, "14k", null, "DGF26KP00219", null, null },
                    { 71, 4, "DGF26KP00231", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1132), "", 0m, 0m, "KÜPE/DGF26KP00231-2.jpg", false, "14k", null, "DGF26KP00231", null, null },
                    { 72, 4, "DGF26KP00232", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1134), "", 0m, 0m, "KÜPE/DGF26KP00232-2.jpg", false, "14k", null, "DGF26KP00232", null, null },
                    { 73, 4, "DGF26KP00236", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1136), "", 0m, 0m, "KÜPE/DGF26KP00236-2.jpg", false, "14k", null, "DGF26KP00236", null, null },
                    { 74, 4, "DGF26KP00244", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1137), "", 0m, 0m, "KÜPE/DGF26KP00244-2.jpg", false, "14k", null, "DGF26KP00244", null, null },
                    { 75, 4, "DGF26KP00264", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1139), "", 0m, 0m, "KÜPE/DGF26KP00264-2.jpg", false, "14k", null, "DGF26KP00264", null, null },
                    { 76, 4, "DGF26KP00266", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1149), "", 0m, 0m, "KÜPE/DGF26KP00266-2.jpg", false, "14k", null, "DGF26KP00266", null, null },
                    { 77, 4, "DGF26KP00267", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1151), "", 0m, 0m, "KÜPE/DGF26KP00267-2.jpg", false, "14k", null, "DGF26KP00267", null, null },
                    { 78, 4, "DGF26KP00269", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1153), "", 0m, 0m, "KÜPE/DGF26KP00269-2.jpg", false, "14k", null, "DGF26KP00269", null, null },
                    { 79, 4, "DGF26KP00270", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1154), "", 0m, 0m, "KÜPE/DGF26KP00270-2.jpg", false, "14k", null, "DGF26KP00270", null, null },
                    { 80, 4, "DGF26KP00271", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1156), "", 0m, 0m, "KÜPE/DGF26KP00271-2.jpg", false, "14k", null, "DGF26KP00271", null, null },
                    { 81, 4, "DGF26KP00295", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1158), "", 0m, 0m, "KÜPE/DGF26KP00295-2.jpg", false, "14k", null, "DGF26KP00295", null, null },
                    { 82, 4, "DGF26KP00296", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1159), "", 0m, 0m, "KÜPE/DGF26KP00296-2.jpg", false, "14k", null, "DGF26KP00296", null, null },
                    { 83, 4, "DGF26KP00297", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1161), "", 0m, 0m, "KÜPE/DGF26KP00297-2.jpg", false, "14k", null, "DGF26KP00297", null, null },
                    { 84, 4, "DGF26KP00305", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1163), "", 0m, 0m, "KÜPE/DGF26KP00305-2.jpg", false, "14k", null, "DGF26KP00305", null, null },
                    { 85, 4, "DGF26KP00315", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1164), "", 0m, 0m, "KÜPE/DGF26KP00315-2.jpg", false, "14k", null, "DGF26KP00315", null, null },
                    { 86, 4, "DGF26KP00316", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1166), "", 0m, 0m, "KÜPE/DGF26KP00316-2.jpg", false, "14k", null, "DGF26KP00316", null, null },
                    { 87, 4, "DGF26KP00319", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1173), "", 0m, 0m, "KÜPE/DGF26KP00319-2.jpg", false, "14k", null, "DGF26KP00319", null, null },
                    { 88, 4, "DGF26KP00320", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1174), "", 0m, 0m, "KÜPE/DGF26KP00320-2.jpg", false, "14k", null, "DGF26KP00320", null, null },
                    { 89, 4, "DGF26KP00321", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1176), "", 0m, 0m, "KÜPE/DGF26KP00321-2.jpg", false, "14k", null, "DGF26KP00321", null, null },
                    { 90, 4, "DGF26KP00322", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1186), "", 0m, 0m, "KÜPE/DGF26KP00322-2.jpg", false, "14k", null, "DGF26KP00322", null, null },
                    { 91, 4, "DGF26KP00323", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1188), "", 0m, 0m, "KÜPE/DGF26KP00323-2.jpg", false, "14k", null, "DGF26KP00323", null, null },
                    { 92, 4, "DGF26KP00324", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1190), "", 0m, 0m, "KÜPE/DGF26KP00324-2.jpg", false, "14k", null, "DGF26KP00324", null, null },
                    { 93, 4, "DGF26KPKP00219", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1195), "", 0m, 0m, "KÜPE/DGF26KPKP00219-2.jpg", false, "14k", null, "DGF26KPKP00219", null, null },
                    { 94, 4, "NAİF11", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1197), "", 0m, 0m, "KÜPE/NAİF11-2.jpg", false, "14k", null, "NAİF11", null, null },
                    { 95, 4, "NAİF12", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1198), "", 0m, 0m, "KÜPE/NAİF12-2.JPG", false, "14k", null, "NAİF12", null, null },
                    { 96, 5, "PIR0007296", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1200), "", 0m, 0m, "PIRLANTA/PIR0007296-3_(2).JPG", false, "14k", null, "PIR0007296", null, null },
                    { 97, 5, "PIR0007297", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1202), "", 0m, 0m, "PIRLANTA/PIR0007297-3_(2).JPG", false, "14k", null, "PIR0007297", null, null },
                    { 98, 5, "PIR0007298", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1203), "", 0m, 0m, "PIRLANTA/PIR0007298-3_(2).JPG", false, "14k", null, "PIR0007298", null, null },
                    { 99, 5, "PIR0007299", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1205), "", 0m, 0m, "PIRLANTA/PIR0007299-3_(2).JPG", false, "14k", null, "PIR0007299", null, null },
                    { 100, 5, "PIR0007300", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1207), "", 0m, 0m, "PIRLANTA/PIR0007300.jpg", false, "14k", null, "PIR0007300", null, null },
                    { 101, 5, "PIR0007301", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1208), "", 0m, 0m, "PIRLANTA/PIR0007301.jpg", false, "14k", null, "PIR0007301", null, null },
                    { 102, 5, "PIR0007302", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1210), "", 0m, 0m, "PIRLANTA/PIR0007302.jpg", false, "14k", null, "PIR0007302", null, null },
                    { 103, 5, "PIR0007308", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1218), "", 0m, 0m, "PIRLANTA/PIR0007308-3_(2).JPG", false, "14k", null, "PIR0007308", null, null },
                    { 104, 5, "PIR0007318", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1220), "", 0m, 0m, "PIRLANTA/PIR0007318.jpg", false, "14k", null, "PIR0007318", null, null },
                    { 105, 5, "PIR0007319", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1222), "", 0m, 0m, "PIRLANTA/PIR0007319-2.jpg", false, "14k", null, "PIR0007319", null, null },
                    { 106, 6, "NAİF1", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1223), "", 0m, 0m, "SET/NAİF1-2.jpg", false, "14k", null, "NAİF1", null, null },
                    { 107, 7, "DGF26YZ00145", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1225), "", 0m, 0m, "YÜZÜK/DGF26YZ00145.jpg", false, "14k", null, "DGF26YZ00145", null, null },
                    { 108, 7, "DGF26YZ00321", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1227), "", 0m, 0m, "YÜZÜK/DGF26YZ00321.jpg", false, "14k", null, "DGF26YZ00321", null, null },
                    { 109, 7, "DGF26YZ00335", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1228), "", 0m, 0m, "YÜZÜK/DGF26YZ00335-3_(2).JPG", false, "14k", null, "DGF26YZ00335", null, null },
                    { 110, 7, "DGF26YZ00336", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1230), "", 0m, 0m, "YÜZÜK/DGF26YZ00336-3_(2).JPG", false, "14k", null, "DGF26YZ00336", null, null },
                    { 111, 7, "DGF26YZ00339", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1232), "", 0m, 0m, "YÜZÜK/DGF26YZ00339-3_(2).JPG", false, "14k", null, "DGF26YZ00339", null, null },
                    { 112, 7, "DGF26YZ00340", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1234), "", 0m, 0m, "YÜZÜK/DGF26YZ00340-3_(2).JPG", false, "14k", null, "DGF26YZ00340", null, null },
                    { 113, 7, "DGF26YZ00341", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1241), "", 0m, 0m, "YÜZÜK/DGF26YZ00341-3_(2).JPG", false, "14k", null, "DGF26YZ00341", null, null },
                    { 114, 7, "DGF26YZ00372", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1243), "", 0m, 0m, "YÜZÜK/DGF26YZ00372-3_(2).JPG", false, "14k", null, "DGF26YZ00372", null, null },
                    { 115, 7, "DGF26YZ00376", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1244), "", 0m, 0m, "YÜZÜK/DGF26YZ00376-3_(2).JPG", false, "14k", null, "DGF26YZ00376", null, null },
                    { 116, 7, "DGF26YZ00378", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1246), "", 0m, 0m, "YÜZÜK/DGF26YZ00378-3_(2).JPG", false, "14k", null, "DGF26YZ00378", null, null },
                    { 117, 7, "DGF26YZ00379", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1254), "", 0m, 0m, "YÜZÜK/DGF26YZ00379-3_(2).JPG", false, "14k", null, "DGF26YZ00379", null, null },
                    { 118, 7, "DGF26YZ00380", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1256), "", 0m, 0m, "YÜZÜK/DGF26YZ00380-3_(2).JPG", false, "14k", null, "DGF26YZ00380", null, null },
                    { 119, 7, "DGF26YZ00381", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1258), "", 0m, 0m, "YÜZÜK/DGF26YZ00381-3_(2).JPG", false, "14k", null, "DGF26YZ00381", null, null },
                    { 120, 7, "DGF26YZ00411", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1260), "", 0m, 0m, "YÜZÜK/DGF26YZ00411-3_(2).JPG", false, "14k", null, "DGF26YZ00411", null, null },
                    { 121, 7, "DGF26YZ00412", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1261), "", 0m, 0m, "YÜZÜK/DGF26YZ00412-3_(2).JPG", false, "14k", null, "DGF26YZ00412", null, null },
                    { 122, 7, "DGF26YZ00426", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1263), "", 0m, 0m, "YÜZÜK/DGF26YZ00426.jpg", false, "14k", null, "DGF26YZ00426", null, null },
                    { 123, 7, "DGF26YZ00449", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1265), "", 0m, 0m, "YÜZÜK/DGF26YZ00449-3_(2).JPG", false, "14k", null, "DGF26YZ00449", null, null },
                    { 124, 7, "DGF26YZ00451", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1266), "", 0m, 0m, "YÜZÜK/DGF26YZ00451-3_(2).JPG", false, "14k", null, "DGF26YZ00451", null, null },
                    { 125, 7, "DGF26YZ00452", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1268), "", 0m, 0m, "YÜZÜK/DGF26YZ00452-3_(2).JPG", false, "14k", null, "DGF26YZ00452", null, null },
                    { 126, 7, "DGF26YZ00453", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1273), "", 0m, 0m, "YÜZÜK/DGF26YZ00453-3_(2).JPG", false, "14k", null, "DGF26YZ00453", null, null },
                    { 127, 7, "DGF26YZ00454", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1275), "", 0m, 0m, "YÜZÜK/DGF26YZ00454-3_(2).JPG", false, "14k", null, "DGF26YZ00454", null, null },
                    { 128, 7, "DGF26YZ00455", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1276), "", 0m, 0m, "YÜZÜK/DGF26YZ00455-3_(2).JPG", false, "14k", null, "DGF26YZ00455", null, null },
                    { 129, 7, "DGF26YZ00456", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1278), "", 0m, 0m, "YÜZÜK/DGF26YZ00456-3_(2).JPG", false, "14k", null, "DGF26YZ00456", null, null },
                    { 130, 7, "DGF26YZ00457", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1280), "", 0m, 0m, "YÜZÜK/DGF26YZ00457-3_(2).JPG", false, "14k", null, "DGF26YZ00457", null, null },
                    { 131, 7, "DGF26YZ00458", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1290), "", 0m, 0m, "YÜZÜK/DGF26YZ00458-3_(2).JPG", false, "14k", null, "DGF26YZ00458", null, null },
                    { 132, 7, "DGF26YZ00459", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1293), "", 0m, 0m, "YÜZÜK/DGF26YZ00459-3_(2).JPG", false, "14k", null, "DGF26YZ00459", null, null },
                    { 133, 7, "DGF26YZ00461", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1294), "", 0m, 0m, "YÜZÜK/DGF26YZ00461-3_(2).JPG", false, "14k", null, "DGF26YZ00461", null, null },
                    { 134, 7, "DGF26YZ00462", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1296), "", 0m, 0m, "YÜZÜK/DGF26YZ00462-3_(2).JPG", false, "14k", null, "DGF26YZ00462", null, null },
                    { 135, 7, "DGF26YZ00463", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1297), "", 0m, 0m, "YÜZÜK/DGF26YZ00463-3_(2).JPG", false, "14k", null, "DGF26YZ00463", null, null },
                    { 136, 7, "DGF26YZ00464", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1299), "", 0m, 0m, "YÜZÜK/DGF26YZ00464-3_(2).JPG", false, "14k", null, "DGF26YZ00464", null, null },
                    { 137, 7, "DGF26YZ00474", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1301), "", 0m, 0m, "YÜZÜK/DGF26YZ00474.jpg", false, "14k", null, "DGF26YZ00474", null, null },
                    { 138, 7, "DGF26YZ00475", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1302), "", 0m, 0m, "YÜZÜK/DGF26YZ00475.jpg", false, "14k", null, "DGF26YZ00475", null, null },
                    { 139, 7, "DGF26YZ00479", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1310), "", 0m, 0m, "YÜZÜK/DGF26YZ00479.jpg", false, "14k", null, "DGF26YZ00479", null, null },
                    { 140, 7, "DGF26YZ00511", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1313), "", 0m, 0m, "YÜZÜK/DGF26YZ00511-3_(2).JPG", false, "14k", null, "DGF26YZ00511", null, null },
                    { 141, 7, "DGF26YZ00516", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1315), "", 0m, 0m, "YÜZÜK/DGF26YZ00516-3_(2).JPG", false, "14k", null, "DGF26YZ00516", null, null },
                    { 142, 7, "DGF26YZ00517", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1317), "", 0m, 0m, "YÜZÜK/DGF26YZ00517-3_(2).JPG", false, "14k", null, "DGF26YZ00517", null, null },
                    { 143, 7, "DGF26YZ00520", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1320), "", 0m, 0m, "YÜZÜK/DGF26YZ00520-3_(2).JPG", false, "14k", null, "DGF26YZ00520", null, null },
                    { 144, 7, "DGF26YZ00521", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1322), "", 0m, 0m, "YÜZÜK/DGF26YZ00521-3_(2).JPG", false, "14k", null, "DGF26YZ00521", null, null },
                    { 145, 7, "DGF26YZ00522", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1333), "", 0m, 0m, "YÜZÜK/DGF26YZ00522-3_(2).JPG", false, "14k", null, "DGF26YZ00522", null, null },
                    { 146, 7, "DGF26YZ00523", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1335), "", 0m, 0m, "YÜZÜK/DGF26YZ00523-3_(2).JPG", false, "14k", null, "DGF26YZ00523", null, null },
                    { 147, 7, "DGF26YZ00524", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1336), "", 0m, 0m, "YÜZÜK/DGF26YZ00524-3_(2).JPG", false, "14k", null, "DGF26YZ00524", null, null },
                    { 148, 7, "DGF26YZ00525", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1338), "", 0m, 0m, "YÜZÜK/DGF26YZ00525-3_(2).JPG", false, "14k", null, "DGF26YZ00525", null, null },
                    { 149, 7, "DGF26YZ00526", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1340), "", 0m, 0m, "YÜZÜK/DGF26YZ00526-3_(2).JPG", false, "14k", null, "DGF26YZ00526", null, null },
                    { 150, 7, "DGF26YZ00527", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1342), "", 0m, 0m, "YÜZÜK/DGF26YZ00527-3_(2).JPG", false, "14k", null, "DGF26YZ00527", null, null },
                    { 151, 7, "DGF26YZ00530", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1344), "", 0m, 0m, "YÜZÜK/DGF26YZ00530-3_(2).JPG", false, "14k", null, "DGF26YZ00530", null, null },
                    { 152, 7, "DGF26YZ00535", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1352), "", 0m, 0m, "YÜZÜK/DGF26YZ00535-3_(2).JPG", false, "14k", null, "DGF26YZ00535", null, null },
                    { 153, 7, "DGF26YZ00537", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1354), "", 0m, 0m, "YÜZÜK/DGF26YZ00537-3_(2).JPG", false, "14k", null, "DGF26YZ00537", null, null },
                    { 154, 7, "DGF26YZ00538", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1356), "", 0m, 0m, "YÜZÜK/DGF26YZ00538-3_(2).JPG", false, "14k", null, "DGF26YZ00538", null, null },
                    { 155, 7, "DGF26YZ00539", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1357), "", 0m, 0m, "YÜZÜK/DGF26YZ00539-3_(2).JPG", false, "14k", null, "DGF26YZ00539", null, null },
                    { 156, 7, "DGF26YZ00540", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1359), "", 0m, 0m, "YÜZÜK/DGF26YZ00540-3_(2).JPG", false, "14k", null, "DGF26YZ00540", null, null },
                    { 157, 7, "DGF26YZ00541", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1360), "", 0m, 0m, "YÜZÜK/DGF26YZ00541-3_(2).JPG", false, "14k", null, "DGF26YZ00541", null, null },
                    { 158, 7, "DGF26YZ00542", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1362), "", 0m, 0m, "YÜZÜK/DGF26YZ00542-3_(2).JPG", false, "14k", null, "DGF26YZ00542", null, null },
                    { 159, 7, "DGF26YZ00544", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1371), "", 0m, 0m, "YÜZÜK/DGF26YZ00544-3_(2).JPG", false, "14k", null, "DGF26YZ00544", null, null },
                    { 160, 7, "DGF26YZ00545", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1373), "", 0m, 0m, "YÜZÜK/DGF26YZ00545-3_(2).JPG", false, "14k", null, "DGF26YZ00545", null, null },
                    { 161, 7, "DGF26YZ00553", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1375), "", 0m, 0m, "YÜZÜK/DGF26YZ00553.jpg", false, "14k", null, "DGF26YZ00553", null, null },
                    { 162, 7, "DGF26YZ00554", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1376), "", 0m, 0m, "YÜZÜK/DGF26YZ00554-3_(2).JPG", false, "14k", null, "DGF26YZ00554", null, null },
                    { 163, 7, "DGF26YZ00555", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1378), "", 0m, 0m, "YÜZÜK/DGF26YZ00555-3_(2).JPG", false, "14k", null, "DGF26YZ00555", null, null },
                    { 164, 7, "DGF26YZ00556", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1386), "", 0m, 0m, "YÜZÜK/DGF26YZ00556-3_(2).JPG", false, "14k", null, "DGF26YZ00556", null, null },
                    { 165, 7, "DGF26YZ00557", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1388), "", 0m, 0m, "YÜZÜK/DGF26YZ00557-3_(2).JPG", false, "14k", null, "DGF26YZ00557", null, null },
                    { 166, 7, "DGF26YZ00558", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1389), "", 0m, 0m, "YÜZÜK/DGF26YZ00558-3_(2).JPG", false, "14k", null, "DGF26YZ00558", null, null },
                    { 167, 7, "DGF26YZ00559", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1391), "", 0m, 0m, "YÜZÜK/DGF26YZ00559-3_(2).JPG", false, "14k", null, "DGF26YZ00559", null, null },
                    { 168, 7, "DGF26YZ00560JPG", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1393), "", 0m, 0m, "YÜZÜK/DGF26YZ00560JPG-3_(2).JPG", false, "14k", null, "DGF26YZ00560JPG", null, null },
                    { 169, 7, "DGF26YZ00570", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1394), "", 0m, 0m, "YÜZÜK/DGF26YZ00570-3_(2).JPG", false, "14k", null, "DGF26YZ00570", null, null },
                    { 170, 7, "DGF26YZ00571", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1396), "", 0m, 0m, "YÜZÜK/DGF26YZ00571-3_(2).JPG", false, "14k", null, "DGF26YZ00571", null, null },
                    { 171, 7, "DGF26YZ00572", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1397), "", 0m, 0m, "YÜZÜK/DGF26YZ00572-3_(2).JPG", false, "14k", null, "DGF26YZ00572", null, null },
                    { 172, 7, "DGF26YZ00574", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1408), "", 0m, 0m, "YÜZÜK/DGF26YZ00574.jpg", false, "14k", null, "DGF26YZ00574", null, null },
                    { 173, 7, "DGF26YZ00575", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1409), "", 0m, 0m, "YÜZÜK/DGF26YZ00575.jpg", false, "14k", null, "DGF26YZ00575", null, null },
                    { 174, 7, "DGF26YZ00576", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1411), "", 0m, 0m, "YÜZÜK/DGF26YZ00576-3_(2).JPG", false, "14k", null, "DGF26YZ00576", null, null },
                    { 175, 7, "DGF26YZ00577", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1413), "", 0m, 0m, "YÜZÜK/DGF26YZ00577.jpg", false, "14k", null, "DGF26YZ00577", null, null },
                    { 176, 7, "DGF26YZ00578", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1414), "", 0m, 0m, "YÜZÜK/DGF26YZ00578-3_(2).JPG", false, "14k", null, "DGF26YZ00578", null, null },
                    { 177, 7, "DGF26YZ00579", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1416), "", 0m, 0m, "YÜZÜK/DGF26YZ00579-3_(2).JPG", false, "14k", null, "DGF26YZ00579", null, null },
                    { 178, 7, "DGF26YZ00580", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1418), "", 0m, 0m, "YÜZÜK/DGF26YZ00580.jpg", false, "14k", null, "DGF26YZ00580", null, null },
                    { 179, 7, "DGF26YZ00581", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1419), "", 0m, 0m, "YÜZÜK/DGF26YZ00581.jpg", false, "14k", null, "DGF26YZ00581", null, null },
                    { 180, 7, "DGF26YZ00584", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1421), "", 0m, 0m, "YÜZÜK/DGF26YZ00584-3_(2).JPG", false, "14k", null, "DGF26YZ00584", null, null },
                    { 181, 7, "DGF26YZ00585", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1423), "", 0m, 0m, "YÜZÜK/DGF26YZ00585-3_(2).JPG", false, "14k", null, "DGF26YZ00585", null, null },
                    { 182, 7, "DGF26YZ00586", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1424), "", 0m, 0m, "YÜZÜK/DGF26YZ00586-3_(2).JPG", false, "14k", null, "DGF26YZ00586", null, null },
                    { 183, 7, "DGF26YZ00587", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1426), "", 0m, 0m, "YÜZÜK/DGF26YZ00587-3_(2).JPG", false, "14k", null, "DGF26YZ00587", null, null },
                    { 184, 7, "DGF26YZ00588", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1430), "", 0m, 0m, "YÜZÜK/DGF26YZ00588-3_(2).JPG", false, "14k", null, "DGF26YZ00588", null, null },
                    { 185, 7, "DGF26YZ00589", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1432), "", 0m, 0m, "YÜZÜK/DGF26YZ00589-3_(2).JPG", false, "14k", null, "DGF26YZ00589", null, null },
                    { 186, 7, "DGF26YZ00590", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1441), "", 0m, 0m, "YÜZÜK/DGF26YZ00590-3_(2).JPG", false, "14k", null, "DGF26YZ00590", null, null },
                    { 187, 7, "DGF26YZ00591", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1447), "", 0m, 0m, "YÜZÜK/DGF26YZ00591-3_(2).JPG", false, "14k", null, "DGF26YZ00591", null, null },
                    { 188, 7, "NAİF1", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1449), "", 0m, 0m, "YÜZÜK/NAİF1.jpg", false, "14k", null, "NAİF1", null, null },
                    { 189, 7, "NAİF10", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1450), "", 0m, 0m, "YÜZÜK/NAİF10-3.JPG", false, "14k", null, "NAİF10", null, null },
                    { 190, 7, "NAİF2", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1458), "", 0m, 0m, "YÜZÜK/NAİF2-3.JPG", false, "14k", null, "NAİF2", null, null },
                    { 191, 7, "NAİF3", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1460), "", 0m, 0m, "YÜZÜK/NAİF3-3.JPG", false, "14k", null, "NAİF3", null, null },
                    { 192, 7, "NAİF4", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1462), "", 0m, 0m, "YÜZÜK/NAİF4-3.JPG", false, "14k", null, "NAİF4", null, null },
                    { 193, 7, "NAİF5", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1463), "", 0m, 0m, "YÜZÜK/NAİF5-3.JPG", false, "14k", null, "NAİF5", null, null },
                    { 194, 7, "NAİF6", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1465), "", 0m, 0m, "YÜZÜK/NAİF6-3.JPG", false, "14k", null, "NAİF6", null, null },
                    { 195, 7, "NAİF7", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1466), "", 0m, 0m, "YÜZÜK/NAİF7-3.JPG", false, "14k", null, "NAİF7", null, null },
                    { 196, 7, "NAİF8", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1468), "", 0m, 0m, "YÜZÜK/NAİF8-3.JPG", false, "14k", null, "NAİF8", null, null },
                    { 197, 7, "NAİF9", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1470), "", 0m, 0m, "YÜZÜK/NAİF9-3.JPG", false, "14k", null, "NAİF9", null, null },
                    { 198, 7, "NFYZ00001", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1471), "", 0m, 0m, "YÜZÜK/NFYZ00001-3.JPG", false, "14k", null, "NFYZ00001", null, null },
                    { 199, 7, "NFYZ00002", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1473), "", 0m, 0m, "YÜZÜK/NFYZ00002-3.JPG", false, "14k", null, "NFYZ00002", null, null },
                    { 200, 7, "NFYZ00003", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1475), "", 0m, 0m, "YÜZÜK/NFYZ00003-3.JPG", false, "14k", null, "NFYZ00003", null, null },
                    { 201, 7, "NFYZ00004", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1476), "", 0m, 0m, "YÜZÜK/NFYZ00004-3.JPG", false, "14k", null, "NFYZ00004", null, null },
                    { 202, 7, "NFYZ00005", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1478), "", 0m, 0m, "YÜZÜK/NFYZ00005-3.JPG", false, "14k", null, "NFYZ00005", null, null },
                    { 203, 7, "NFYZ00006", null, null, new DateTime(2026, 5, 17, 5, 38, 8, 441, DateTimeKind.Local).AddTicks(1479), "", 0m, 0m, "YÜZÜK/NFYZ00006-3.JPG", false, "14k", null, "NFYZ00006", null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedDate", "ImageName", "IsDeleted", "ModifyDate", "ProductId", "SortOrder", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(386), "BİLEKLİK/DGF26BL00027-1.jpg", false, null, 1, 1, null },
                    { 2, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(413), "BİLEKLİK/DGF26BL00027-3.JPG", false, null, 1, 2, null },
                    { 3, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(414), "BİLEKLİK/DGF26BL00027.jpg", false, null, 1, 3, null },
                    { 4, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(415), "BİLEKLİK/DGF26BL00035-2.jpg", false, null, 2, 1, null },
                    { 5, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(417), "BİLEKLİK/DGF26BL00035-3.JPG", false, null, 2, 2, null },
                    { 6, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(418), "BİLEKLİK/DGF26BL00035.jpg", false, null, 2, 3, null },
                    { 7, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(419), "BİLEKLİK/DGF26BL00038-2.jpg", false, null, 3, 1, null },
                    { 8, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(420), "BİLEKLİK/DGF26BL00038-3.JPG", false, null, 3, 2, null },
                    { 9, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(421), "BİLEKLİK/DGF26BL00038.jpg", false, null, 3, 3, null },
                    { 10, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(434), "BİLEKLİK/DGF26BL00054-2.jpg", false, null, 4, 1, null },
                    { 11, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(436), "BİLEKLİK/DGF26BL00054-3.JPG", false, null, 4, 2, null },
                    { 12, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(437), "BİLEKLİK/DGF26BL00054.jpg", false, null, 4, 3, null },
                    { 13, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(438), "BİLEKLİK/DGF26BL00055-2.jpg", false, null, 5, 1, null },
                    { 14, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(439), "BİLEKLİK/DGF26BL00055-3.JPG", false, null, 5, 2, null },
                    { 15, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(440), "BİLEKLİK/DGF26BL00055.jpg", false, null, 5, 3, null },
                    { 16, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(441), "BİLEKLİK/DGF26BL00066-2.jpg", false, null, 6, 1, null },
                    { 17, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(442), "BİLEKLİK/DGF26BL00066-3.JPG", false, null, 6, 2, null },
                    { 18, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(443), "BİLEKLİK/DGF26BL00066.jpg", false, null, 6, 3, null },
                    { 19, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(444), "BİLEKLİK/DGF26BL00067-2.jpg", false, null, 7, 1, null },
                    { 20, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(445), "BİLEKLİK/DGF26BL00067-3.JPG", false, null, 7, 2, null },
                    { 21, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(446), "BİLEKLİK/DGF26BL00067.jpg", false, null, 7, 3, null },
                    { 22, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(447), "BİLEKLİK/DGF26BL00068-2.jpg", false, null, 8, 1, null },
                    { 23, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(448), "BİLEKLİK/DGF26BL00068-3.JPG", false, null, 8, 2, null },
                    { 24, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(449), "BİLEKLİK/DGF26BL00068.jpg", false, null, 8, 3, null },
                    { 25, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(450), "BİLEKLİK/DGF26BL00069-2.jpg", false, null, 9, 1, null },
                    { 26, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(451), "BİLEKLİK/DGF26BL00069-3.JPG", false, null, 9, 2, null },
                    { 27, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(452), "BİLEKLİK/DGF26BL00069.jpg", false, null, 9, 3, null },
                    { 28, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(453), "BİLEKLİK/DGF26BL00070-2.jpg", false, null, 10, 1, null },
                    { 29, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(463), "BİLEKLİK/DGF26BL00070-3.JPG", false, null, 10, 2, null },
                    { 30, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(464), "BİLEKLİK/DGF26BL00070.jpg", false, null, 10, 3, null },
                    { 31, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(465), "BİLEKLİK/DGF26BL00071-2.jpg", false, null, 11, 1, null },
                    { 32, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(494), "BİLEKLİK/DGF26BL00071-3.JPG", false, null, 11, 2, null },
                    { 33, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(495), "BİLEKLİK/DGF26BL00071.jpg", false, null, 11, 3, null },
                    { 34, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(496), "BİLEKLİK/DGF26BL00072-2.jpg", false, null, 12, 1, null },
                    { 35, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(497), "BİLEKLİK/DGF26BL00072-3.JPG", false, null, 12, 2, null },
                    { 36, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(498), "BİLEKLİK/DGF26BL00072.jpg", false, null, 12, 3, null },
                    { 37, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(499), "BİLEKLİK/DGF26BL00073.jpg", false, null, 13, 1, null },
                    { 38, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(500), "BİLEKLİK/DGF26BL00074-3_(2).JPG", false, null, 14, 1, null },
                    { 39, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(501), "BİLEKLİK/DGF26BL00074.jpg", false, null, 14, 2, null },
                    { 40, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(506), "BİLEKLİK/DGF26BL00075-3-2_(2).JPG", false, null, 15, 1, null },
                    { 41, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(507), "BİLEKLİK/DGF26BL00075-3_(2).JPG", false, null, 15, 2, null },
                    { 42, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(508), "BİLEKLİK/DGF26BL00075.jpg", false, null, 15, 3, null },
                    { 43, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(509), "KELEPÇE/DGF26BL00031-2.jpg", false, null, 16, 1, null },
                    { 44, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(510), "KELEPÇE/DGF26BL00031-3.JPG", false, null, 16, 2, null },
                    { 45, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(511), "KELEPÇE/DGF26BL00031.jpg", false, null, 16, 3, null },
                    { 46, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(512), "KELEPÇE/DGF26BZ00013-2.jpg", false, null, 17, 1, null },
                    { 47, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(513), "KELEPÇE/DGF26BZ00013-3.JPG", false, null, 17, 2, null },
                    { 48, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(522), "KELEPÇE/DGF26BZ00013.jpg", false, null, 17, 3, null },
                    { 49, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(523), "KELEPÇE/DGF26BZ00014-2.jpg", false, null, 18, 1, null },
                    { 50, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(524), "KELEPÇE/DGF26BZ00014-3.JPG", false, null, 18, 2, null },
                    { 51, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(525), "KELEPÇE/DGF26BZ00014.jpg", false, null, 18, 3, null },
                    { 52, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(526), "KOLYE/DGF26KU00089-2.jpg", false, null, 19, 1, null },
                    { 53, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(527), "KOLYE/DGF26KU00089.jpg", false, null, 19, 2, null },
                    { 54, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(528), "KOLYE/DGF26KU00205-2.jpg", false, null, 20, 1, null },
                    { 55, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(529), "KOLYE/DGF26KU00205-3.JPG", false, null, 20, 2, null },
                    { 56, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(530), "KOLYE/DGF26KU00205.jpg", false, null, 20, 3, null },
                    { 57, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(531), "KOLYE/DGF26KU00206-2.jpg", false, null, 21, 1, null },
                    { 58, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(532), "KOLYE/DGF26KU00206-3.JPG", false, null, 21, 2, null },
                    { 59, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(533), "KOLYE/DGF26KU00206.jpg", false, null, 21, 3, null },
                    { 60, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(534), "KOLYE/DGF26KU00207-2.jpg", false, null, 22, 1, null },
                    { 61, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(535), "KOLYE/DGF26KU00207-3.JPG", false, null, 22, 2, null },
                    { 62, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(536), "KOLYE/DGF26KU00207.jpg", false, null, 22, 3, null },
                    { 63, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(537), "KOLYE/DGF26KU00208-2.jpg", false, null, 23, 1, null },
                    { 64, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(538), "KOLYE/DGF26KU00208-3.JPG", false, null, 23, 2, null },
                    { 65, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(539), "KOLYE/DGF26KU00208.jpg", false, null, 23, 3, null },
                    { 66, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(540), "KOLYE/DGF26KU00226-2.jpg", false, null, 24, 1, null },
                    { 67, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(549), "KOLYE/DGF26KU00226-3.JPG", false, null, 24, 2, null },
                    { 68, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(550), "KOLYE/DGF26KU00226.jpg", false, null, 24, 3, null },
                    { 69, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(551), "KOLYE/DGF26KU00227-2.jpg", false, null, 25, 1, null },
                    { 70, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(552), "KOLYE/DGF26KU00227-3.JPG", false, null, 25, 2, null },
                    { 71, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(553), "KOLYE/DGF26KU00227.jpg", false, null, 25, 3, null },
                    { 72, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(554), "KOLYE/DGF26KU00231-2.jpg", false, null, 26, 1, null },
                    { 73, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(555), "KOLYE/DGF26KU00231.jpg", false, null, 26, 2, null },
                    { 74, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(556), "KOLYE/DGF26KU00237-2.jpg", false, null, 27, 1, null },
                    { 75, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(557), "KOLYE/DGF26KU00237-4.JPG", false, null, 27, 2, null },
                    { 76, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(558), "KOLYE/DGF26KU00237.jpg", false, null, 27, 3, null },
                    { 77, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(559), "KOLYE/DGF26KU00256-2.jpg", false, null, 28, 1, null },
                    { 78, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(560), "KOLYE/DGF26KU00256-3.JPG", false, null, 28, 2, null },
                    { 79, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(561), "KOLYE/DGF26KU00256.jpg", false, null, 28, 3, null },
                    { 80, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(562), "KOLYE/DGF26KU00269-2.jpg", false, null, 29, 1, null },
                    { 81, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(563), "KOLYE/DGF26KU00269.jpg", false, null, 29, 2, null },
                    { 82, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(564), "KOLYE/DGF26KU00327-2.jpg", false, null, 30, 1, null },
                    { 83, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(565), "KOLYE/DGF26KU00327-3.JPG", false, null, 30, 2, null },
                    { 84, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(566), "KOLYE/DGF26KU00327-4.JPG", false, null, 30, 3, null },
                    { 85, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(568), "KOLYE/DGF26KU00327.jpg", false, null, 30, 4, null },
                    { 86, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(575), "KOLYE/DGF26KU00328-2.jpg", false, null, 31, 1, null },
                    { 87, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(577), "KOLYE/DGF26KU00328-3.JPG", false, null, 31, 2, null },
                    { 88, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(578), "KOLYE/DGF26KU00328-4.JPG", false, null, 31, 3, null },
                    { 89, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(579), "KOLYE/DGF26KU00328.jpg", false, null, 31, 4, null },
                    { 90, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(580), "KOLYE/DGF26KU00336-2.jpg", false, null, 32, 1, null },
                    { 91, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(583), "KOLYE/DGF26KU00336-4.JPG", false, null, 32, 2, null },
                    { 92, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(584), "KOLYE/DGF26KU00336.jpg", false, null, 32, 3, null },
                    { 93, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(585), "KOLYE/DGF26KU00347-2.jpg", false, null, 33, 1, null },
                    { 94, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(586), "KOLYE/DGF26KU00347-4.JPG", false, null, 33, 2, null },
                    { 95, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(587), "KOLYE/DGF26KU00347.jpg", false, null, 33, 3, null },
                    { 96, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(589), "KOLYE/DGF26KU00348-2.jpg", false, null, 34, 1, null },
                    { 97, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(590), "KOLYE/DGF26KU00348-4.JPG", false, null, 34, 2, null },
                    { 98, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(594), "KOLYE/DGF26KU00348.jpg", false, null, 34, 3, null },
                    { 99, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(595), "KOLYE/DGF26KU00349-2.jpg", false, null, 35, 1, null },
                    { 100, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(598), "KOLYE/DGF26KU00349-4.JPG", false, null, 35, 2, null },
                    { 101, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(599), "KOLYE/DGF26KU00349.jpg", false, null, 35, 3, null },
                    { 102, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(601), "KOLYE/DGF26KU00350-2.jpg", false, null, 36, 1, null },
                    { 103, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(602), "KOLYE/DGF26KU00350-4.JPG", false, null, 36, 2, null },
                    { 104, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(603), "KOLYE/DGF26KU00350.jpg", false, null, 36, 3, null },
                    { 105, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(604), "KOLYE/DGF26KU00353-2.jpg", false, null, 37, 1, null },
                    { 106, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(613), "KOLYE/DGF26KU00353-4.JPG", false, null, 37, 2, null },
                    { 107, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(614), "KOLYE/DGF26KU00353.jpg", false, null, 37, 3, null },
                    { 108, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(615), "KOLYE/NAİF13-2.JPG", false, null, 38, 1, null },
                    { 109, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(616), "KOLYE/NAİF13.jpg", false, null, 38, 2, null },
                    { 110, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(617), "KÜPE/DGF26KP00128-2.jpg", false, null, 39, 1, null },
                    { 111, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(618), "KÜPE/DGF26KP00128.jpg", false, null, 39, 2, null },
                    { 112, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(619), "KÜPE/DGF26KP00142-2.jpg", false, null, 40, 1, null },
                    { 113, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(620), "KÜPE/DGF26KP00142-3.JPG", false, null, 40, 2, null },
                    { 114, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(622), "KÜPE/DGF26KP00142.jpg", false, null, 40, 3, null },
                    { 115, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(623), "KÜPE/DGF26KP00143-2.jpg", false, null, 41, 1, null },
                    { 116, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(624), "KÜPE/DGF26KP00143-3.JPG", false, null, 41, 2, null },
                    { 117, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(625), "KÜPE/DGF26KP00143.jpg", false, null, 41, 3, null },
                    { 118, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(626), "KÜPE/DGF26KP00144-2.jpg", false, null, 42, 1, null },
                    { 119, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(627), "KÜPE/DGF26KP00144-3.JPG", false, null, 42, 2, null },
                    { 120, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(628), "KÜPE/DGF26KP00144.jpg", false, null, 42, 3, null },
                    { 121, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(629), "KÜPE/DGF26KP00152-2.jpg", false, null, 43, 1, null },
                    { 122, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(630), "KÜPE/DGF26KP00152-3.JPG", false, null, 43, 2, null },
                    { 123, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(631), "KÜPE/DGF26KP00152.jpg", false, null, 43, 3, null },
                    { 124, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(632), "KÜPE/DGF26KP00153-2.jpg", false, null, 44, 1, null },
                    { 125, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(640), "KÜPE/DGF26KP00153-3.JPG", false, null, 44, 2, null },
                    { 126, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(641), "KÜPE/DGF26KP00153.jpg", false, null, 44, 3, null },
                    { 127, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(642), "KÜPE/DGF26KP00154-2.jpg", false, null, 45, 1, null },
                    { 128, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(643), "KÜPE/DGF26KP00154-3.JPG", false, null, 45, 2, null },
                    { 129, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(644), "KÜPE/DGF26KP00154.jpg", false, null, 45, 3, null },
                    { 130, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(645), "KÜPE/DGF26KP00155-2.jpg", false, null, 46, 1, null },
                    { 131, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(646), "KÜPE/DGF26KP00155-3.JPG", false, null, 46, 2, null },
                    { 132, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(647), "KÜPE/DGF26KP00155.jpg", false, null, 46, 3, null },
                    { 133, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(648), "KÜPE/DGF26KP00156-2.jpg", false, null, 47, 1, null },
                    { 134, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(649), "KÜPE/DGF26KP00156-3.JPG", false, null, 47, 2, null },
                    { 135, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(656), "KÜPE/DGF26KP00156.jpg", false, null, 47, 3, null },
                    { 136, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(657), "KÜPE/DGF26KP00157-2.jpg", false, null, 48, 1, null },
                    { 137, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(658), "KÜPE/DGF26KP00157-3.JPG", false, null, 48, 2, null },
                    { 138, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(659), "KÜPE/DGF26KP00157.jpg", false, null, 48, 3, null },
                    { 139, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(660), "KÜPE/DGF26KP00158-2.jpg", false, null, 49, 1, null },
                    { 140, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(661), "KÜPE/DGF26KP00158-3.JPG", false, null, 49, 2, null },
                    { 141, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(662), "KÜPE/DGF26KP00158.jpg", false, null, 49, 3, null },
                    { 142, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(663), "KÜPE/DGF26KP00160-2.jpg", false, null, 50, 1, null },
                    { 143, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(664), "KÜPE/DGF26KP00160-3.JPG", false, null, 50, 2, null },
                    { 144, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(673), "KÜPE/DGF26KP00160.jpg", false, null, 50, 3, null },
                    { 145, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(674), "KÜPE/DGF26KP00161-2.jpg", false, null, 51, 1, null },
                    { 146, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(675), "KÜPE/DGF26KP00161-3.JPG", false, null, 51, 2, null },
                    { 147, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(676), "KÜPE/DGF26KP00161.jpg", false, null, 51, 3, null },
                    { 148, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(677), "KÜPE/DGF26KP00162-2.jpg", false, null, 52, 1, null },
                    { 149, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(678), "KÜPE/DGF26KP00162-3.JPG", false, null, 52, 2, null },
                    { 150, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(679), "KÜPE/DGF26KP00162.jpg", false, null, 52, 3, null },
                    { 151, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(680), "KÜPE/DGF26KP00164-2.jpg", false, null, 53, 1, null },
                    { 152, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(681), "KÜPE/DGF26KP00164-3.JPG", false, null, 53, 2, null },
                    { 153, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(682), "KÜPE/DGF26KP00164.jpg", false, null, 53, 3, null },
                    { 154, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(683), "KÜPE/DGF26KP00165-2.jpg", false, null, 54, 1, null },
                    { 155, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(684), "KÜPE/DGF26KP00165-3.JPG", false, null, 54, 2, null },
                    { 156, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(685), "KÜPE/DGF26KP00165.jpg", false, null, 54, 3, null },
                    { 157, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(686), "KÜPE/DGF26KP00166-2.jpg", false, null, 55, 1, null },
                    { 158, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(687), "KÜPE/DGF26KP00166-3.JPG", false, null, 55, 2, null },
                    { 159, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(688), "KÜPE/DGF26KP00166.jpg", false, null, 55, 3, null },
                    { 160, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(689), "KÜPE/DGF26KP00167-2.jpg", false, null, 56, 1, null },
                    { 161, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(690), "KÜPE/DGF26KP00167-3.JPG", false, null, 56, 2, null },
                    { 162, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(691), "KÜPE/DGF26KP00167.jpg", false, null, 56, 3, null },
                    { 163, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(700), "KÜPE/DGF26KP00169-2.jpg", false, null, 57, 1, null },
                    { 164, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(701), "KÜPE/DGF26KP00169-3.JPG", false, null, 57, 2, null },
                    { 165, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(702), "KÜPE/DGF26KP00169.jpg", false, null, 57, 3, null },
                    { 166, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(703), "KÜPE/DGF26KP00170-2.jpg", false, null, 58, 1, null },
                    { 167, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(704), "KÜPE/DGF26KP00170-3.JPG", false, null, 58, 2, null },
                    { 168, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(705), "KÜPE/DGF26KP00170.jpg", false, null, 58, 3, null },
                    { 169, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(706), "KÜPE/DGF26KP00171-2.jpg", false, null, 59, 1, null },
                    { 170, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(707), "KÜPE/DGF26KP00171-3.JPG", false, null, 59, 2, null },
                    { 171, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(708), "KÜPE/DGF26KP00171.jpg", false, null, 59, 3, null },
                    { 172, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(709), "KÜPE/DGF26KP00172-2.jpg", false, null, 60, 1, null },
                    { 173, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(710), "KÜPE/DGF26KP00172-3.JPG", false, null, 60, 2, null },
                    { 174, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(711), "KÜPE/DGF26KP00172.jpg", false, null, 60, 3, null },
                    { 175, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(712), "KÜPE/DGF26KP00173-2.jpg", false, null, 61, 1, null },
                    { 176, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(713), "KÜPE/DGF26KP00173-3.JPG", false, null, 61, 2, null },
                    { 177, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(714), "KÜPE/DGF26KP00173.jpg", false, null, 61, 3, null },
                    { 178, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(715), "KÜPE/DGF26KP00175-2.jpg", false, null, 62, 1, null },
                    { 179, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(716), "KÜPE/DGF26KP00175-3.JPG", false, null, 62, 2, null },
                    { 180, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(717), "KÜPE/DGF26KP00175.jpg", false, null, 62, 3, null },
                    { 181, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(718), "KÜPE/DGF26KP00176-2.jpg", false, null, 63, 1, null },
                    { 182, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(726), "KÜPE/DGF26KP00176-3.JPG", false, null, 63, 2, null },
                    { 183, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(727), "KÜPE/DGF26KP00176.jpg", false, null, 63, 3, null },
                    { 184, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(728), "KÜPE/DGF26KP00178-2.jpg", false, null, 64, 1, null },
                    { 185, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(729), "KÜPE/DGF26KP00178-3.JPG", false, null, 64, 2, null },
                    { 186, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(730), "KÜPE/DGF26KP00178.jpg", false, null, 64, 3, null },
                    { 187, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(731), "KÜPE/DGF26KP00184-2.jpg", false, null, 65, 1, null },
                    { 188, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(732), "KÜPE/DGF26KP00184-3.JPG", false, null, 65, 2, null },
                    { 189, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(733), "KÜPE/DGF26KP00184.jpg", false, null, 65, 3, null },
                    { 190, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(734), "KÜPE/DGF26KP00186-2.jpg", false, null, 66, 1, null },
                    { 191, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(739), "KÜPE/DGF26KP00186-3.JPG", false, null, 66, 2, null },
                    { 192, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(740), "KÜPE/DGF26KP00186.jpg", false, null, 66, 3, null },
                    { 193, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(741), "KÜPE/DGF26KP00189-2.jpg", false, null, 67, 1, null },
                    { 194, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(742), "KÜPE/DGF26KP00189-3.JPG", false, null, 67, 2, null },
                    { 195, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(743), "KÜPE/DGF26KP00189.jpg", false, null, 67, 3, null },
                    { 196, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(744), "KÜPE/DGF26KP00215-2.jpg", false, null, 68, 1, null },
                    { 197, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(745), "KÜPE/DGF26KP00215-3.JPG", false, null, 68, 2, null },
                    { 198, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(747), "KÜPE/DGF26KP00215.jpg", false, null, 68, 3, null },
                    { 199, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(748), "KÜPE/DGF26KP00218-2.jpg", false, null, 69, 1, null },
                    { 200, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(749), "KÜPE/DGF26KP00218-3.JPG", false, null, 69, 2, null },
                    { 201, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(755), "KÜPE/DGF26KP00218.jpg", false, null, 69, 3, null },
                    { 202, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(757), "KÜPE/DGF26KP00219-3.JPG", false, null, 70, 1, null },
                    { 203, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(758), "KÜPE/DGF26KP00231-2.jpg", false, null, 71, 1, null },
                    { 204, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(759), "KÜPE/DGF26KP00231-3.JPG", false, null, 71, 2, null },
                    { 205, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(760), "KÜPE/DGF26KP00231.jpg", false, null, 71, 3, null },
                    { 206, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(761), "KÜPE/DGF26KP00232-2.jpg", false, null, 72, 1, null },
                    { 207, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(762), "KÜPE/DGF26KP00232-3.JPG", false, null, 72, 2, null },
                    { 208, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(763), "KÜPE/DGF26KP00232.jpg", false, null, 72, 3, null },
                    { 209, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(764), "KÜPE/DGF26KP00236-2.jpg", false, null, 73, 1, null },
                    { 210, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(765), "KÜPE/DGF26KP00236-3.JPG", false, null, 73, 2, null },
                    { 211, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(766), "KÜPE/DGF26KP00236.jpg", false, null, 73, 3, null },
                    { 212, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(767), "KÜPE/DGF26KP00244-2.jpg", false, null, 74, 1, null },
                    { 213, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(768), "KÜPE/DGF26KP00244.jpg", false, null, 74, 2, null },
                    { 214, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(769), "KÜPE/DGF26KP00264-2.jpg", false, null, 75, 1, null },
                    { 215, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(770), "KÜPE/DGF26KP00264-3.JPG", false, null, 75, 2, null },
                    { 216, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(771), "KÜPE/DGF26KP00264.jpg", false, null, 75, 3, null },
                    { 217, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(772), "KÜPE/DGF26KP00266-2.jpg", false, null, 76, 1, null },
                    { 218, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(773), "KÜPE/DGF26KP00266-3.JPG", false, null, 76, 2, null },
                    { 219, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(774), "KÜPE/DGF26KP00266.jpg", false, null, 76, 3, null },
                    { 220, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(782), "KÜPE/DGF26KP00267-2.jpg", false, null, 77, 1, null },
                    { 221, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(783), "KÜPE/DGF26KP00267-3.JPG", false, null, 77, 2, null },
                    { 222, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(784), "KÜPE/DGF26KP00267.jpg", false, null, 77, 3, null },
                    { 223, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(785), "KÜPE/DGF26KP00269-2.jpg", false, null, 78, 1, null },
                    { 224, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(786), "KÜPE/DGF26KP00269-3.JPG", false, null, 78, 2, null },
                    { 225, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(787), "KÜPE/DGF26KP00269.jpg", false, null, 78, 3, null },
                    { 226, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(789), "KÜPE/DGF26KP00270-2.jpg", false, null, 79, 1, null },
                    { 227, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(790), "KÜPE/DGF26KP00270-3.JPG", false, null, 79, 2, null },
                    { 228, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(791), "KÜPE/DGF26KP00270.jpg", false, null, 79, 3, null },
                    { 229, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(792), "KÜPE/DGF26KP00271-2.jpg", false, null, 80, 1, null },
                    { 230, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(793), "KÜPE/DGF26KP00271-3.JPG", false, null, 80, 2, null },
                    { 231, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(794), "KÜPE/DGF26KP00271.jpg", false, null, 80, 3, null },
                    { 232, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(795), "KÜPE/DGF26KP00295-2.jpg", false, null, 81, 1, null },
                    { 233, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(796), "KÜPE/DGF26KP00295-3.JPG", false, null, 81, 2, null },
                    { 234, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(797), "KÜPE/DGF26KP00295.jpg", false, null, 81, 3, null },
                    { 235, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(798), "KÜPE/DGF26KP00296-2.jpg", false, null, 82, 1, null },
                    { 236, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(799), "KÜPE/DGF26KP00296-3.JPG", false, null, 82, 2, null },
                    { 237, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(806), "KÜPE/DGF26KP00296.jpg", false, null, 82, 3, null },
                    { 238, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(808), "KÜPE/DGF26KP00297-2.jpg", false, null, 83, 1, null },
                    { 239, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(809), "KÜPE/DGF26KP00297-3.JPG", false, null, 83, 2, null },
                    { 240, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(821), "KÜPE/DGF26KP00297.jpg", false, null, 83, 3, null },
                    { 241, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(822), "KÜPE/DGF26KP00305-2.jpg", false, null, 84, 1, null },
                    { 242, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(823), "KÜPE/DGF26KP00305.jpg", false, null, 84, 2, null },
                    { 243, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(824), "KÜPE/DGF26KP00315-2.jpg", false, null, 85, 1, null },
                    { 244, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(825), "KÜPE/DGF26KP00315.jpg", false, null, 85, 2, null },
                    { 245, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(826), "KÜPE/DGF26KP00316-2.jpg", false, null, 86, 1, null },
                    { 246, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(827), "KÜPE/DGF26KP00316.jpg", false, null, 86, 2, null },
                    { 247, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(828), "KÜPE/DGF26KP00319-2.jpg", false, null, 87, 1, null },
                    { 248, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(829), "KÜPE/DGF26KP00319.jpg", false, null, 87, 2, null },
                    { 249, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(830), "KÜPE/DGF26KP00320-2.jpg", false, null, 88, 1, null },
                    { 250, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(831), "KÜPE/DGF26KP00320.jpg", false, null, 88, 2, null },
                    { 251, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(832), "KÜPE/DGF26KP00321-2.jpg", false, null, 89, 1, null },
                    { 252, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(833), "KÜPE/DGF26KP00321.jpg", false, null, 89, 2, null },
                    { 253, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(834), "KÜPE/DGF26KP00322-2.jpg", false, null, 90, 1, null },
                    { 254, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(835), "KÜPE/DGF26KP00322.jpg", false, null, 90, 2, null },
                    { 255, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(836), "KÜPE/DGF26KP00323-2.jpg", false, null, 91, 1, null },
                    { 256, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(837), "KÜPE/DGF26KP00323.jpg", false, null, 91, 2, null },
                    { 257, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(838), "KÜPE/DGF26KP00324-2.jpg", false, null, 92, 1, null },
                    { 258, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(839), "KÜPE/DGF26KP00324.jpg", false, null, 92, 2, null },
                    { 259, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(846), "KÜPE/DGF26KPKP00219-2.jpg", false, null, 93, 1, null },
                    { 260, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(847), "KÜPE/DGF26KPKP00219.jpg", false, null, 93, 2, null },
                    { 261, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(848), "KÜPE/NAİF11-2.jpg", false, null, 94, 1, null },
                    { 262, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(849), "KÜPE/NAİF11-3.JPG", false, null, 94, 2, null },
                    { 263, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(850), "KÜPE/NAİF11.jpg", false, null, 94, 3, null },
                    { 264, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(851), "KÜPE/NAİF12-2.JPG", false, null, 95, 1, null },
                    { 265, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(852), "KÜPE/NAİF12.jpg", false, null, 95, 2, null },
                    { 266, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(853), "PIRLANTA/PIR0007296-3_(2).JPG", false, null, 96, 1, null },
                    { 267, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(854), "PIRLANTA/PIR0007296.jpg", false, null, 96, 2, null },
                    { 268, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(855), "PIRLANTA/PIR0007297-3_(2).JPG", false, null, 97, 1, null },
                    { 269, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(856), "PIRLANTA/PIR0007297.jpg", false, null, 97, 2, null },
                    { 270, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(857), "PIRLANTA/PIR0007298-3_(2).JPG", false, null, 98, 1, null },
                    { 271, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(858), "PIRLANTA/PIR0007298.jpg", false, null, 98, 2, null },
                    { 272, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(859), "PIRLANTA/PIR0007299-3_(2).JPG", false, null, 99, 1, null },
                    { 273, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(860), "PIRLANTA/PIR0007299.jpg", false, null, 99, 2, null },
                    { 274, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(861), "PIRLANTA/PIR0007300.jpg", false, null, 100, 1, null },
                    { 275, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(862), "PIRLANTA/PIR0007301.jpg", false, null, 101, 1, null },
                    { 276, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(863), "PIRLANTA/PIR0007302.jpg", false, null, 102, 1, null },
                    { 277, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(864), "PIRLANTA/PIR0007308-3_(2).JPG", false, null, 103, 1, null },
                    { 278, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(871), "PIRLANTA/PIR0007308.jpg", false, null, 103, 2, null },
                    { 279, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(872), "PIRLANTA/PIR0007318.jpg", false, null, 104, 1, null },
                    { 280, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(873), "PIRLANTA/PIR0007319-2.jpg", false, null, 105, 1, null },
                    { 281, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(874), "PIRLANTA/PIR0007319-4.JPG", false, null, 105, 2, null },
                    { 282, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(875), "PIRLANTA/PIR0007319.jpg", false, null, 105, 3, null },
                    { 283, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(876), "SET/NAİF1-2.jpg", false, null, 106, 1, null },
                    { 284, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(877), "SET/NAİF1-3.JPG", false, null, 106, 2, null },
                    { 285, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(878), "SET/NAİF1-4.JPG", false, null, 106, 3, null },
                    { 286, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(879), "YÜZÜK/DGF26YZ00145.jpg", false, null, 107, 1, null },
                    { 287, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(881), "YÜZÜK/DGF26YZ00321.jpg", false, null, 108, 1, null },
                    { 288, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(882), "YÜZÜK/DGF26YZ00335-3_(2).JPG", false, null, 109, 1, null },
                    { 289, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(883), "YÜZÜK/DGF26YZ00335.jpg", false, null, 109, 2, null },
                    { 290, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(884), "YÜZÜK/DGF26YZ00336-3_(2).JPG", false, null, 110, 1, null },
                    { 291, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(885), "YÜZÜK/DGF26YZ00336.jpg", false, null, 110, 2, null },
                    { 292, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(886), "YÜZÜK/DGF26YZ00339-3_(2).JPG", false, null, 111, 1, null },
                    { 293, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(887), "YÜZÜK/DGF26YZ00339.jpg", false, null, 111, 2, null },
                    { 294, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(888), "YÜZÜK/DGF26YZ00340-3_(2).JPG", false, null, 112, 1, null },
                    { 295, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(889), "YÜZÜK/DGF26YZ00340.jpg", false, null, 112, 2, null },
                    { 296, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(890), "YÜZÜK/DGF26YZ00341-3_(2).JPG", false, null, 113, 1, null },
                    { 297, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(898), "YÜZÜK/DGF26YZ00341.jpg", false, null, 113, 2, null },
                    { 298, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(899), "YÜZÜK/DGF26YZ00372-3_(2).JPG", false, null, 114, 1, null },
                    { 299, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(900), "YÜZÜK/DGF26YZ00372.jpg", false, null, 114, 2, null },
                    { 300, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(901), "YÜZÜK/DGF26YZ00376-3_(2).JPG", false, null, 115, 1, null },
                    { 301, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(902), "YÜZÜK/DGF26YZ00376.jpg", false, null, 115, 2, null },
                    { 302, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(903), "YÜZÜK/DGF26YZ00378-3_(2).JPG", false, null, 116, 1, null },
                    { 303, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(904), "YÜZÜK/DGF26YZ00378.jpg", false, null, 116, 2, null },
                    { 304, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(905), "YÜZÜK/DGF26YZ00379-3_(2).JPG", false, null, 117, 1, null },
                    { 305, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(906), "YÜZÜK/DGF26YZ00379.jpg", false, null, 117, 2, null },
                    { 306, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(907), "YÜZÜK/DGF26YZ00380-3_(2).JPG", false, null, 118, 1, null },
                    { 307, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(908), "YÜZÜK/DGF26YZ00380.jpg", false, null, 118, 2, null },
                    { 308, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(909), "YÜZÜK/DGF26YZ00381-3_(2).JPG", false, null, 119, 1, null },
                    { 309, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(910), "YÜZÜK/DGF26YZ00381.jpg", false, null, 119, 2, null },
                    { 310, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(911), "YÜZÜK/DGF26YZ00411-3_(2).JPG", false, null, 120, 1, null },
                    { 311, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(912), "YÜZÜK/DGF26YZ00411.jpg", false, null, 120, 2, null },
                    { 312, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(913), "YÜZÜK/DGF26YZ00412-3_(2).JPG", false, null, 121, 1, null },
                    { 313, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(914), "YÜZÜK/DGF26YZ00412.jpg", false, null, 121, 2, null },
                    { 314, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(915), "YÜZÜK/DGF26YZ00426.jpg", false, null, 122, 1, null },
                    { 315, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(916), "YÜZÜK/DGF26YZ00449-3_(2).JPG", false, null, 123, 1, null },
                    { 316, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(924), "YÜZÜK/DGF26YZ00449.jpg", false, null, 123, 2, null },
                    { 317, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(925), "YÜZÜK/DGF26YZ00451-3_(2).JPG", false, null, 124, 1, null },
                    { 318, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(926), "YÜZÜK/DGF26YZ00451.jpg", false, null, 124, 2, null },
                    { 319, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(928), "YÜZÜK/DGF26YZ00452-3_(2).JPG", false, null, 125, 1, null },
                    { 320, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(929), "YÜZÜK/DGF26YZ00452.jpg", false, null, 125, 2, null },
                    { 321, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(930), "YÜZÜK/DGF26YZ00453-3_(2).JPG", false, null, 126, 1, null },
                    { 322, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(931), "YÜZÜK/DGF26YZ00453.jpg", false, null, 126, 2, null },
                    { 323, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(932), "YÜZÜK/DGF26YZ00454-3_(2).JPG", false, null, 127, 1, null },
                    { 324, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(933), "YÜZÜK/DGF26YZ00454.jpg", false, null, 127, 2, null },
                    { 325, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(934), "YÜZÜK/DGF26YZ00455-3_(2).JPG", false, null, 128, 1, null },
                    { 326, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(935), "YÜZÜK/DGF26YZ00455.jpg", false, null, 128, 2, null },
                    { 327, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(936), "YÜZÜK/DGF26YZ00456-3_(2).JPG", false, null, 129, 1, null },
                    { 328, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(937), "YÜZÜK/DGF26YZ00456.jpg", false, null, 129, 2, null },
                    { 329, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(938), "YÜZÜK/DGF26YZ00457-3_(2).JPG", false, null, 130, 1, null },
                    { 330, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(939), "YÜZÜK/DGF26YZ00457.jpg", false, null, 130, 2, null },
                    { 331, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(940), "YÜZÜK/DGF26YZ00458-3_(2).JPG", false, null, 131, 1, null },
                    { 332, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(941), "YÜZÜK/DGF26YZ00458.jpg", false, null, 131, 2, null },
                    { 333, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(942), "YÜZÜK/DGF26YZ00459-3_(2).JPG", false, null, 132, 1, null },
                    { 334, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(943), "YÜZÜK/DGF26YZ00459.jpg", false, null, 132, 2, null },
                    { 335, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(952), "YÜZÜK/DGF26YZ00461-3_(2).JPG", false, null, 133, 1, null },
                    { 336, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(953), "YÜZÜK/DGF26YZ00461.jpg", false, null, 133, 2, null },
                    { 337, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(954), "YÜZÜK/DGF26YZ00462-3_(2).JPG", false, null, 134, 1, null },
                    { 338, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(955), "YÜZÜK/DGF26YZ00462.jpg", false, null, 134, 2, null },
                    { 339, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(956), "YÜZÜK/DGF26YZ00463-3_(2).JPG", false, null, 135, 1, null },
                    { 340, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(963), "YÜZÜK/DGF26YZ00463.jpg", false, null, 135, 2, null },
                    { 341, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(964), "YÜZÜK/DGF26YZ00464-3_(2).JPG", false, null, 136, 1, null },
                    { 342, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(965), "YÜZÜK/DGF26YZ00464.jpg", false, null, 136, 2, null },
                    { 343, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(966), "YÜZÜK/DGF26YZ00474.jpg", false, null, 137, 1, null },
                    { 344, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(967), "YÜZÜK/DGF26YZ00475.jpg", false, null, 138, 1, null },
                    { 345, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(968), "YÜZÜK/DGF26YZ00479.jpg", false, null, 139, 1, null },
                    { 346, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(969), "YÜZÜK/DGF26YZ00511-3_(2).JPG", false, null, 140, 1, null },
                    { 347, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(970), "YÜZÜK/DGF26YZ00511.jpg", false, null, 140, 2, null },
                    { 348, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(974), "YÜZÜK/DGF26YZ00516-3_(2).JPG", false, null, 141, 1, null },
                    { 349, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(975), "YÜZÜK/DGF26YZ00516.jpg", false, null, 141, 2, null },
                    { 350, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(976), "YÜZÜK/DGF26YZ00517-3_(2).JPG", false, null, 142, 1, null },
                    { 351, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(977), "YÜZÜK/DGF26YZ00517.jpg", false, null, 142, 2, null },
                    { 352, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(978), "YÜZÜK/DGF26YZ00520-3_(2).JPG", false, null, 143, 1, null },
                    { 353, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(979), "YÜZÜK/DGF26YZ00520.jpg", false, null, 143, 2, null },
                    { 354, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(988), "YÜZÜK/DGF26YZ00521-3_(2).JPG", false, null, 144, 1, null },
                    { 355, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(995), "YÜZÜK/DGF26YZ00521.jpg", false, null, 144, 2, null },
                    { 356, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(996), "YÜZÜK/DGF26YZ00522-3_(2).JPG", false, null, 145, 1, null },
                    { 357, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(997), "YÜZÜK/DGF26YZ00522.jpg", false, null, 145, 2, null },
                    { 358, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(998), "YÜZÜK/DGF26YZ00523-3_(2).JPG", false, null, 146, 1, null },
                    { 359, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(999), "YÜZÜK/DGF26YZ00523.jpg", false, null, 146, 2, null },
                    { 360, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1000), "YÜZÜK/DGF26YZ00524-3_(2).JPG", false, null, 147, 1, null },
                    { 361, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1001), "YÜZÜK/DGF26YZ00524.jpg", false, null, 147, 2, null },
                    { 362, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1002), "YÜZÜK/DGF26YZ00525-3_(2).JPG", false, null, 148, 1, null },
                    { 363, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1003), "YÜZÜK/DGF26YZ00525.jpg", false, null, 148, 2, null },
                    { 364, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1004), "YÜZÜK/DGF26YZ00526-3_(2).JPG", false, null, 149, 1, null },
                    { 365, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1005), "YÜZÜK/DGF26YZ00526.jpg", false, null, 149, 2, null },
                    { 366, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1006), "YÜZÜK/DGF26YZ00527-3_(2).JPG", false, null, 150, 1, null },
                    { 367, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1007), "YÜZÜK/DGF26YZ00527.jpg", false, null, 150, 2, null },
                    { 368, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1008), "YÜZÜK/DGF26YZ00530-3_(2).JPG", false, null, 151, 1, null },
                    { 369, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1009), "YÜZÜK/DGF26YZ00530.jpg", false, null, 151, 2, null },
                    { 370, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1010), "YÜZÜK/DGF26YZ00535-3_(2).JPG", false, null, 152, 1, null },
                    { 371, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1011), "YÜZÜK/DGF26YZ00535.jpg", false, null, 152, 2, null },
                    { 372, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1012), "YÜZÜK/DGF26YZ00537-3_(2).JPG", false, null, 153, 1, null },
                    { 373, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1013), "YÜZÜK/DGF26YZ00537.jpg", false, null, 153, 2, null },
                    { 374, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1023), "YÜZÜK/DGF26YZ00538-3_(2).JPG", false, null, 154, 1, null },
                    { 375, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1024), "YÜZÜK/DGF26YZ00538.jpg", false, null, 154, 2, null },
                    { 376, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1025), "YÜZÜK/DGF26YZ00539-3_(2).JPG", false, null, 155, 1, null },
                    { 377, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1026), "YÜZÜK/DGF26YZ00539.jpg", false, null, 155, 2, null },
                    { 378, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1027), "YÜZÜK/DGF26YZ00540-3_(2).JPG", false, null, 156, 1, null },
                    { 379, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1028), "YÜZÜK/DGF26YZ00540.jpg", false, null, 156, 2, null },
                    { 380, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1029), "YÜZÜK/DGF26YZ00541-3_(2).JPG", false, null, 157, 1, null },
                    { 381, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1030), "YÜZÜK/DGF26YZ00541.jpg", false, null, 157, 2, null },
                    { 382, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1031), "YÜZÜK/DGF26YZ00542-3_(2).JPG", false, null, 158, 1, null },
                    { 383, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1032), "YÜZÜK/DGF26YZ00542.jpg", false, null, 158, 2, null },
                    { 384, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1033), "YÜZÜK/DGF26YZ00544-3_(2).JPG", false, null, 159, 1, null },
                    { 385, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1034), "YÜZÜK/DGF26YZ00544.jpg", false, null, 159, 2, null },
                    { 386, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1035), "YÜZÜK/DGF26YZ00545-3_(2).JPG", false, null, 160, 1, null },
                    { 387, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1036), "YÜZÜK/DGF26YZ00545.jpg", false, null, 160, 2, null },
                    { 388, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1037), "YÜZÜK/DGF26YZ00553.jpg", false, null, 161, 1, null },
                    { 389, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1038), "YÜZÜK/DGF26YZ00554-3_(2).JPG", false, null, 162, 1, null },
                    { 390, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1039), "YÜZÜK/DGF26YZ00554.jpg", false, null, 162, 2, null },
                    { 391, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1040), "YÜZÜK/DGF26YZ00555-3_(2).JPG", false, null, 163, 1, null },
                    { 392, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1041), "YÜZÜK/DGF26YZ00555.jpg", false, null, 163, 2, null },
                    { 393, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1057), "YÜZÜK/DGF26YZ00556-3_(2).JPG", false, null, 164, 1, null },
                    { 394, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1058), "YÜZÜK/DGF26YZ00556.jpg", false, null, 164, 2, null },
                    { 395, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1059), "YÜZÜK/DGF26YZ00557-3_(2).JPG", false, null, 165, 1, null },
                    { 396, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1060), "YÜZÜK/DGF26YZ00557.jpg", false, null, 165, 2, null },
                    { 397, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1061), "YÜZÜK/DGF26YZ00558-3_(2).JPG", false, null, 166, 1, null },
                    { 398, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1062), "YÜZÜK/DGF26YZ00558.jpg", false, null, 166, 2, null },
                    { 399, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1063), "YÜZÜK/DGF26YZ00559-3_(2).JPG", false, null, 167, 1, null },
                    { 400, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1064), "YÜZÜK/DGF26YZ00559.jpg", false, null, 167, 2, null },
                    { 401, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1065), "YÜZÜK/DGF26YZ00560JPG-3_(2).JPG", false, null, 168, 1, null },
                    { 402, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1066), "YÜZÜK/DGF26YZ00560JPG.jpg", false, null, 168, 2, null },
                    { 403, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1067), "YÜZÜK/DGF26YZ00570-3_(2).JPG", false, null, 169, 1, null },
                    { 404, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1068), "YÜZÜK/DGF26YZ00570.jpg", false, null, 169, 2, null },
                    { 405, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1069), "YÜZÜK/DGF26YZ00571-3_(2).JPG", false, null, 170, 1, null },
                    { 406, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1070), "YÜZÜK/DGF26YZ00571.jpg", false, null, 170, 2, null },
                    { 407, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1071), "YÜZÜK/DGF26YZ00572-3_(2).JPG", false, null, 171, 1, null },
                    { 408, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1072), "YÜZÜK/DGF26YZ00572.jpg", false, null, 171, 2, null },
                    { 409, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1073), "YÜZÜK/DGF26YZ00574.jpg", false, null, 172, 1, null },
                    { 410, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1074), "YÜZÜK/DGF26YZ00575.jpg", false, null, 173, 1, null },
                    { 411, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1075), "YÜZÜK/DGF26YZ00576-3_(2).JPG", false, null, 174, 1, null },
                    { 412, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1083), "YÜZÜK/DGF26YZ00576.jpg", false, null, 174, 2, null },
                    { 413, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1084), "YÜZÜK/DGF26YZ00577.jpg", false, null, 175, 1, null },
                    { 414, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1085), "YÜZÜK/DGF26YZ00578-3_(2).JPG", false, null, 176, 1, null },
                    { 415, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1086), "YÜZÜK/DGF26YZ00578.jpg", false, null, 176, 2, null },
                    { 416, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1087), "YÜZÜK/DGF26YZ00579-3_(2).JPG", false, null, 177, 1, null },
                    { 417, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1088), "YÜZÜK/DGF26YZ00579.jpg", false, null, 177, 2, null },
                    { 418, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1089), "YÜZÜK/DGF26YZ00580.jpg", false, null, 178, 1, null },
                    { 419, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1090), "YÜZÜK/DGF26YZ00581.jpg", false, null, 179, 1, null },
                    { 420, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1091), "YÜZÜK/DGF26YZ00584-3_(2).JPG", false, null, 180, 1, null },
                    { 421, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1092), "YÜZÜK/DGF26YZ00584.jpg", false, null, 180, 2, null },
                    { 422, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1093), "YÜZÜK/DGF26YZ00585-3_(2).JPG", false, null, 181, 1, null },
                    { 423, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1094), "YÜZÜK/DGF26YZ00585.jpg", false, null, 181, 2, null },
                    { 424, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1095), "YÜZÜK/DGF26YZ00586-3_(2).JPG", false, null, 182, 1, null },
                    { 425, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1096), "YÜZÜK/DGF26YZ00586.jpg", false, null, 182, 2, null },
                    { 426, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1097), "YÜZÜK/DGF26YZ00587-3_(2).JPG", false, null, 183, 1, null },
                    { 427, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1098), "YÜZÜK/DGF26YZ00587.jpg", false, null, 183, 2, null },
                    { 428, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1099), "YÜZÜK/DGF26YZ00588-3_(2).JPG", false, null, 184, 1, null },
                    { 429, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1100), "YÜZÜK/DGF26YZ00588.jpg", false, null, 184, 2, null },
                    { 430, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1101), "YÜZÜK/DGF26YZ00589-3_(2).JPG", false, null, 185, 1, null },
                    { 431, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1110), "YÜZÜK/DGF26YZ00589.jpg", false, null, 185, 2, null },
                    { 432, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1111), "YÜZÜK/DGF26YZ00590-3_(2).JPG", false, null, 186, 1, null },
                    { 433, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1112), "YÜZÜK/DGF26YZ00590.jpg", false, null, 186, 2, null },
                    { 434, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1113), "YÜZÜK/DGF26YZ00591-3_(2).JPG", false, null, 187, 1, null },
                    { 435, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1114), "YÜZÜK/DGF26YZ00591.jpg", false, null, 187, 2, null },
                    { 436, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1115), "YÜZÜK/NAİF1.jpg", false, null, 188, 1, null },
                    { 437, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1116), "YÜZÜK/NAİF10-3.JPG", false, null, 189, 1, null },
                    { 438, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1117), "YÜZÜK/NAİF10.jpg", false, null, 189, 2, null },
                    { 439, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1118), "YÜZÜK/NAİF2-3.JPG", false, null, 190, 1, null },
                    { 440, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1119), "YÜZÜK/NAİF2.jpg", false, null, 190, 2, null },
                    { 441, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1120), "YÜZÜK/NAİF3-3.JPG", false, null, 191, 1, null },
                    { 442, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1131), "YÜZÜK/NAİF3.jpg", false, null, 191, 2, null },
                    { 443, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1132), "YÜZÜK/NAİF4-3.JPG", false, null, 192, 1, null },
                    { 444, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1133), "YÜZÜK/NAİF4.jpg", false, null, 192, 2, null },
                    { 445, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1134), "YÜZÜK/NAİF5-3.JPG", false, null, 193, 1, null },
                    { 446, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1135), "YÜZÜK/NAİF5.jpg", false, null, 193, 2, null },
                    { 447, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1136), "YÜZÜK/NAİF6-3.JPG", false, null, 194, 1, null },
                    { 448, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1137), "YÜZÜK/NAİF6.jpg", false, null, 194, 2, null },
                    { 449, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1138), "YÜZÜK/NAİF7-3.JPG", false, null, 195, 1, null },
                    { 450, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1139), "YÜZÜK/NAİF7.jpg", false, null, 195, 2, null },
                    { 451, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1140), "YÜZÜK/NAİF8-3.JPG", false, null, 196, 1, null },
                    { 452, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1141), "YÜZÜK/NAİF8.jpg", false, null, 196, 2, null },
                    { 453, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1142), "YÜZÜK/NAİF9-3.JPG", false, null, 197, 1, null },
                    { 454, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1143), "YÜZÜK/NAİF9.jpg", false, null, 197, 2, null },
                    { 455, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1144), "YÜZÜK/NFYZ00001-3.JPG", false, null, 198, 1, null },
                    { 456, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1145), "YÜZÜK/NFYZ00001.jpg", false, null, 198, 2, null },
                    { 457, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1146), "YÜZÜK/NFYZ00002-3.JPG", false, null, 199, 1, null },
                    { 458, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1147), "YÜZÜK/NFYZ00002.jpg", false, null, 199, 2, null },
                    { 459, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1148), "YÜZÜK/NFYZ00003-3.JPG", false, null, 200, 1, null },
                    { 460, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1149), "YÜZÜK/NFYZ00003.jpg", false, null, 200, 2, null },
                    { 461, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1150), "YÜZÜK/NFYZ00004-3.JPG", false, null, 201, 1, null },
                    { 462, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1152), "YÜZÜK/NFYZ00004.jpg", false, null, 201, 2, null },
                    { 463, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1153), "YÜZÜK/NFYZ00005-3.JPG", false, null, 202, 1, null },
                    { 464, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1154), "YÜZÜK/NFYZ00005.jpg", false, null, 202, 2, null },
                    { 465, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1155), "YÜZÜK/NFYZ00006-3.JPG", false, null, 203, 1, null },
                    { 466, new DateTime(2026, 5, 17, 5, 38, 8, 454, DateTimeKind.Local).AddTicks(1156), "YÜZÜK/NFYZ00006.jpg", false, null, 203, 2, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMetals_ProductId",
                table: "ProductMetals",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrices_CustomerGroupId",
                table: "ProductPrices",
                column: "CustomerGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrices_ProductId",
                table: "ProductPrices",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ColorsId",
                table: "Products",
                column: "ColorsId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_StoneId",
                table: "Products",
                column: "StoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Stones_ColorsId",
                table: "Stones",
                column: "ColorsId");

            migrationBuilder.CreateIndex(
                name: "IX_Stones_UnitsId",
                table: "Stones",
                column: "UnitsId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CustomerGroupId",
                table: "Users",
                column: "CustomerGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RolesId",
                table: "Users",
                column: "RolesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ProductMetals");

            migrationBuilder.DropTable(
                name: "ProductPrices");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "CustomerGroups");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Stones");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Units");
        }
    }
}

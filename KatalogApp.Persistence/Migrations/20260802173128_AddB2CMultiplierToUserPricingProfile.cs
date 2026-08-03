using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KatalogApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddB2CMultiplierToUserPricingProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "B2CMultiplier",
                table: "UserPricingProfiles",
                type: "decimal(18,4)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 8, 2, 20, 31, 27, 893, DateTimeKind.Local).AddTicks(8914));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "B2CMultiplier",
                table: "UserPricingProfiles");

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 8, 2, 18, 36, 2, 347, DateTimeKind.Local).AddTicks(310));
        }
    }
}

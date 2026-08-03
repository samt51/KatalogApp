using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KatalogApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddNoteAndQuantityToUserActionLogs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "UserActionLogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "UserActionLogs",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 8, 2, 18, 36, 2, 347, DateTimeKind.Local).AddTicks(310));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "UserActionLogs");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "UserActionLogs");

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 24, 13, 41, 18, 577, DateTimeKind.Local).AddTicks(146));
        }
    }
}

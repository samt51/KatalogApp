using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KatalogApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddStoneScale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StoneScaleId",
                table: "Stones",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StoneScales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoneScales", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Stones",
                keyColumn: "Id",
                keyValue: 1,
                column: "StoneScaleId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stones",
                keyColumn: "Id",
                keyValue: 2,
                column: "StoneScaleId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stones",
                keyColumn: "Id",
                keyValue: 3,
                column: "StoneScaleId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stones",
                keyColumn: "Id",
                keyValue: 4,
                column: "StoneScaleId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Stones_StoneScaleId",
                table: "Stones",
                column: "StoneScaleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stones_StoneScales_StoneScaleId",
                table: "Stones",
                column: "StoneScaleId",
                principalTable: "StoneScales",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stones_StoneScales_StoneScaleId",
                table: "Stones");

            migrationBuilder.DropTable(
                name: "StoneScales");

            migrationBuilder.DropIndex(
                name: "IX_Stones_StoneScaleId",
                table: "Stones");

            migrationBuilder.DropColumn(
                name: "StoneScaleId",
                table: "Stones");
        }
    }
}

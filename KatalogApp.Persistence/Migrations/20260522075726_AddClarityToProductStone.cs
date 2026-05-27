using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KatalogApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddClarityToProductStone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClarityId",
                table: "ProductStones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "ProductStones",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductStones_ClarityId",
                table: "ProductStones",
                column: "ClarityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStones_ColorId",
                table: "ProductStones",
                column: "ColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductStones_Colors_ColorId",
                table: "ProductStones",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductStones_StoneClarities_ClarityId",
                table: "ProductStones",
                column: "ClarityId",
                principalTable: "StoneClarities",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductStones_Colors_ColorId",
                table: "ProductStones");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductStones_StoneClarities_ClarityId",
                table: "ProductStones");

            migrationBuilder.DropIndex(
                name: "IX_ProductStones_ClarityId",
                table: "ProductStones");

            migrationBuilder.DropIndex(
                name: "IX_ProductStones_ColorId",
                table: "ProductStones");

            migrationBuilder.DropColumn(
                name: "ClarityId",
                table: "ProductStones");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "ProductStones");
        }
    }
}

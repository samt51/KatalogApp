using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KatalogApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RemoveStoneName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Stones");

            migrationBuilder.UpdateData(
                table: "Stones",
                keyColumn: "Id",
                keyValue: 1,
                column: "StoneScaleId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stones",
                keyColumn: "Id",
                keyValue: 2,
                column: "StoneScaleId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Stones",
                keyColumn: "Id",
                keyValue: 3,
                column: "StoneScaleId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stones",
                keyColumn: "Id",
                keyValue: 4,
                column: "StoneScaleId",
                value: 4);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Stones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Stones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "StoneScaleId" },
                values: new object[] { "-2 Yuvarlak", null });

            migrationBuilder.UpdateData(
                table: "Stones",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "StoneScaleId" },
                values: new object[] { "-6.5 Yuvarlak", null });

            migrationBuilder.UpdateData(
                table: "Stones",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "StoneScaleId" },
                values: new object[] { "+6.5 Yuvarlak", null });

            migrationBuilder.UpdateData(
                table: "Stones",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "StoneScaleId" },
                values: new object[] { "+11 Yuvarlak", null });
        }
    }
}

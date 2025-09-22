using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySql.Migrations
{
    /// <inheritdoc />
    public partial class prijs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Prijs",
                table: "Merch",
                type: "float",
                precision: 2,
                nullable: true,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "Gewicht",
                table: "Merch",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Prijs",
                table: "Games",
                type: "float",
                precision: 2,
                nullable: true,
                oldClrType: typeof(float),
                oldType: "float");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Prijs",
                table: "Merch",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "float",
                oldPrecision: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Gewicht",
                table: "Merch",
                type: "float",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "Prijs",
                table: "Games",
                type: "float",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "float",
                oldPrecision: 2,
                oldNullable: true);
        }
    }
}

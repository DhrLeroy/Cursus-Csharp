using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB_School_Databank.Migrations
{
    /// <inheritdoc />
    public partial class klassen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leerlingen_Klas_KlasNaam",
                table: "Leerlingen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Klas",
                table: "Klas");

            migrationBuilder.RenameTable(
                name: "Klas",
                newName: "Klassen");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Klassen",
                table: "Klassen",
                column: "Naam");

            migrationBuilder.AddForeignKey(
                name: "FK_Leerlingen_Klassen_KlasNaam",
                table: "Leerlingen",
                column: "KlasNaam",
                principalTable: "Klassen",
                principalColumn: "Naam",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leerlingen_Klassen_KlasNaam",
                table: "Leerlingen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Klassen",
                table: "Klassen");

            migrationBuilder.RenameTable(
                name: "Klassen",
                newName: "Klas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Klas",
                table: "Klas",
                column: "Naam");

            migrationBuilder.AddForeignKey(
                name: "FK_Leerlingen_Klas_KlasNaam",
                table: "Leerlingen",
                column: "KlasNaam",
                principalTable: "Klas",
                principalColumn: "Naam",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

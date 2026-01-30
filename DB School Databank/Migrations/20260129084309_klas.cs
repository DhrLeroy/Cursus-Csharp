using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB_School_Databank.Migrations
{
    /// <inheritdoc />
    public partial class klas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KlasNaam",
                table: "Leerlingen",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Klas",
                columns: table => new
                {
                    Naam = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klas", x => x.Naam);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Leerlingen_KlasNaam",
                table: "Leerlingen",
                column: "KlasNaam");

            migrationBuilder.AddForeignKey(
                name: "FK_Leerlingen_Klas_KlasNaam",
                table: "Leerlingen",
                column: "KlasNaam",
                principalTable: "Klas",
                principalColumn: "Naam",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leerlingen_Klas_KlasNaam",
                table: "Leerlingen");

            migrationBuilder.DropTable(
                name: "Klas");

            migrationBuilder.DropIndex(
                name: "IX_Leerlingen_KlasNaam",
                table: "Leerlingen");

            migrationBuilder.DropColumn(
                name: "KlasNaam",
                table: "Leerlingen");
        }
    }
}

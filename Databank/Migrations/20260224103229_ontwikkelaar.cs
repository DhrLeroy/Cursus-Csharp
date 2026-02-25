using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Databank.Migrations
{
    /// <inheritdoc />
    public partial class ontwikkelaar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ontwikkelaar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Naam = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Oprichtingsjaar = table.Column<int>(type: "int", nullable: false),
                    Adres_HQ = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CEO = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ontwikkelaar", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OntwikkelaarVideogame",
                columns: table => new
                {
                    OntwikkelaarsId = table.Column<int>(type: "int", nullable: false),
                    VideogamesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OntwikkelaarVideogame", x => new { x.OntwikkelaarsId, x.VideogamesId });
                    table.ForeignKey(
                        name: "FK_OntwikkelaarVideogame_Ontwikkelaar_OntwikkelaarsId",
                        column: x => x.OntwikkelaarsId,
                        principalTable: "Ontwikkelaar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OntwikkelaarVideogame_Videogames_VideogamesId",
                        column: x => x.VideogamesId,
                        principalTable: "Videogames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_OntwikkelaarVideogame_VideogamesId",
                table: "OntwikkelaarVideogame",
                column: "VideogamesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OntwikkelaarVideogame");

            migrationBuilder.DropTable(
                name: "Ontwikkelaar");
        }
    }
}

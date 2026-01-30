using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieReviewWebsite.Migrations
{
    /// <inheritdoc />
    public partial class cast : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Acteurs_ActeurId",
                table: "Rating");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Films_FilmId",
                table: "Rating");

            migrationBuilder.DropIndex(
                name: "IX_Rating_ActeurId",
                table: "Rating");

            migrationBuilder.DropColumn(
                name: "ActeurId",
                table: "Rating");

            migrationBuilder.RenameColumn(
                name: "FilmId",
                table: "Rating",
                newName: "CastingId");

            migrationBuilder.RenameIndex(
                name: "IX_Rating_FilmId",
                table: "Rating",
                newName: "IX_Rating_CastingId");

            migrationBuilder.AddColumn<string>(
                name: "Commentaar",
                table: "Rating",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cast",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ActeurId = table.Column<int>(type: "int", nullable: false),
                    FilmId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cast", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cast_Acteurs_ActeurId",
                        column: x => x.ActeurId,
                        principalTable: "Acteurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cast_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Cast_ActeurId",
                table: "Cast",
                column: "ActeurId");

            migrationBuilder.CreateIndex(
                name: "IX_Cast_FilmId",
                table: "Cast",
                column: "FilmId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Cast_CastingId",
                table: "Rating",
                column: "CastingId",
                principalTable: "Cast",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Cast_CastingId",
                table: "Rating");

            migrationBuilder.DropTable(
                name: "Cast");

            migrationBuilder.DropColumn(
                name: "Commentaar",
                table: "Rating");

            migrationBuilder.RenameColumn(
                name: "CastingId",
                table: "Rating",
                newName: "FilmId");

            migrationBuilder.RenameIndex(
                name: "IX_Rating_CastingId",
                table: "Rating",
                newName: "IX_Rating_FilmId");

            migrationBuilder.AddColumn<int>(
                name: "ActeurId",
                table: "Rating",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rating_ActeurId",
                table: "Rating",
                column: "ActeurId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Acteurs_ActeurId",
                table: "Rating",
                column: "ActeurId",
                principalTable: "Acteurs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Films_FilmId",
                table: "Rating",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

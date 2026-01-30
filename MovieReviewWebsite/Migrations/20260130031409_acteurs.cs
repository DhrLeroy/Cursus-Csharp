using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieReviewWebsite.Migrations
{
    /// <inheritdoc />
    public partial class acteurs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Acteur_ActeurId",
                table: "Rating");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Acteur",
                table: "Acteur");

            migrationBuilder.RenameTable(
                name: "Acteur",
                newName: "Acteurs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Acteurs",
                table: "Acteurs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Acteurs_ActeurId",
                table: "Rating",
                column: "ActeurId",
                principalTable: "Acteurs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Acteurs_ActeurId",
                table: "Rating");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Acteurs",
                table: "Acteurs");

            migrationBuilder.RenameTable(
                name: "Acteurs",
                newName: "Acteur");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Acteur",
                table: "Acteur",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Acteur_ActeurId",
                table: "Rating",
                column: "ActeurId",
                principalTable: "Acteur",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB_Strips_Databank.Migrations
{
    /// <inheritdoc />
    public partial class rename_tables_tekenaar_album : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Album_Tekenaar_TekenaarId",
                table: "Album");

            migrationBuilder.DropForeignKey(
                name: "FK_Strips_Album_AlbumId",
                table: "Strips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tekenaar",
                table: "Tekenaar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Album",
                table: "Album");

            migrationBuilder.RenameTable(
                name: "Tekenaar",
                newName: "Tekenaars");

            migrationBuilder.RenameTable(
                name: "Album",
                newName: "Albums");

            migrationBuilder.RenameIndex(
                name: "IX_Album_TekenaarId",
                table: "Albums",
                newName: "IX_Albums_TekenaarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tekenaars",
                table: "Tekenaars",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Albums",
                table: "Albums",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Tekenaars_TekenaarId",
                table: "Albums",
                column: "TekenaarId",
                principalTable: "Tekenaars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Strips_Albums_AlbumId",
                table: "Strips",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Tekenaars_TekenaarId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Strips_Albums_AlbumId",
                table: "Strips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tekenaars",
                table: "Tekenaars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Albums",
                table: "Albums");

            migrationBuilder.RenameTable(
                name: "Tekenaars",
                newName: "Tekenaar");

            migrationBuilder.RenameTable(
                name: "Albums",
                newName: "Album");

            migrationBuilder.RenameIndex(
                name: "IX_Albums_TekenaarId",
                table: "Album",
                newName: "IX_Album_TekenaarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tekenaar",
                table: "Tekenaar",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Album",
                table: "Album",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Album_Tekenaar_TekenaarId",
                table: "Album",
                column: "TekenaarId",
                principalTable: "Tekenaar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Strips_Album_AlbumId",
                table: "Strips",
                column: "AlbumId",
                principalTable: "Album",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

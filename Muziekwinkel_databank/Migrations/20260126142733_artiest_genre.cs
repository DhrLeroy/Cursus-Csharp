using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Muziekwinkel_databank.Migrations
{
    /// <inheritdoc />
    public partial class artiest_genre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Artiesten",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Artiesten");
        }
    }
}

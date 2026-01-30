using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB_School_Databank.Migrations
{
    /// <inheritdoc />
    public partial class leerling_names : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Voornaam",
                table: "Leerlingen",
                newName: "First name");

            migrationBuilder.RenameColumn(
                name: "Naam",
                table: "Leerlingen",
                newName: "Last name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Last name",
                table: "Leerlingen",
                newName: "Naam");

            migrationBuilder.RenameColumn(
                name: "First name",
                table: "Leerlingen",
                newName: "Voornaam");
        }
    }
}

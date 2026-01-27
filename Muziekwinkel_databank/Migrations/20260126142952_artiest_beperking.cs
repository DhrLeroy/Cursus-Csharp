using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Muziekwinkel_databank.Migrations
{
    /// <inheritdoc />
    public partial class artiest_beperking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Heeft_Beperking",
                table: "Artiesten",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Heeft_Beperking",
                table: "Artiesten");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySQL.Migrations
{
    /// <inheritdoc />
    public partial class game_minimumleeftijd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MinimumLeeftijd",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MinimumLeeftijd",
                table: "Games");
        }
    }
}

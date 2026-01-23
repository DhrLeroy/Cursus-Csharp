using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyMotorbikeStore_MySQL.Migrations
{
    /// <inheritdoc />
    public partial class motorbike_instock : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InStock",
                table: "Motorbikes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InStock",
                table: "Motorbikes");
        }
    }
}

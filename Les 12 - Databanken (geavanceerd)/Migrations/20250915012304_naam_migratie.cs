using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Les_12___Databanken__geavanceerd_.Migrations
{
    /// <inheritdoc />
    public partial class naam_migratie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

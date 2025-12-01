using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySQLDatabank.Migrations
{
    /// <inheritdoc />
    public partial class start : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Gerecht",
                columns: table => new
                {
                    GerechtId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Naam = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Prijs = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gerecht", x => x.GerechtId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Naam = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PrijsPerKg = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.IngredientId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    MenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Naam = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Prijs = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.MenuId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GerechtIngredient",
                columns: table => new
                {
                    InGerechtenGerechtId = table.Column<int>(type: "int", nullable: false),
                    IngredientenIngredientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GerechtIngredient", x => new { x.InGerechtenGerechtId, x.IngredientenIngredientId });
                    table.ForeignKey(
                        name: "FK_GerechtIngredient_Gerecht_InGerechtenGerechtId",
                        column: x => x.InGerechtenGerechtId,
                        principalTable: "Gerecht",
                        principalColumn: "GerechtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GerechtIngredient_Ingredient_IngredientenIngredientId",
                        column: x => x.IngredientenIngredientId,
                        principalTable: "Ingredient",
                        principalColumn: "IngredientId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GerechtMenu",
                columns: table => new
                {
                    GerechtenGerechtId = table.Column<int>(type: "int", nullable: false),
                    InMenusMenuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GerechtMenu", x => new { x.GerechtenGerechtId, x.InMenusMenuId });
                    table.ForeignKey(
                        name: "FK_GerechtMenu_Gerecht_GerechtenGerechtId",
                        column: x => x.GerechtenGerechtId,
                        principalTable: "Gerecht",
                        principalColumn: "GerechtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GerechtMenu_Menus_InMenusMenuId",
                        column: x => x.InMenusMenuId,
                        principalTable: "Menus",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_GerechtIngredient_IngredientenIngredientId",
                table: "GerechtIngredient",
                column: "IngredientenIngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_GerechtMenu_InMenusMenuId",
                table: "GerechtMenu",
                column: "InMenusMenuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GerechtIngredient");

            migrationBuilder.DropTable(
                name: "GerechtMenu");

            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "Gerecht");

            migrationBuilder.DropTable(
                name: "Menus");
        }
    }
}

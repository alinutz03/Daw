using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace examenv3.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "canale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_canale", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "emisiuni",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titlu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Producator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnLansare = table.Column<int>(type: "int", nullable: false),
                    Gen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CanalId = table.Column<int>(type: "int", nullable: false),
                    Canal_TVId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emisiuni", x => x.Id);
                    table.ForeignKey(
                        name: "FK_emisiuni_canale_Canal_TVId",
                        column: x => x.Canal_TVId,
                        principalTable: "canale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_emisiuni_Canal_TVId",
                table: "emisiuni",
                column: "Canal_TVId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "emisiuni");

            migrationBuilder.DropTable(
                name: "canale");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace examen_daw.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filme",
                columns: table => new
                {
                    Filmid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titlu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    An = table.Column<int>(type: "int", nullable: false),
                    Gen = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filme", x => x.Filmid);
                });

            migrationBuilder.CreateTable(
                name: "Recenzii",
                columns: table => new
                {
                    RecenzieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    FilmId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recenzii", x => x.RecenzieId);
                    table.ForeignKey(
                        name: "FK_Recenzii_Filme_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Filme",
                        principalColumn: "Filmid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recenzii_FilmId",
                table: "Recenzii",
                column: "FilmId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recenzii");

            migrationBuilder.DropTable(
                name: "Filme");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyectos.App.Persistencia.Migrations
{
    public partial class Inicial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    meet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    whatapp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    formador = table.Column<int>(type: "int", nullable: false),
                    tutor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipos");
        }
    }
}

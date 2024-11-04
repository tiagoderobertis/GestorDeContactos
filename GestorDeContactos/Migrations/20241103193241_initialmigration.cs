using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestorDeContactos.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contactos",
                columns: table => new
                {
                    IdContacto = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NombreContacto = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    ApellidoContacto = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    NumeroTelefonoContacto = table.Column<int>(type: "INTEGER", maxLength: 20, nullable: true),
                    NumeroFijoContacto = table.Column<int>(type: "INTEGER", nullable: true),
                    TipoContacto = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contactos", x => x.IdContacto);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contactos");
        }
    }
}

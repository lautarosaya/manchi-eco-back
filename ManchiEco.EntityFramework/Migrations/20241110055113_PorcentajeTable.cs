using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManchiEco.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class PorcentajeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Porcentajes",
                columns: table => new
                {
                    PorcentajeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ahorro = table.Column<int>(type: "int", nullable: false),
                    Gustos = table.Column<int>(type: "int", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Porcentajes", x => x.PorcentajeID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Porcentajes");
        }
    }
}

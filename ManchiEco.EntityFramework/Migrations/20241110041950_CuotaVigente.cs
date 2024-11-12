using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManchiEco.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class CuotaVigente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Vigente",
                table: "Cuotas",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Vigente",
                table: "Cuotas");
        }
    }
}

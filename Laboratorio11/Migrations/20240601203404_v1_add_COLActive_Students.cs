using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Laboratorio11.Migrations
{
    /// <inheritdoc />
    public partial class v1_add_COLActive_Students : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Students",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Students");
        }
    }
}

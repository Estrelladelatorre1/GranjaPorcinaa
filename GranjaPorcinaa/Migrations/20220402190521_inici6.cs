using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GranjaPorcinaa.Migrations
{
    /// <inheritdoc />
    public partial class inici6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Idcer",
                table: "Ventas",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Idcer",
                table: "Ventas");
        }
    }
}

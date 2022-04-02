using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GranjaPorcinaa.Migrations
{
    /// <inheritdoc />
    public partial class inicial30 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdCer",
                table: "Vacunas",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCer",
                table: "Vacunas");
        }
    }
}

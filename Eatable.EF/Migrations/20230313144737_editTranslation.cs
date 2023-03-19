using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eatable.EF.Migrations
{
    /// <inheritdoc />
    public partial class editTranslation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fr",
                table: "Translation",
                newName: "Fra");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fra",
                table: "Translation",
                newName: "Fr");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eatable.EF.Migrations
{
    /// <inheritdoc />
    public partial class addKeyIdentifer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KeyIdentifier",
                columns: table => new
                {
                    ObjectCode = table.Column<int>(type: "int", nullable: false),
                    Identifier = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyIdentifier", x => x.ObjectCode);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KeyIdentifier");
        }
    }
}

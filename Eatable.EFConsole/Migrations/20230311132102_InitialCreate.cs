using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eatable.EFConsole.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Translations",
                columns: table => new
                {
                    TranslationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TranslationIdentifier = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TranslationType = table.Column<int>(type: "int", nullable: false),
                    ModuleType = table.Column<int>(type: "int", nullable: false),
                    Nld = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Eng = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Deu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translations", x => x.TranslationId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Translations");
        }
    }
}

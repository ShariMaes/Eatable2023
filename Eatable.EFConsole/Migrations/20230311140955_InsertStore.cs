using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eatable.EFConsole.Migrations
{
    /// <inheritdoc />
    public partial class InsertStore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Translations",
                table: "Translations");

            migrationBuilder.RenameTable(
                name: "Translations",
                newName: "Translation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Translation",
                table: "Translation",
                column: "TranslationId");

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postalcode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    StoreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StoreIdentifier = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StoreName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StoreType = table.Column<int>(type: "int", nullable: false),
                    OpeningHours = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoreUrl = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LogoName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.StoreId);
                    table.ForeignKey(
                        name: "FK_Store_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "AddressId");
                });

            migrationBuilder.CreateTable(
                name: "ContactInformation",
                columns: table => new
                {
                    ContactId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ObjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContactInformationTypeCode = table.Column<int>(type: "int", nullable: false),
                    ContactInfo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    StoreId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInformation", x => x.ContactId);
                    table.ForeignKey(
                        name: "FK_ContactInformation_Store_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Store",
                        principalColumn: "StoreId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactInformation_StoreId",
                table: "ContactInformation",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Store_AddressId",
                table: "Store",
                column: "AddressId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactInformation");

            migrationBuilder.DropTable(
                name: "Store");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Translation",
                table: "Translation");

            migrationBuilder.RenameTable(
                name: "Translation",
                newName: "Translations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Translations",
                table: "Translations",
                column: "TranslationId");
        }
    }
}

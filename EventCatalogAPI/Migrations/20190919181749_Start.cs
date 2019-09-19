using Microsoft.EntityFrameworkCore.Migrations;

namespace EventCatalogAPI.Migrations
{
    public partial class Start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "catalog_category_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "catalog_type_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "events_hilo",
                incrementBy: 10);

            migrationBuilder.CreateTable(
                name: "CatalogCategories",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    Category = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogCategories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CatalogTypes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    Type = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Information = table.Column<string>(nullable: false),
                    AddressLineOne = table.Column<string>(nullable: false),
                    AddressLineTwo = table.Column<string>(maxLength: 100, nullable: true),
                    City = table.Column<string>(maxLength: 100, nullable: false),
                    State = table.Column<string>(maxLength: 50, nullable: false),
                    Country = table.Column<string>(maxLength: 100, nullable: false),
                    Zipcode = table.Column<int>(nullable: false),
                    Time = table.Column<string>(nullable: false),
                    PictureURL = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    PresenterName = table.Column<string>(nullable: true),
                    NumberOfTickets = table.Column<int>(nullable: false),
                    CatalogCategoryID = table.Column<int>(nullable: false),
                    CatalogTypeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_CatalogCategories_CatalogCategoryID",
                        column: x => x.CatalogCategoryID,
                        principalTable: "CatalogCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Events_CatalogTypes_CatalogTypeID",
                        column: x => x.CatalogTypeID,
                        principalTable: "CatalogTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_CatalogCategoryID",
                table: "Events",
                column: "CatalogCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Events_CatalogTypeID",
                table: "Events",
                column: "CatalogTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "CatalogCategories");

            migrationBuilder.DropTable(
                name: "CatalogTypes");

            migrationBuilder.DropSequence(
                name: "catalog_category_hilo");

            migrationBuilder.DropSequence(
                name: "catalog_type_hilo");

            migrationBuilder.DropSequence(
                name: "events_hilo");
        }
    }
}

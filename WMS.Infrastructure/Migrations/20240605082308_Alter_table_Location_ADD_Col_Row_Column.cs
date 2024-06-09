using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Alter_table_Location_ADD_Col_Row_Column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttributeLocation");

            migrationBuilder.AddColumn<int>(
                name: "Col",
                table: "Locations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Row",
                table: "Locations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Col",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "Row",
                table: "Locations");

            migrationBuilder.CreateTable(
                name: "AttributeLocation",
                columns: table => new
                {
                    AttributesAttributeId = table.Column<int>(type: "int", nullable: false),
                    LocationsLocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeLocation", x => new { x.AttributesAttributeId, x.LocationsLocationId });
                    table.ForeignKey(
                        name: "FK_AttributeLocation_Attributes_AttributesAttributeId",
                        column: x => x.AttributesAttributeId,
                        principalTable: "Attributes",
                        principalColumn: "AttributeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttributeLocation_Locations_LocationsLocationId",
                        column: x => x.LocationsLocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttributeLocation_LocationsLocationId",
                table: "AttributeLocation",
                column: "LocationsLocationId");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking.Migrations
{
    /// <inheritdoc />
    public partial class ModifyStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Cities_CityTypeId",
                table: "Cities");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CityTypeId",
                table: "Cities",
                column: "CityTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Cities_CityTypeId",
                table: "Cities");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CityTypeId",
                table: "Cities",
                column: "CityTypeId",
                unique: true);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking.Migrations
{
    /// <inheritdoc />
    public partial class CityTypeMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_CityType_TypeId",
                table: "Cities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CityType",
                table: "CityType");

            migrationBuilder.RenameTable(
                name: "CityType",
                newName: "CitiesType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CitiesType",
                table: "CitiesType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_CitiesType_TypeId",
                table: "Cities",
                column: "TypeId",
                principalTable: "CitiesType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_CitiesType_TypeId",
                table: "Cities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CitiesType",
                table: "CitiesType");

            migrationBuilder.RenameTable(
                name: "CitiesType",
                newName: "CityType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CityType",
                table: "CityType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_CityType_TypeId",
                table: "Cities",
                column: "TypeId",
                principalTable: "CityType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

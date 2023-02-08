using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking.Migrations
{
    /// <inheritdoc />
    public partial class ModifyCity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "TypeId",
                table: "Cities",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "CityType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_TypeId",
                table: "Cities",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_CityType_TypeId",
                table: "Cities",
                column: "TypeId",
                principalTable: "CityType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_CityType_TypeId",
                table: "Cities");

            migrationBuilder.DropTable(
                name: "CityType");

            migrationBuilder.DropIndex(
                name: "IX_Cities_TypeId",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Cities");
        }
    }
}

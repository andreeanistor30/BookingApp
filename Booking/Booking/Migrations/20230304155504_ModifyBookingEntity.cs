using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking.Migrations
{
    /// <inheritdoc />
    public partial class ModifyBookingEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Rooms_RoomId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Users_UserId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_RoomId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Booking");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Booking",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "HotelId",
                table: "Booking",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RoomTypeId",
                table: "Booking",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Booking_HotelId",
                table: "Booking",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_RoomTypeId",
                table: "Booking",
                column: "RoomTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Hotels_HotelId",
                table: "Booking",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_RoomType_RoomTypeId",
                table: "Booking",
                column: "RoomTypeId",
                principalTable: "RoomType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Users_UserId",
                table: "Booking",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Hotels_HotelId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_RoomType_RoomTypeId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Users_UserId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_HotelId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_RoomTypeId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "HotelId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "RoomTypeId",
                table: "Booking");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Booking",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RoomId",
                table: "Booking",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Booking_RoomId",
                table: "Booking",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Rooms_RoomId",
                table: "Booking",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Users_UserId",
                table: "Booking",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

﻿using BookingApp.Models.Domain;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Booking.Models.Domain
{
    public class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [ForeignKey("HotelId")]
        public Hotel Hotel { get; set; }

        public int NumberOfRooms { get; set; }

        public double Price { get; set; }

        [ForeignKey("RoomTypeId")]
        public RoomType RoomType { get; set; }

    }
}

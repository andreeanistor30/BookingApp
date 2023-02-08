using Booking.Models.Domain;
using BookingApp.Models.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace Booking.DataTransferObjects
{
    public class RoomDTO
    {
        public Hotel Hotel { get; set; }

        public int NumberOfRooms { get; set; }

        public double Price { get; set; }

        public RoomType RoomType { get; set; }
    }
}

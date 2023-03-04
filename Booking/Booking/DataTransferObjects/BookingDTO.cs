using Booking.Models.Domain;
using BookingApp.Models.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace Booking.DataTransferObjects
{
    public class BookingDTO
    {
        public Guid UserId { get; set; }

        public DateTime Checkin { get; set; }

        public DateTime Checkout { get; set; }

        public Guid HotelId { get; set; }

        public Guid RoomTypeId { get; set; }
    }
}

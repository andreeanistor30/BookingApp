using Booking.Models.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace Booking.DataTransferObjects
{
    public class BookingDTO
    {
        public User UserId { get; set; }

        public DateTime Checkin { get; set; }

        public DateTime Checkout { get; set; }

        public double TotalPrice { get; set; }
        public Room RoomId { get; set; }
    }
}

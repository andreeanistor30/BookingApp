using BookingApp.Models.Domain;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Booking.Models.Domain
{
    public class BookingModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        public DateTime Checkin { get; set; }

        public DateTime Checkout { get; set; }

        public double TotalPrice { get; set; }

        [ForeignKey("RoomId")]
        public Room Room { get; set; }
    }
}

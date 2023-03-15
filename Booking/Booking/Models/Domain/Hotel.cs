using Booking.Models.Domain;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingApp.Models.Domain
{
    public class Hotel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Town { get; set; }

        public string Category { get; set; }

        public byte[] Image { get; set; } 

        public double Rate { get; set; }

        public IEnumerable<Room> Rooms { get; set; }
    }
}

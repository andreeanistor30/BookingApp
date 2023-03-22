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

        [ForeignKey("CityId")]
        public Guid CityId { get; set; }
        public virtual City City { get; set; }

        [Required]
        public string Name { get; set; }

        public byte[] Image { get; set; }

        [Required]
        public double Rate { get; set; }

        public IEnumerable<Room> Rooms { get; set; }
    }
}

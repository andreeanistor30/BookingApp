using BookingApp.Models.Domain;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Booking.Models.Domain
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Country { get; set; }

        [ForeignKey("CityTypeId")]
        public Guid CityTypeId { get; set; }
        public virtual CityType CityType { get; set; }

        public IEnumerable<Hotel> Hotel { get; set; }

        
    }
}

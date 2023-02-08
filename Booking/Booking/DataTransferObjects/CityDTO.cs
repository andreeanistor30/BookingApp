using Booking.Models.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace Booking.DataTransferObjects
{
    public class CityDTO
    {
        public string Name { get; set; }

        public string Country { get; set; }

        public Guid CityTypeId { get; set; }
    }
}

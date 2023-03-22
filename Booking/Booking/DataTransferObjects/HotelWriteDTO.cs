using Booking.Models.Domain;
using System.Drawing;

namespace Booking.DataTransferObjects
{
    public class HotelWriteDTO
    {
        public Guid CityId { get; set; }

        public string Name { get; set; }

        public Image ImagePath { get; set; }

        public double Rate { get; set; }
    }
}

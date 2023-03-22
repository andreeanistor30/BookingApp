using Booking.Models.Domain;

namespace Booking.DataTransferObjects
{
    public class HotelDTO
    {
        public Guid CityId { get; set; }

        public string Name { get; set; }

        public string ImagePath { get; set; }

        public double Rate { get; set; }


    }
}

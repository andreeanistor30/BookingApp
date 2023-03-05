using Booking.Models.Domain;
using BookingApp.Models.Domain;

namespace Booking.WrapperObject
{
    public class HotelWrapper
    {
        public List<Hotel>? Hotels;

        public int TotalRecords;

        public int ReturnedRecords;

        public HotelWrapper(List<Hotel>? hotels, int totalRecords, int returnedRecords)
        {
            Hotels = hotels;
            TotalRecords = totalRecords;
            ReturnedRecords = returnedRecords;
        }
    }
}

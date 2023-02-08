using Booking.DataTransferObjects;
using BookingApp.Models.Domain;

namespace Booking.Services.HotelServices
{
    public interface IHotelService
    {
        public Hotel? GetHotelBy(Guid? id);

        public IEnumerable<Hotel> GetAllHotel();

        public Hotel? InsertHotel(HotelDTO hotel);

        public Hotel? DeleteHotel(Guid Id);

        public Hotel? UpdateHotel(Hotel h);

    }
}

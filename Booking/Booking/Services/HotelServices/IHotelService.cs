using Booking.DataTransferObjects;
using BookingApp.Models.Domain;
using static System.Net.Mime.MediaTypeNames;

namespace Booking.Services.HotelServices
{
    public interface IHotelService
    {
        public Hotel? GetHotelBy(Guid? id);

        public IEnumerable<Hotel> GetAllHotel();

        public Hotel? InsertHotel(HotelDTO hotel);

        public Hotel? DeleteHotel(Guid Id);

        public Hotel? UpdateHotel(Hotel h);

        public IEnumerable<HotelWriteDTO>? GetHotelsWithFilter(string type);

    }
}

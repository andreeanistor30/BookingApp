using Booking.DataTransferObjects;
using Booking.Models.Domain;

namespace Booking.Services.BookingService
{
    public interface IBookingService
    {
        public BookingModel? InsertBooking(BookingDTO bookingDTO);
    }
}

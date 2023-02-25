using Booking.DataTransferObjects;
using Booking.Models.Domain;
using Microsoft.AspNetCore.SignalR;

namespace Booking.Services.BookingService
{
    public class BookingService : IBookingService
    {
        private readonly ApplicationDatabaseContext context;

        public BookingService(ApplicationDatabaseContext context)
        {
            this.context = context;
        }

        public BookingModel? InsertBooking(BookingDTO bookingDTO)
        {
            var booking = new BookingModel()
            {
                User = bookingDTO.UserId,
                Checkin = bookingDTO.Checkin,
                Checkout = bookingDTO.Checkout,
                Room = bookingDTO.RoomId
            };

            context.Booking.Add(booking);
            context.SaveChanges();
            return booking;

        }
    }
}

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

        public List<BookingModel> GetBooking(DateTime checkin, DateTime checkout, string city)
        {
            var existingCity = context.Cities.Where(c => c.Name == city).FirstOrDefault();
            if (existingCity != null)
            {
                var booking = context.Booking.Where(b => b.Checkin < checkin && b.Checkout < checkout).ToList();
                if (booking != null)
                {
                    return booking;
                }
                else return null;
            }
            else return null;

        }
    }
}

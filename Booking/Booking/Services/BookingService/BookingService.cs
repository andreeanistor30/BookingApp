using Booking.DataTransferObjects;
using Booking.Models.Domain;
using BookingApp.Models.Domain;
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
            var hotel = context.Hotels.FirstOrDefault(h => h.Id == bookingDTO.HotelId);
            var roomType = context.RoomType.FirstOrDefault(r => r.Id == bookingDTO.RoomTypeId);
            var user = context.Users.FirstOrDefault(u => u.Id == bookingDTO.UserId);
            var booking = new BookingModel()
            {
                User = user,
                Checkin = bookingDTO.Checkin,
                Checkout = bookingDTO.Checkout,
                Hotel = hotel,
                RoomType = roomType

            };

            context.Booking.Add(booking);
            context.SaveChanges();
            return booking;

        }

        public BookingModel? DeleteBooking(Guid Id)
        {
            var booking = context.Booking.Find(Id);
            if (booking != null)
            {
                context.Remove(booking);
                context.SaveChanges();
                return booking;
            }
            else return null;
        }
    }
}

    //    public List<BookingModel> GetBooking(DateTime checkin, DateTime checkout, string city)
    //    {
    //        var existingCity = context.Cities.Where(c => c.Name == city).FirstOrDefault();
    //        if (existingCity != null)
    //        {
    //            var booking = context.Booking.Where(b => checkin >= b.Checkin && checkin <= b.Checkout
    //                                                || (checkout >= b.Checkin && checkout <= b.Checkout)
    //                                                || (b.Checkin >= checkin && b.Checkin <= checkout)
    //                                                || (b.Checkout >= checkin && b.Checkout <= checkout)).ToList();
    //            if (booking != null)
    //            {

    //            }
    //            else return null;
    //        }
    //        else return null;

    //    }
    //}




using AutoMapper;
using Booking.DataTransferObjects;
using BookingApp.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Booking.Services.HotelServices
{
    public class HotelService : IHotelService
    {
        private readonly ApplicationDatabaseContext context;

        public HotelService(ApplicationDatabaseContext context)
        {
            this.context = context;
        }

        public Hotel? GetHotelBy(Guid? id)
        {
            var hotel = context.Hotels.Where(h => h.Id == id).FirstOrDefault();
            return hotel;
        }

        public IEnumerable<Hotel> GetAllHotel()
        {
            IEnumerable<Hotel> hotels = context.Hotels.ToList();
            return hotels;
        }

        public Hotel? InsertHotel(HotelDTO newHotel)
        {
            var hotel = new Hotel
            {
                Town = newHotel.Town,
                Category = newHotel.Category,
                Rate = newHotel.Rate,
                Image = Utils.Utils.ImageToByteArrayFromFilePath(newHotel.ImagePath)
            };
            context.Hotels.Add(hotel);
            context.SaveChanges();
            return hotel;

        }

        public Hotel? DeleteHotel(Guid Id)
        {
            var hotel = context.Hotels.Find(Id);
            if (hotel != null)
            {
                context.Remove(hotel);
                context.SaveChanges();
                return hotel;
            }
            else return null;
        }

        public Hotel? UpdateHotel(Hotel h)
        {
            var hotel = context.Hotels.Where(c => c.Id == h.Id).FirstOrDefault();
            hotel.Town = h.Town;
            hotel.Category = h.Category;
            if (hotel != null)
            {
                context.Update(hotel);
                context.SaveChanges();
                return hotel;
            }
            else return null;
        }

        public IEnumerable<HotelWriteDTO>? GetHotelsWithFilter(string type)
        {
            var hotels = context.Hotels.Where(h => h.Category.Equals(type)).ToList();
            List<HotelWriteDTO?> result = new List<HotelWriteDTO?>();
            for (int i=0; i<hotels.Count;i++)
            {
                HotelWriteDTO hotelWriteDTO = new HotelWriteDTO()
                {
                    Town = hotels[i].Town,
                    Category = hotels[i].Category,
                    Rate = hotels[i].Rate,
                    ImagePath = Utils.Utils.ByteArrayToImagebyMemoryStream(hotels[i].Image)
                };
                result.Add(hotelWriteDTO);
            }
            if (result != null)
                return result;
            else return null;
        }

    }
}

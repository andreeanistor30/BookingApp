using Booking.DataTransferObjects;
using Booking.Models.Domain;
using Booking.Pagination;
using Booking.WrapperObject;
using BookingApp.Models.Domain;

namespace Booking.Services.CityServices
{
    public class CityService : ICityService
    {
        private readonly ApplicationDatabaseContext context;

        public CityService(ApplicationDatabaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<City> GetAll()
        {
            IEnumerable<City> cities = context.Cities.ToList();
            return cities;
        }

        public City? InsertCity(CityDTO newCity)
        {
            var city = new City()
            {
                Name = newCity.Name,
                Country = newCity.Country,
                CityTypeId = newCity.CityTypeId
            };
            context.Cities.Add(city);
            context.SaveChanges();
            return city;

        }
    }
}

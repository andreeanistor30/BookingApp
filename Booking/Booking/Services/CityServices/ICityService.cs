using Booking.DataTransferObjects;
using Booking.Models.Domain;
using Booking.Pagination;
using Booking.WrapperObject;

namespace Booking.Services.CityServices
{
    public interface ICityService
    {
        public City? InsertCity(CityDTO city);

        public IEnumerable<City> GetAll();
    }
}

using Booking.DataTransferObjects;
using Booking.Models.Domain;

namespace Booking.Services.CityTypeServices
{
    public interface ICityTypeService
    {
        public CityType? AddCityType(CityTypeDTO cityType);

        public CityType? DeleteCityType(Guid Id);
    }
}

using Booking.DataTransferObjects;
using Booking.Models.Domain;
using BookingApp.Models.Domain;

namespace Booking.Services.CityTypeServices
{
    public class CityTypeService : ICityTypeService
    {
        public readonly ApplicationDatabaseContext context;

        public CityTypeService(ApplicationDatabaseContext context)
        {
            this.context = context;
        }

        public CityType? AddCityType(CityTypeDTO cityTypeDto)
        {
            var cityType = new CityType
            {
                Type = cityTypeDto.Type
            };
            context.CitiesType.Add(cityType);
            context.SaveChanges();
            return cityType;
        }

        public CityType? DeleteCityType(Guid Id)
        {
            var cityType = context.CitiesType.Find(Id);
            if (cityType != null)
            {
                context.Remove(cityType);
                context.SaveChanges();
                return cityType;
            }
            else return null;
        }
    }
}

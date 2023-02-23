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

        public CityWrapper GetAll(CityPaginationParameters paginationParameters)
        {
            IEnumerable<City> cities = context.Cities.ToList();

            if (paginationParameters.SortingParameters != null)
            {
                switch (paginationParameters.SortingParameters.Value.SortingCriteria)
                {
                    case "Name":
                        if (paginationParameters.SortingParameters.Value.AscendingOrder)
                        {
                            cities = cities.OrderBy(c => c.Name);
                        }
                        else
                        {
                            cities = cities.OrderByDescending(c => c.Name);
                        }
                        break;
                    case "Country":
                        if (paginationParameters.SortingParameters.Value.AscendingOrder)
                        {
                            cities = cities.OrderBy(c => c.Country);
                        }
                        else
                        {
                            cities = cities.OrderByDescending(c => c.Country);
                        }
                        break;
                }
            }

            if (string.IsNullOrEmpty(paginationParameters.SearchByCityName) != true)
            {
                cities = cities.Where(x => x.Name.Contains(paginationParameters.SearchByCityName));
            }

            cities = cities.Skip((paginationParameters.PageNumber - 1) * paginationParameters.PageSize).Take(paginationParameters.PageSize);

            CityWrapper citiesWrapper = new CityWrapper(cities.ToList(), context.Cities.Count(), cities.ToList().Count());

            return citiesWrapper;
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

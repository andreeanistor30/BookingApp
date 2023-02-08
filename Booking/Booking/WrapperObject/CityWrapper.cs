using Booking.Models.Domain;

namespace Booking.WrapperObject
{
    public class CityWrapper
    {
        public List<City>? Cities;

        public int TotalRecords;

        public int ReturnedRecords;

        public CityWrapper(List<City>? cities, int totalRecords, int returnedRecords)
        {
            Cities = cities;
            TotalRecords = totalRecords;
            ReturnedRecords = returnedRecords;
        }
    }
}

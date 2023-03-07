using Booking.DataTransferObjects;
using Booking.Models.Domain;
using Booking.Pagination;
using Booking.Services.CityServices;
using Booking.WrapperObject;
using BookingApp.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Controllers
{
    [ApiController]
    [Route("city")]
    public class CityController : ControllerBase
    {
        private readonly ICityService service;

        public CityController(ICityService service)
        {
            this.service = service;
        }

        [HttpPost]
        public ActionResult<City> InsertCity(CityDTO city)
        {
            var newCity = service.InsertCity(city);
            if (newCity != null)
            {
                return Ok();
            }
            else return NotFound("Couldn't insert this city");
        }

        [HttpGet]
        [Route("get")]

        public ActionResult<IEnumerable<CityWrapper>> GetAllCity()
        {
            IEnumerable<City> cities = service.GetAll();

            if (cities != null)
            {
                return Ok(cities);
            }
            else return NotFound();
   
        }
    }
}

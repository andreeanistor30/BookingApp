using Booking.DataTransferObjects;
using Booking.Models.Domain;
using Booking.Services.CityTypeServices;
using BookingApp.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Controllers
{
    [ApiController]
    [Route("cityType")]
    public class CityTypeController : ControllerBase
    {
        public readonly ICityTypeService service;

        public CityTypeController(ICityTypeService service)
        {
            this.service = service;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<CityType> InsertCityType(CityTypeDTO cityType)
        {
            var newCityType = service.AddCityType(cityType);
            if (newCityType != null)
            {
                return Ok();
            }
            else return NotFound("Couldn't insert this cityType");
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult Delete(Guid id)
        {
            var item = service.DeleteCityType(id);
            if (item != null)
                return Ok();
            else
                return NotFound();

        }
    }
}

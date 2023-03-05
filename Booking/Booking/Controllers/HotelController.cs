using Booking.DataTransferObjects;
using Booking.Services.HotelServices;
using BookingApp.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Controllers
{
    [ApiController]
    [Route("hotels")]
    public class HotelController : ControllerBase
    {
        private readonly IHotelService service;

        public HotelController(IHotelService service)
        {
            this.service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Hotel>>GetAllHotels()
        {
            var item = service.GetAllHotel();
            if (item == null)
                return NotFound();
            else
                return Ok(item);
        }

        [HttpGet("{id}")]
        public ActionResult<Hotel>GetById(Guid id)
        {
            var item = service.GetHotelBy(id);

            if (item == null)
            {
                return NotFound("Couldn't find the hotel with this id");
            }
            else
                return Ok(item);
        }

        [HttpPost]
        public ActionResult<Hotel> InsertHotel(HotelDTO hotel)
        {
            var newHotel=service.InsertHotel(hotel);
            if (newHotel != null)
            {
                return Ok();
            }
            else return NotFound("Couldn't insert this hotel");
        }

        [HttpDelete]

        public ActionResult Delete(Guid id)
        {
            var item=service.DeleteHotel(id);
            if (item != null)
                return Ok();
            else 
                return NotFound();

        }

        [HttpPut]
        public ActionResult Update(Hotel h)
        {
            var hotel=service.UpdateHotel(h);
            if (hotel != null)
                return Ok();
            else return NotFound();
        }

        [HttpGet("/getByFilter")]
        public ActionResult<Hotel> GetHotelsByFilter(string filter)
        {
            var hotels = service.GetHotelsWithFilter(filter);

            if (hotels != null)
                return Ok(hotels);
            else return NotFound();
        }



    }
}

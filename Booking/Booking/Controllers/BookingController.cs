using Booking.DataTransferObjects;
using Booking.Models.Domain;
using Booking.Services.BookingService;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Controllers
{
    [ApiController]
    [Route("booking")]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService service;

        public BookingController(IBookingService service)
        {
            this.service = service;
        }

        [HttpPost]
        public ActionResult<BookingModel> InsertBooking(BookingDTO booking)
        {
            var newBooking = service.InsertBooking(booking);

            if (newBooking != null)
            {
                return Ok(newBooking);
            }
            else
                return NotFound();
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult Delete(Guid id)
        {
            var item = service.DeleteBooking(id);
            if (item != null)
                return Ok();
            else
                return NotFound();

        }

        //[HttpGet]
        //public ActionResult<IEnumerable<BookingDTO>> GetBooking(DateTime checkin, DateTime checkout, string city)
        //{
        //    var booking = service.GetBooking(checkin, checkout, city);

        //    if(booking != null)
        //    {
        //        return Ok(booking);
        //    }
        //    else 
        //        return NotFound();

        //}



    }
}

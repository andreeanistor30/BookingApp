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

        public ActionResult<BookingModel>InsertBooking(BookingDTO booking)
        {
            var newBooking = service.InsertBooking(booking);

            if (newBooking != null)
            {
                return Ok(newBooking);
            }
            else 
                return NotFound();
        }

       
      
    }
}

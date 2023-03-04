using Booking.DataTransferObjects;
using Booking.Models.Domain;
using Booking.Services.RoomServices;
using Booking.Services.RoomTypes;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Controllers
{
    [ApiController]
    [Route("roomType")]
    public class RoomTypeController : ControllerBase
    {
        private readonly IRoomTypesService service;

        public RoomTypeController(IRoomTypesService service)
        {
            this.service = service;
        }

        [HttpPost]
        public ActionResult<RoomType> InsertRoomType(RoomTypeDTO roomType)
        {
            var room = service.InsertRoomType(roomType);
            if (room == null)
            {
                return NotFound();
            }
            else
                return Ok(room);
        }


    }
}

using Booking.Models.Domain;
using Booking.Services.RoomServices;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Controllers
{
    [ApiController]
    [Route("room")]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService service;

        public RoomController(IRoomService service)
        {
            this.service = service;
        }


        [HttpGet]
         public ActionResult<IEnumerable<Room>> GetAll()
        {
            var roomList = service.GetAll();
            if (roomList == null)
            {
                return NotFound();
            }
            else
                return Ok(roomList);
        }

        [HttpGet("{id}")]
        public ActionResult<Room> GetBy(Guid Id)
        {
            var room = service.GetRoomBy(Id);

            if (room == null)
            {
                return NotFound();
            }
            else
                return Ok(room);


        }

        [HttpPost]
        public ActionResult<Room> InsertRoom(Room room)
        {
            var Room = service.InsertRoom(room);
            if(Room == null)
            {
                return NotFound();
            }
            else
                return Ok(Room);
        }

        [HttpDelete]
         public ActionResult<Room>DeleteRoom(Guid Id)
        {
            var room=service.DeleteRoom(Id);
            if(room == null)
                return NotFound();
            else
                return Ok(room);
        }


        [HttpPut]
        public ActionResult<Room>UpdateRoom(Room r)
        {
            var room = service.UpdateRoom(r);
            if (room != null)
                return Ok();
            else return NotFound();
        }
    }
}

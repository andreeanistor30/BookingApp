using Booking.Models.Domain;

namespace Booking.Services.RoomServices
{
    public interface IRoomService
    {
        public IEnumerable<Room> GetAll();

        public Room? GetRoomBy(Guid Id);

        public Room? InsertRoom(Room room);

        public Room? DeleteRoom(Guid Id);

        public Room? UpdateRoom(Room room);
    }
}

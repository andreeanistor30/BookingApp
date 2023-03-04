using Booking.DataTransferObjects;
using Booking.Models.Domain;
using BookingApp.Models.Domain;

namespace Booking.Services.RoomServices
{
    public class RoomService : IRoomService
    {
        private readonly ApplicationDatabaseContext context;
        public IEnumerable<Room> GetAll()
        {
            var roomList = context.Rooms.ToList();

            return roomList;
        }

        public Room? GetRoomBy(Guid Id)
        {
            var room = context.Rooms.Where(r => r.Id == Id).FirstOrDefault();
            return room;
        }

        public Room? InsertRoom(RoomDTO newRoom)
        {
            var room = new Room
            {
               Hotel = newRoom.Hotel,
               NumberOfRooms= newRoom.NumberOfRooms,
               Price = newRoom.Price,
               RoomType = newRoom.RoomType
            };
            context.Rooms.Add(room);
            context.SaveChanges();
            return room;

        }

        public Room? DeleteRoom(Guid Id)
        {
            var room = context.Rooms.Find(Id);
            if (room != null)
            {
                context.Remove(room);
                context.SaveChanges();
                return room;
            }
            else return null;
        }

        public Room? UpdateRoom(Room room)
        {
            var Room = context.Rooms.Where(r => r.Id == r.Id).FirstOrDefault();
            Room.NumberOfRooms = room.NumberOfRooms;
            Room.Price = room.Price;
            Room.RoomType = room.RoomType;
            if (Room != null)
            {
                context.Update(Room);
                context.SaveChanges();
                return Room;
            }
            else return null;
        }
    }
}

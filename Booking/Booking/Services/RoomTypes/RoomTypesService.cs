using Booking.DataTransferObjects;
using Booking.Models.Domain;
using BookingApp.Models.Domain;
using XAct;

namespace Booking.Services.RoomTypes
{
    public class RoomTypesService : IRoomTypesService
    {
        private readonly ApplicationDatabaseContext context;

        public RoomTypesService(ApplicationDatabaseContext context)
        {
            this.context = context;
        }

        public RoomType? InsertRoomType(RoomTypeDTO roomType)
        {
                var room = new RoomType
                {
                    Type = roomType.Type
                };
                context.RoomType.Add(room);
                context.SaveChanges();
                return room;

            }

    
    }
    
}

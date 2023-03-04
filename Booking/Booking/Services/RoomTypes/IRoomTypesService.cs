using Booking.DataTransferObjects;
using Booking.Models.Domain;

namespace Booking.Services.RoomTypes
{
    public interface IRoomTypesService
    {
        public RoomType? InsertRoomType(RoomTypeDTO roomType);

    }
}

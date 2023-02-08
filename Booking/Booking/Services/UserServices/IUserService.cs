using Booking.DataTransferObjects;
using Booking.Models.Domain;

namespace Booking.Services.UserServices
{
    public interface IUserService
    {
        public User? InsertUser(UserDTO user);

        public User? DeleteUser(Guid Id);
    }
}

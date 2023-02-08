using Booking.DataTransferObjects;
using Booking.Models.Domain;

namespace Booking.Services.LoginService
{
    public interface ILoginService
    {
        public User Login(LoginUserDTO user);
    }
}

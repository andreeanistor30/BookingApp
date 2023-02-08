using System.ComponentModel.DataAnnotations;

namespace Booking.DataTransferObjects
{
    public class UserDTO
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Adress { get; set; }

        public string Country { get; set; }

        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

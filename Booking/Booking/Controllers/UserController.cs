using Booking.DataTransferObjects;
using Booking.Models.Domain;
using Booking.Services.UserServices;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        private readonly IUserService service;

        public UserController(IUserService service)
        {
            this.service = service;
        }

        [HttpPost]
        public ActionResult<User> InsertUser(UserDTO user)
        {
            var User = service.InsertUser(user);
            if (User == null)
            {
                return NotFound();
            }
            else
                return Ok(User);
        }

        //[HttpDelete]
        //public ActionResult<User> DeleteUser(Guid Id)
        //{
        //    var user = service.DeleteUser(Id);
        //    if (user == null)
        //        return NotFound();
        //    else
        //        return Ok(user);
        //}
    }
}

using Booking.DataTransferObjects;
using Booking.Models.Domain;
using Booking.Services.LoginService;
using Booking.Services.RoomServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Controllers
{
    [ApiController]
    [Route("login")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService service;

        public LoginController(ILoginService service)
        {
            this.service = service;
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult<LoginUserDTO> Login(LoginUserDTO user)
        {
            var User = service.Login(user);

            if(User==null)
            {
                return BadRequest();
            }
            else
                return Ok(User);
        }
    }
}

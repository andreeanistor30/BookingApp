using Booking.DataTransferObjects;
using Booking.Models.Domain;
using BookingApp.Models.Domain;
using System.Security.Cryptography;
using System.Text;
using XAct;
using XSystem.Security.Cryptography;

namespace Booking.Services.LoginService
{
    public class LoginService:ILoginService
    {
        public readonly ApplicationDatabaseContext context;

        public LoginService(ApplicationDatabaseContext context)
        {
            this.context = context;
        }

        public User Login(LoginUserDTO user)
        {
            var tmpSource = ASCIIEncoding.ASCII.GetBytes(user.Password);
            byte[] tmpNewHash;
            tmpNewHash = new XSystem.Security.Cryptography.MD5CryptoServiceProvider().ComputeHash(tmpSource);
            var hash= context.Users.Where(u => u.UserName == user.Username).FirstOrDefault();

            if (hash != null)
            {
                
                if (hash.Password.Equals(Convert.ToHexString(tmpNewHash))==true)
                    return hash;
                else
                    return null;
            }

            else return null;

            
        }
    }
}

using Booking.DataTransferObjects;
using Booking.Models.Domain;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.Security.Cryptography;
using System.Text;
using XAct;
using XSystem.Security.Cryptography;

namespace Booking.Services.UserServices
{
    public class UserService: IUserService
    {
        public readonly ApplicationDatabaseContext context;

        public UserService(ApplicationDatabaseContext context)
        {
            this.context = context;
        }   

        public User? InsertUser(UserDTO user)
        {
            var newUser = new User()
            {
                UserName = user.UserName,
                Password = user.Password,
                Email = user.Email,
                Adress = user.Adress,
                Country = user.Country,
                FirstName = user.FirstName,
                LastName = user.LastName

            };
            var tmpSource = ASCIIEncoding.ASCII.GetBytes(user.Password);
            byte[] tmpNewHash;
            var savedPasswordHash = new XSystem.Security.Cryptography.MD5CryptoServiceProvider().ComputeHash(tmpSource);
            newUser.Password = Convert.ToHexString(savedPasswordHash);
            context.Users.Add(newUser);
            context.SaveChanges();
            return newUser;
        }

        public User? DeleteUser(Guid Id)
        {
            var user = context.Users.Find(Id);
            if (user != null)
            {
                context.Remove(user);
                context.SaveChanges();
                return user;
            }
            else return null;
        }
    }
}

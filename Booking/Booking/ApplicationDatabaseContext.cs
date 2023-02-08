using Booking.Models.Domain;
using BookingApp.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Booking
{
    public class ApplicationDatabaseContext:DbContext
    {
        public readonly DbContextOptions _options;

        public ApplicationDatabaseContext()
        {

        }
        public ApplicationDatabaseContext(DbContextOptions<ApplicationDatabaseContext> options) : base(options)
        {
            _options = options;
        }
        public DbSet<User> Users { get; set; }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<BookingModel> Booking { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<CityType> CitiesType { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ANDREEA\\SQLEXPRESS;Database=BookingDataBase;Trusted_Connection=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
    


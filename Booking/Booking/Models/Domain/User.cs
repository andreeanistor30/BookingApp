using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Booking.Models.Domain
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20)]
        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Adress { get; set; }

        public string Country { get; set; }

        [Required]
        [StringLength(20)]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}

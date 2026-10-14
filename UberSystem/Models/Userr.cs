using System.ComponentModel.DataAnnotations;

namespace UberSystem.Models
{
    public class Userr
    {
        /*
         * o	FullName(Required,3-100)
o	Email(Required,Email)
o	Password (Required)
o	Phone(Required,Phone)
o	Role(Required)
         */
        [Key]
        public int Id { get; set; }
        [Required,MaxLength(100),MinLength(3)]
        public string Name { get; set; }
        [Required,EmailAddress]
        public string EmailAddress { get; set; }
        [Required]
        public string Password { get; set; }
        [Required,Phone]
        public string Phone { get; set; }
        [Required]
        public string Role { get; set; }
        public Vehicle? Vehicle { get; set; }
        public ICollection<Ride> DriverRides { get; set; } = new List<Ride>();
        public ICollection<Ride> RiderRides { get; set; } = new List<Ride>();
    }
}
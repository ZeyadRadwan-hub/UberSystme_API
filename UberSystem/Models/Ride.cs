using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace UberSystem.Models
{
    public class Ride
    {
        [Key]
        public int Id { get; set; }
        /*o	PickupLocation(Required,Max150)
        o	DropOffLocation(Required,Max150)
        o	Fare(Range20-5000)
        o	Status(Required)
        o	RiderId
        o	DriverId
         */
        [Required,MaxLength(150)]
        public string PickupLocation { get; set; }
        [Required, MaxLength(150)]
        public string DropOffLocation { get; set; }
        [Range(20,5000)]
        public int Fare { get; set; }
        [Required]
        public string Status {  get; set; }

        [Required]  
        [ForeignKey(nameof(RiderId))]
        public int RiderId { get; set; }
        public Userr? UserRider { get; set; }


        [Required]
        [ForeignKey(nameof(DriverId))]
        public int DriverId { get; set; }
        public Userr? UserDriver { get; set; }

      
        public Payment? Payment { get; set; }
        public Rating? Rating { get; set; }
    }
}

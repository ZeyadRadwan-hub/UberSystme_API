using System.ComponentModel.DataAnnotations;

namespace UberSystem.Models
{
    public class Payment
    {
        /*
         * o	Amount(Range20-5000),
o	PaymentMethod(Required)
o	PaymentDate(Required)
o	Status(Required)
o	RideId
         */
        [Key]
        public int Id { get; set; }
        [Required]
        public string PaymentMethod { get; set; }
        [Required]
        public DateTime PaymentDate { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public int RideId {  get; set; }
        public Ride? Ride {  get; set; }
    }
}

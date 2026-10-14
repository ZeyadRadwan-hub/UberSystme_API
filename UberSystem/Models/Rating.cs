using System.ComponentModel.DataAnnotations;

namespace UberSystem.Models
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }
        /*
         * o	Score(Range1-5)
o	Comment(Max250)
o	RideId

         */
        [Range(1,5)]
        public int Score { get; set; }
        [MaxLength(250)]
        public string Comment { get; set; }
        [Required]
        public int RideId { get; set; }
        public Ride? Ride { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UberSystem.Models
{
    public class Vehicle
    {
        
        [Key]
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string Model { get; set; }
        [Required,MaxLength(20)]
        public string PlateNumber { get; set; }
            
        [Required]
        public string Color {  get; set; }
        [Required]
        [ForeignKey(nameof(Driver))]
        public int DriverId {  get; set; }
        public Userr? Driver { get; set; }
    }
}

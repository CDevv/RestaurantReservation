using System.ComponentModel.DataAnnotations;

namespace RestaurantReservation.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
    }
}

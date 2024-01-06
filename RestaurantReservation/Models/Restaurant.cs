using System.ComponentModel.DataAnnotations;

namespace RestaurantReservation.Models
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Range(1, 10)]
        public double? Rating { get; set; }
    }
}

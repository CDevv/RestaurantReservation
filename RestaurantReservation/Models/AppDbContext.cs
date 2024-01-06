using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Models;

namespace RestaurantReservation.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Restaurant>? Restaurant { get; set; }
        public DbSet<Reservation>? Reservations { get; set; }
    }
}

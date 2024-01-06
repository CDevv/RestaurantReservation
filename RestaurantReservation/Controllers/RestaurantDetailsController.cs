using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Models;

namespace RestaurantReservation.Controllers
{
    public class RestaurantDetailsController : Controller
    {
        private readonly AppDbContext _context;

        public RestaurantDetailsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: RestaurantDetails
        public async Task<IActionResult> Index(int? id)
        {
            Restaurant restaurant = await _context.Restaurant.FindAsync(id);
            if (restaurant == null)
            {
                return NotFound();
            }
            return View(restaurant);
        }

        public async Task<IActionResult> Reservation(int? id)
        {
            Restaurant restaurant = await _context.Restaurant.FindAsync(id);
            if (restaurant == null)
            {
                return NotFound();
            }

            Reservation reservation = new();

            return View(reservation);
        }
    }
}

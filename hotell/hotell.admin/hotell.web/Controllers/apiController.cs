using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Domain.Models;
using hotell.web.Models;

namespace hotell.web.Controllers
{
    [Produces("application/json")]
    [Route("api")]
    public class apiController : Controller
    {
        private readonly DataContext _context;

        public apiController(DataContext context)
        {
            _context = context;
        }
        
        //API
        [Route("/api/Rooms")]
        public async Task<List<Room>> Rooms()
        {
            return await _context.Rooms.ToListAsync();
        }

        //API
        [Route("/api/Booking")]
        [HttpGet]
        public async Task<List<Booking>> Booking(DateTime date)
        {
            return await _context.Bookings.Where(x => x.FromDate >= date).ToListAsync();
        }

        //API
        [Route("/api/BookRom")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBooking(int id, int roomnumber)
        {
            var booking = _context.Bookings.FirstOrDefault(b => b.BookingId == id);
            if (booking == null)
            {
                return NotFound();
            }
            booking.RoomNumber = roomnumber;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return NoContent();
        }

        // POST: api/PostBooking
        [HttpPost]
        [Route("/api/PostBooking")]
        public async Task<IActionResult> PostBooking(string fromdate, string todate,string customername, string customeradress, string customerphone, string ischeckedin)
        {
            if (string.IsNullOrEmpty(fromdate) && string.IsNullOrEmpty(todate)
                && string.IsNullOrEmpty(customername) && string.IsNullOrEmpty(customeradress)
                && string.IsNullOrEmpty(customeradress) && string.IsNullOrEmpty(ischeckedin))
            {
                return BadRequest(ModelState);
            }
            var booking = new Booking()
            {
                FromDate = Convert.ToDateTime(fromdate),
                ToDate = Convert.ToDateTime(todate),
                CustomerName = customername,
                CustomerPhone = customerphone,
                CustomerAdress = customeradress,
                IsCheckedIn = Convert.ToBoolean(ischeckedin)
            };
            _context.Bookings.Add(booking);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (BookingExists(booking.BookingId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return Ok();
        }

        // GET: api/GetBookings
        [HttpGet]
        public IEnumerable<Booking> GetBookings()
        {
            return _context.Bookings;
        }

        private bool BookingExists(int id)
        {
            return _context.Bookings.Any(e => e.BookingId == id);
        }
    }
}
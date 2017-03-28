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
            return await _context.Bookings.Where(x => x.FromDate >= date && x.ToDate < date).ToListAsync();
        }


        // GET: api/api
        [HttpGet]
        public IEnumerable<Booking> GetBookings()
        {
            return _context.Bookings;
        }

        //// GET: api/api/5
        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetBooking([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var booking = await _context.Bookings.SingleOrDefaultAsync(m => m.BookingId == id);

        //    if (booking == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(booking);
        //}

        //// PUT: api/api/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutBooking([FromRoute] int id, [FromBody] Booking booking)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != booking.BookingId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(booking).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!BookingExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/api
        //[HttpPost]
        //public async Task<IActionResult> PostBooking([FromBody] Booking booking)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _context.Bookings.Add(booking);
        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (BookingExists(booking.BookingId))
        //        {
        //            return new StatusCodeResult(StatusCodes.Status409Conflict);
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtAction("GetBooking", new { id = booking.BookingId }, booking);
        //}

        //// DELETE: api/api/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteBooking([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var booking = await _context.Bookings.SingleOrDefaultAsync(m => m.BookingId == id);
        //    if (booking == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Bookings.Remove(booking);
        //    await _context.SaveChangesAsync();

        //    return Ok(booking);
        //}

        private bool BookingExists(int id)
        {
            return _context.Bookings.Any(e => e.BookingId == id);
        }
    }
}
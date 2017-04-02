using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace hotell.web.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Room> Rooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>().ToTable("Booking");
            modelBuilder.Entity<Room>().ToTable("Room");
        }
    }
}

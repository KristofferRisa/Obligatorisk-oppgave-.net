using System;

namespace admin.Models
{
    class Booking
    {
        public int BookingId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAdress { get; set; }
        public DateTime Date { get; set; }
        public DateTime BookingDate { get; set; }
        public bool RoomNumber { get; set; }
        public bool IsCheckedIn { get; set; }
        public bool IsActive { get; set; }
        public DateTime Modified { get; set; }
        public override string ToString()
        {
            return $"{Date} {CustomerName}";
        }
    }
}

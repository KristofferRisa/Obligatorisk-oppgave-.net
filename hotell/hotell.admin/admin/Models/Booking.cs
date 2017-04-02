using System;

namespace admin.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public string ReservationCode { get; set; }
        public int RoomNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAdress { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool IsCheckedIn { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public override string ToString()
        {
            return $"{FromDate.ToShortDateString()} - {CustomerName}. Room: {RoomNumber}";
        }
    }
}

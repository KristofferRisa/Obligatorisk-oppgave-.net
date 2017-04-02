using System;

namespace admin.Models
{
    class Room
    {
        public int RoomId { get; set; }
        public int RoomNumber { get; set; }
        public string RoomName { get; set; }
        public int Floor { get; set; }
        public decimal Price { get; set; }
        public DateTime Modified { get; set; }
    }
}

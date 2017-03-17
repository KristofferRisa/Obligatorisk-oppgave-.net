using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        [Range(1,14)]
        public int RomNumber { get; set; }
        public string RomeName { get; set; }
        public bool IsAvaliable { get; set; }
        [Range(1,3)]
        public int Floor { get; set; }
        public decimal Price { get; set; }
        public DateTime Modified { get; set; }
    }
}

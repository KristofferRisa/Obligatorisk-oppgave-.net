using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }

        [Display(Name = "Rom nr")]
        public int RoomNumber { get; set; }

        [Display(Name = "Navn")]
        public string RoomName { get; set; }

        [Range(1,3)]
        [Display(Name = "Etasje")]
        public int Floor { get; set; }

        [Display(Name = "Pris")]
        public decimal Price { get; set; }

        [Display(Name = "Endret")]
        public DateTime Modified { get; set; }
    }
}

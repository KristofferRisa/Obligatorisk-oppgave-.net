﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        
        [Display(Name = "Reservasjonskode")]
        public string ReservationCode { get; set; }

        public int RoomNumber { get; set; }
        
        [Required]
        [Display(Name = "Navn")]
        public string CustomerName { get; set; }

        [Required]
        [Display(Name = "Telefon")]
        public string CustomerPhone { get; set; }

        [Display(Name = "Adresse")]
        public string CustomerAdress { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fra dato")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FromDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Til dato")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ToDate { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{dd:MM:yyyy}", ApplyFormatInEditMode = true)]
        //public DateTime BookingDate { get; set; }

        public bool IsCheckedIn { get; set; }

        public DateTime Created { get; set; }

        [Required]
        public DateTime Modified { get; set; }
    }
}

﻿using System;

namespace Domain.Models
{
    public class Availability
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int NumberOfReservations { get; set; }
    }
}

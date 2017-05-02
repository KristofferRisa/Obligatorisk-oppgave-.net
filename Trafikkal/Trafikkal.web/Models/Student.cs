using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trafikkal.web.Models
{
    public class Student
    {
        public string Id { get; set; }        
        public string UserId { get; set; }
        [Required]
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public string Telefon { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

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

using System;
using System.ComponentModel.DataAnnotations;

namespace Trafikkal.web.Models
{
    public class Question
    {
        public int Id { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public string Text { get; set; }
        public string Img { get; set; }
        public string Video { get; set; }
        public string Alternative1 { get; set; }
        public string Alternative2 { get; set; }
        public string Alternative3 { get; set; }
        public string Alternative4 { get; set; }
        [Required]
        public string Answer { get; set; }
        [Required]
        public bool Active { get; set; }
        public DateTime Created { get; set; }
    }
}
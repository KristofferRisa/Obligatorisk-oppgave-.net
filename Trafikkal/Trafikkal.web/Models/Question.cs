using System;
using System.ComponentModel.DataAnnotations;

namespace Trafikkal.web.Models
{
    public class Question
    {
        public int Id { get; set; }

        public int QuizId { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public string Text { get; set; }
        public string Img { get; set; }
        public string Video { get; set; }

        [Required]
        public string Alternative1 { get; set; }

        [Required]
        public string Alternative2 { get; set; }
        public string Alternative3 { get; set; }
        public string Alternative4 { get; set; }
        public string Alternative5 { get; set; }
        
        [Required]
        public bool IsAlternative1Correct { get; set; }

        [Required]
        public bool IsAlternative2Correct { get; set; }
        public bool IsAlternative3Correct { get; set; }
        public bool IsAlternative4Correct { get; set; }
        public bool IsAlternative5Correct { get; set; }
        [Required]
        public bool IsMultipleChoice { get; set; }
        [Required]
        public bool Active { get; set; }
        public DateTime Created { get; set; }
    }
}
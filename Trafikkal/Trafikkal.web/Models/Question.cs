using System;
using System.ComponentModel;
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
        [DisplayName("Question")]
        public string Text { get; set; }

        [DisplayName("Image")]
        public string Img { get; set; }
        
        public string Video { get; set; }

        public string Alternative1 { get; set; }
        
        public string Alternative2 { get; set; }

        public string Alternative3 { get; set; }

        public string Alternative4 { get; set; }

        public string Alternative5 { get; set; }
        
        [DisplayName("Is correct")]
        public bool IsAlternative1Correct { get; set; }
        
        [DisplayName("Is correct")]
        public bool IsAlternative2Correct { get; set; }

        [DisplayName("Is correct")]
        public bool IsAlternative3Correct { get; set; }

        [DisplayName("Is correct")]
        public bool IsAlternative4Correct { get; set; }

        [DisplayName("Is correct")]
        public bool IsAlternative5Correct { get; set; }

        [Required]
        [DisplayName("Is it multiple choice")]
        public bool IsMultipleChoice { get; set; }

        [Required]
        public bool Active { get; set; }

        public DateTime Created { get; set; }
    }
}
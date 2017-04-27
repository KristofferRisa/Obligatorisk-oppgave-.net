using System;
using System.ComponentModel.DataAnnotations;

namespace Trafikkal.web.Models
{
    public class Answer
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        [Required]
        public int QuestionNumber { get; set; }

        [Required]
        public int Alternative { get; set; }

        public DateTime Created { get; set; }
    }
}

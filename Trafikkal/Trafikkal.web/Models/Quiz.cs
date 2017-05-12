using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Trafikkal.web.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DisplayName("Minimum score to pass")]
        public decimal MinScoreToPass { get; set; }
        [DisplayName("Spørsmål")]
        public virtual List<Question> Questions { get; set; }
    }
}

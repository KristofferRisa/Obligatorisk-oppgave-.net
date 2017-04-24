using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trafikkal.web.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        [Required]
        public int QuestionNumber { get; set; }
        [Required]
        public string Alternative { get; set; }
        public DateTime Created { get; set; }
    }
}

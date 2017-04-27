using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trafikkal.web.Models
{
    public class AnswerViewModel
    {
        [Required]
        public int QuestionNumber { get; set; }

        public string Alternative { get; set; }

        public string Alternative1 { get; set; }

        public string Alternative2 { get; set; }

        public string Alternative3 { get; set; }

        public string Alternative4 { get; set; }

        public string Alternative5 { get; set; }
    }
}

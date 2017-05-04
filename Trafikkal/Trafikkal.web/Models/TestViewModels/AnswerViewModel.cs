using System.ComponentModel.DataAnnotations;

namespace Trafikkal.web.Models.TestViewModels
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

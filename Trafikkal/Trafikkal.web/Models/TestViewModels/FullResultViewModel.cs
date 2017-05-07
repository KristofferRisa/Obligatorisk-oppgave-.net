using System.Collections.Generic;

namespace Trafikkal.web.Models.TestViewModels
{
    public class FullResultViewModel
    {
        public List<Question> Questions { get; set; }
        public List<Answer> Answers { get; set; }
        public UserScore UserScore { get; set; }
    }
}
